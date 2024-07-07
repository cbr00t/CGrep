using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Security;
using System.Threading.Tasks;

namespace CGrep {
    public partial class CMainUI : CFormUI {
        public CList<string> fileList = new CList<string>();

        public CMainUI() { InitializeComponent(); }
        void onLoad(object sender, EventArgs e) { initSablonDDList(); uiDDSablon.SelectedIndex = 0; }
        void uiSearchAndReplace_CheckedChanged(object sender, EventArgs e) { foreach (var ctl in new Control[] { this.label2, this.uiReplaceText }) { ctl.Enabled = this.uiSearchAndReplace.Checked; } }
        void uiFindBtn_Click( object sender, EventArgs e ) {
            this.fileList.Clear(); clear();
            if (this.uiMaxFileSize.Text.toInt32() > 50) {
                if ("Boyutu '50 MB' dan fazla olan dosyalarý almayý seçtiniz.\r\nOkunan dosyalarýn tamamý belleðe yüklenmektedir.\r\nÇok büyük boyutlu dosyalar, iþlem sýrasýnda bellek dolmasýna ve sistem kararsýzlýðýna sebep olabilir.\r\nDevam etmek istiyor musunuz?".confirmE() != DialogResult.Yes)
                    return;
            }
            if (!isPathValid()) { string.Format("Girdiðiniz Dizin: [{0}] GEÇERSÝZDÝR!\nLütfen baþka bir arama dizini seçiniz.", this.uiSearchDirectory.Text).informE(); return; }
            var ti = CThreadInfo.start("ProgressUI", () => {
                ProgressUI.show("Dizin yapýsý oluþturuluyor...", "", ProgressBarStyle.Marquee, false);
                Application.DoEvents();
			}); ti.wait(200); ti = null;
            var pUI = ProgressUI.self; if (pUI != null) { pUI.uiBtnIptal.Enabled = true; pUI.uiBtnIptal.Click += (_sender, _e) => { if (ti != null) { ti.abort(); } }; }
			Application.DoEvents(); Task.Factory.StartNew(() => {
                try { ti = CThreadInfo.CurrentThreadInfo; ti.Name = "Scan File Process"; fetchFileList(files => scanFiles(files)); ProgressUI.hide(); }
                catch (Exception ex) { ProgressUI.hide(); CExceptionHandler.goster(null, ex); }
                finally { ti = null; }
            }, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
			(10).millisecondsWait(); ti?.wait();
        }
        void uiBtnFindInResults_Click(object sender, EventArgs e) {
            fileList.Clear();
            foreach (ListViewItem item in uiFindFilesList.Items) { var dosyaTamAdi = item.Tag as string; if (dosyaTamAdi != null) { fileList.Add(dosyaTamAdi); } }
            scanFiles();
        }
        void btnSearchDirList_Click(object sender, EventArgs e) { dizinListesiAc(); }
        void uiSearchText_TextChanged(object sender, EventArgs e) { uiBtnFindInResults.Enabled = uiSearchText.Text != ""; }
        void uiOpenBtn_Click(object sender, EventArgs e) {
            if (uiFindFilesList.SelectedItems.Count == 0) { "Lütfen açmak istediðiniz dosyayý listeden seçiniz!".warnMsgE(); return; }
            var itemColl = uiFindFilesList.SelectedItems;
            foreach (ListViewItem item in itemColl) {
                var dosyaTamAdi = item.Tag as string; if (dosyaTamAdi == null) { continue; }
                dosyaTamAdi.startProcessWith(isUseShellExecute: true, windowStyle: ProcessWindowStyle.Normal);
            }
        }
        void uiOpenDirectoryBtn_Click(object sender, EventArgs e) {
            if (uiFindFilesList.SelectedItems.Count == 0) { "Lütfen bulunduðu dizini açmak istediðiniz dosyayý listeden seçiniz!".warnMsgE(); return; }
            var itemColl = uiFindFilesList.SelectedItems;
            foreach (ListViewItem item in itemColl) { var path = item.SubItems[3].Text; "explorer".startProcessWith(arguments: path, isUseShellExecute: false, windowStyle: ProcessWindowStyle.Hidden); }
        }
        void uiExitBtn_Click(object sender, EventArgs e) { this.Close(); }
        void uiDeleteFileBtn_Click( object sender, EventArgs e ) {
            if (uiFindFilesList.SelectedItems.Count == 0) { "Lütfen açmak istediðiniz dosyayý listeden seçiniz!".warnMsgE(); return; }
            var items = uiFindFilesList.SelectedItems;
            var msg = items.Count == 1 ? string.Format("({0}) dosyasýný silmek istiyor musunuz?", items[0].Text) : "Birden çok dosyayý SÝLMEK istiyor musunuz?";
            if (msg.confirmE(true) != DialogResult.Yes) { return; }
            foreach (ListViewItem item in items) {
                string dosyaTamAdi = item.Tag as string; if (dosyaTamAdi == null) { continue; }
                if (File.Exists(dosyaTamAdi)) { File.Delete(dosyaTamAdi); }
                try { uiFindFilesList.Items.Remove(item); } catch { }
            }
        }
        void uiClearBtn_Click(object sender, EventArgs e) { clear(); }
        void uiFindFilesList_DoubleClick(object sender, EventArgs e) { uiOpenBtn.PerformClick(); }
        void uiMaxFileSize_TextChanged(object sender, EventArgs e) {
            try {
                var maxFileSize = uiMaxFileSize.Text.toInt32(); if (maxFileSize < 0) { uiMaxFileSize.ForeColor = Color.Red; }
                else if (maxFileSize > 50) { uiMaxFileSize.ForeColor = Color.DarkGray; }
                else { uiMaxFileSize.ForeColor = SystemColors.WindowText; }
            }
            catch { uiMaxFileSize.ForeColor = Color.Red; }
        }
        void uiSearchDirectory_TextChanged(object sender, EventArgs e) {
            try { var path = uiSearchDirectory.Text; uiSearchDirectory.ForeColor = Directory.Exists(path) ? SystemColors.WindowText : Color.Red; }
            catch { uiSearchDirectory.ForeColor = Color.Red; }
        }
        void uiDDSablon_SelectedIndexChanged( object sender, EventArgs e ) {
            var sablon = uiDDSablon.SelectedItem as CSablon; if (sablon == null) { return; }
            if (sablon.SearchDir.bosDegilMi()) { uiSearchDirectory.Text = sablon.SearchDir; }
            if (sablon.Mask.bosDegilMi()) { uiPattern.Text = sablon.Mask; }
            uiDDSablon.SelectedIndex = 0;
        }
        void initSablonDDList() {
            uiDDSablon.deferredDraw(() => {
                var devPath = @"F:\DEVELOPMENT\VAST\VioDev"; if (!Directory.Exists(devPath)) { devPath = @"C:\VioDev"; }
                DirectoryInfo vioDevRoot = devPath.asDirInfo(), vioDevData = vioDevRoot.pathCombine("Data").asDirInfo(), vioDevDbDef = vioDevRoot.pathCombine("DbDef").asDirInfo();
                uiDDSablon.Items.Clear(); uiDDSablon.Items.Add("-- SEÇÝNÝZ --");
                uiDDSablon.Items.AddRange(new[] {
                    new CSablon("*.*", vioDevData.FullName), new CSablon("*TanRap*.*", vioDevData.FullName), new CSablon("*TanFis*.*", vioDevData.FullName),
                    new CSablon("*.ini", vioDevData.FullName), new CSablon("*.frx", vioDevData.FullName), new CSablon("*.*", vioDevDbDef.FullName),
                    new CSablon("*.qry", vioDevDbDef.FullName), new CSablon("db*.qry", vioDevDbDef.FullName), new CSablon("Ver*.qry", vioDevDbDef.FullName),
                    new CSablon("*.*", CPath.CData.FullName), new CSablon("*TanRap*.*", CPath.CData.FullName), new CSablon("*TanFis*.*", CPath.CData.FullName),
                    new CSablon("*.ini", CPath.CData.FullName), new CSablon("*.frx", CPath.CData.FullName), new CSablon("*.*", CPath.CDbDef.FullName),
                    new CSablon("*.qry", CPath.CDbDef.FullName), new CSablon("db*.qry", CPath.CDbDef.FullName), new CSablon("Ver*.qry", CPath.CDbDef.FullName),
                    new CSablon("*.*", CPath.CData.FullName), new CSablon("*.*", CPath.CProgRoot.FullName), new CSablon("*.*", CPath.CTerminal.FullName),
                    new CSablon("*.*", CPath.CTerminalOrtak.FullName), new CSablon("*.*", null), new CSablon("*.qry", null),
                    new CSablon("db*.qry", null), new CSablon("Ver*.qry", null), new CSablon("*.ini", null),
                    new CSablon("*.frx", null), new CSablon("*.exe", null), new CSablon("*.dll", null)
                });
            });
        }
        protected bool isPathValid() { try { return Directory.Exists( this.uiSearchDirectory.Text ); } catch { return false; } }
        protected void clear() { uiFindFilesList.Items.Clear(); uiFindFilesList.Groups.Clear(); }
        public void fetchFileList(Action<string[]> proc = null) {
            string rootDir = uiSearchDirectory.Text?.Trim(), pattern = uiPattern.Text?.TrimEnd().emptyCoalesce(diger: "*.*"); var includeSubDirs = uiIncludeSubDirectories.Checked;
            Action<string> addFiles = dirPath => {
                try {
                    var files = Directory.GetFiles(dirPath, pattern, SearchOption.TopDirectoryOnly); if (files?.Length == 0) { return; }
                    if (proc == null) { this.fileList.AddRange(files); } else { proc(files); }
				}
                catch (SystemException) { }
            };
            Action<string> addDir = null; addDir = dirPath => {
				try {
					if (!Directory.Exists(dirPath)) { return; } addFiles(dirPath); Application.DoEvents(); if (!includeSubDirs) { return; }
                    var dirs = Directory.GetDirectories(dirPath, "*.*", SearchOption.TopDirectoryOnly); if (dirs?.Length == 0) { return; }
                    Parallel.ForEach(dirs, new ParallelOptions() { MaxDegreeOfParallelism = 2, TaskScheduler = TaskScheduler.Default }, subDirPath => addDir(subDirPath));
                }
                catch (SystemException) { }
			};
            addDir(rootDir);
		}
        void scanFiles(string[] files = null) {
            if (files == null) { files = this.fileList.ToArray(); }
            var pUI = ProgressUI.self; if (pUI != null) { pUI.uiLblMsg.Text = "Dosyalar aranýyor..."; } Application.DoEvents();
            if (pUI != null) { pUI.uiProgressBar1.Style = ProgressBarStyle.Continuous; pUI.uiProgressBar1.Minimum = 0; pUI.uiProgressBar1.Maximum = files.Length; pUI.uiProgressBar1.Value = 0; }
            int refreshCounter = 0; uiFindFilesList.SuspendLayout(); uiFindFilesList.Visible = false;
            var maxSizeBytes = uiMaxFileSize.Text.toInt32() * 1024 * 1024; string searchText = uiSearchText.Text, searchTextLower = searchText.ToLower();
            var replaceFlag = uiSearchAndReplace.Checked; var replaceText = replaceFlag ? uiReplaceText.Text : null;
			foreach (var filePath in files) {
                if (refreshCounter++ > 20) { Application.DoEvents(); refreshCounter = 0; }
                try {
                    if (pUI != null && refreshCounter == 0) { pUI.uiLblMsg.Text = string.Format("Dosya: [{0}]...", filePath); if (pUI != null) { pUI.uiProgressBar1.Value++; } }
                    var file = filePath.asFileInfo(); if (!file.Exists) { continue; } var fileSize = file.Length; if (fileSize > maxSizeBytes) { continue; }
                    var data = File.ReadAllText(filePath, Encoding.Default);
                    if (data.ToLower().Contains(searchTextLower)) {
                        string fileDir = filePath.Substring(0, filePath.Length - Path.GetFileName(filePath).Length);
                        var item = new ListViewItem(); item.Tag = filePath; item.Text = Path.GetFileName(filePath); item.SubItems.Add((fileSize / 1024).ToString() + " KB");
                        item.SubItems.Add(File.GetLastWriteTime(filePath).ToString()); item.SubItems.Add(fileDir);
                        uiFindFilesList.Groups.Add(fileDir, fileDir); item.Group = uiFindFilesList.Groups[fileDir]; uiFindFilesList.Items.Add(item);
                        if (replaceFlag) { data = data.Replace(searchText, replaceText); File.WriteAllText(filePath, data, Encoding.Default); }
                    }
                }
                catch (SystemException ex) { }
            }
            uiFindFilesList.ResumeLayout(false); uiFindFilesList.Visible = true; ProgressUI.hide();
            var totalFilesAdded = uiFindFilesList.Items.Count;
            if (totalFilesAdded == 0) { uiBtnFindInResults.Enabled = false; "Arama kriterlerine uygun hiç dosya BULUNAMADI! :(".errorMsgE(); }
            else {
                uiBtnFindInResults.Enabled = uiSearchText.Text != "";
                string.Format("{0} dosyadan arama kriterlerine uygun {1} dosya bulundu :)", files.Length.ToString(), totalFilesAdded).normalMsgE();
            }
        }
        private void dizinListesiAc() {
            var dlgUI = new FolderBrowserDialog() { ShowNewFolderButton = true, Description = "Aramanýn yapýlacaðý dizini seçiniz", SelectedPath = uiSearchDirectory.Text };
            if (dlgUI.ShowDialog(this) == DialogResult.OK) { uiSearchDirectory.Text = dlgUI.SelectedPath; }
        }

		private void uTxt_Enter(object sender, EventArgs e) { if (sender is TextBoxBase ctl) { ctl.SelectAll(); } }
	}
}
