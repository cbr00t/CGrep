namespace CGrep
{
    partial class CMainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( CMainUI ) );
            this.label1 = new System.Windows.Forms.Label();
            this.uiSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiReplaceText = new System.Windows.Forms.TextBox();
            this.uiSearchAndReplace = new System.Windows.Forms.CheckBox();
            this.uiFindBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiDDSablon = new System.Windows.Forms.ComboBox();
            this.btnSearchDirList = new System.Windows.Forms.Button();
            this.uiMaxFileSize = new System.Windows.Forms.TextBox();
            this.uiPattern = new System.Windows.Forms.TextBox();
            this.uiIncludeSubDirectories = new System.Windows.Forms.CheckBox();
            this.uiSearchDirectory = new System.Windows.Forms.TextBox();
            this.uiBtnFindInResults = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiFindFilesList = new System.Windows.Forms.ListView();
            this.filename = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.filesize = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.filemodifydate = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.filedir = ( (System.Windows.Forms.ColumnHeader)( new System.Windows.Forms.ColumnHeader() ) );
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiExitBtn = new System.Windows.Forms.Button();
            this.uiDeleteFileBtn = new System.Windows.Forms.Button();
            this.uiClearBtn = new System.Windows.Forms.Button();
            this.uiOpenDirectoryBtn = new System.Windows.Forms.Button();
            this.uiOpenBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point( 4, 12 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 36, 16 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Ara:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSearchText
            // 
            this.uiSearchText.BackColor = System.Drawing.Color.AliceBlue;
            this.uiSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiSearchText.Location = new System.Drawing.Point( 4, 27 );
            this.uiSearchText.Multiline = true;
            this.uiSearchText.Name = "uiSearchText";
            this.uiSearchText.Size = new System.Drawing.Size( 354, 69 );
            this.uiSearchText.TabIndex = 1;
            this.uiSearchText.TextChanged += new System.EventHandler( this.uiSearchText_TextChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point( 4, 102 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 63, 16 );
            this.label2.TabIndex = 2;
            this.label2.Text = "Deðiþtir:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiReplaceText
            // 
            this.uiReplaceText.BackColor = System.Drawing.Color.AliceBlue;
            this.uiReplaceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiReplaceText.Enabled = false;
            this.uiReplaceText.Location = new System.Drawing.Point( 4, 117 );
            this.uiReplaceText.Multiline = true;
            this.uiReplaceText.Name = "uiReplaceText";
            this.uiReplaceText.Size = new System.Drawing.Size( 354, 66 );
            this.uiReplaceText.TabIndex = 3;
            // 
            // uiSearchAndReplace
            // 
            this.uiSearchAndReplace.AutoSize = true;
            this.uiSearchAndReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiSearchAndReplace.ForeColor = System.Drawing.Color.OrangeRed;
            this.uiSearchAndReplace.Location = new System.Drawing.Point( 236, 5 );
            this.uiSearchAndReplace.Name = "uiSearchAndReplace";
            this.uiSearchAndReplace.Size = new System.Drawing.Size( 119, 20 );
            this.uiSearchAndReplace.TabIndex = 14;
            this.uiSearchAndReplace.Text = "B&ul ve Deðiþtir";
            this.uiSearchAndReplace.UseVisualStyleBackColor = true;
            this.uiSearchAndReplace.CheckedChanged += new System.EventHandler( this.uiSearchAndReplace_CheckedChanged );
            // 
            // uiFindBtn
            // 
            this.uiFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiFindBtn.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.uiFindBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiFindBtn.Location = new System.Drawing.Point( 359, 3 );
            this.uiFindBtn.Name = "uiFindBtn";
            this.uiFindBtn.Size = new System.Drawing.Size( 67, 138 );
            this.uiFindBtn.TabIndex = 15;
            this.uiFindBtn.Text = "&Bul";
            this.uiFindBtn.UseVisualStyleBackColor = true;
            this.uiFindBtn.Click += new System.EventHandler( this.uiFindBtn_Click );
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add( this.uiDDSablon );
            this.panel1.Controls.Add( this.btnSearchDirList );
            this.panel1.Controls.Add( this.uiMaxFileSize );
            this.panel1.Controls.Add( this.uiPattern );
            this.panel1.Controls.Add( this.uiIncludeSubDirectories );
            this.panel1.Controls.Add( this.uiSearchDirectory );
            this.panel1.Controls.Add( this.uiBtnFindInResults );
            this.panel1.Controls.Add( this.uiFindBtn );
            this.panel1.Controls.Add( this.uiSearchAndReplace );
            this.panel1.Controls.Add( this.uiReplaceText );
            this.panel1.Controls.Add( this.label2 );
            this.panel1.Controls.Add( this.uiSearchText );
            this.panel1.Controls.Add( this.label7 );
            this.panel1.Controls.Add( this.label6 );
            this.panel1.Controls.Add( this.label8 );
            this.panel1.Controls.Add( this.label5 );
            this.panel1.Controls.Add( this.label4 );
            this.panel1.Controls.Add( this.label3 );
            this.panel1.Controls.Add( this.label1 );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point( 5, 5 );
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding( 1 );
            this.panel1.Size = new System.Drawing.Size( 427, 369 );
            this.panel1.TabIndex = 0;
            // 
            // uiDDSablon
            // 
            this.uiDDSablon.DropDownHeight = 390;
            this.uiDDSablon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiDDSablon.Font = new System.Drawing.Font( "Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.uiDDSablon.FormattingEnabled = true;
            this.uiDDSablon.IntegralHeight = false;
            this.uiDDSablon.ItemHeight = 14;
            this.uiDDSablon.Location = new System.Drawing.Point( 20, 314 );
            this.uiDDSablon.Name = "uiDDSablon";
            this.uiDDSablon.Size = new System.Drawing.Size( 403, 22 );
            this.uiDDSablon.TabIndex = 17;
            this.uiDDSablon.SelectedIndexChanged += new System.EventHandler( this.uiDDSablon_SelectedIndexChanged );
            // 
            // btnSearchDirList
            // 
            this.btnSearchDirList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDirList.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.btnSearchDirList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchDirList.Location = new System.Drawing.Point( 359, 248 );
            this.btnSearchDirList.Name = "btnSearchDirList";
            this.btnSearchDirList.Size = new System.Drawing.Size( 67, 29 );
            this.btnSearchDirList.TabIndex = 12;
            this.btnSearchDirList.Text = "...";
            this.btnSearchDirList.UseVisualStyleBackColor = true;
            this.btnSearchDirList.Click += new System.EventHandler( this.btnSearchDirList_Click );
            // 
            // uiMaxFileSize
            // 
            this.uiMaxFileSize.AutoCompleteCustomSource.AddRange( new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "7",
            "8",
            "10",
            "12",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "25",
            "28",
            "30",
            "35",
            "40",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "70",
            "100",
            "120",
            "150",
            "170",
            "200",
            "300",
            "400",
            "500"} );
            this.uiMaxFileSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uiMaxFileSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.uiMaxFileSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiMaxFileSize.Location = new System.Drawing.Point( 65, 198 );
            this.uiMaxFileSize.Name = "uiMaxFileSize";
            this.uiMaxFileSize.Size = new System.Drawing.Size( 51, 23 );
            this.uiMaxFileSize.TabIndex = 5;
            this.uiMaxFileSize.Text = "5";
            this.uiMaxFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uiMaxFileSize.TextChanged += new System.EventHandler( this.uiMaxFileSize_TextChanged );
            // 
            // uiPattern
            // 
            this.uiPattern.AutoCompleteCustomSource.AddRange( new string[] {
            "*.*",
            "*.",
            "*.ai2",
            "*.bat",
            "*.bck",
            "*.bin",
            "*.cfg",
            "*.config",
            "*.cmd",
            "*.class",
            "*.cs",
            "*.csproj",
            "*.dat",
            "*.nfo",
            "*.icx",
            "*.ini",
            "*TanRap*",
            "*TanRap*.ini",
            "*EkSaha*.ini",
            "*.txt",
            "*.qry",
            "db*.qry",
            "*.sln",
            "*.son",
            "*.sql",
            "*.vb",
            "*.vbproj"} );
            this.uiPattern.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uiPattern.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.uiPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiPattern.Location = new System.Drawing.Point( 65, 225 );
            this.uiPattern.Name = "uiPattern";
            this.uiPattern.Size = new System.Drawing.Size( 161, 23 );
            this.uiPattern.TabIndex = 9;
            this.uiPattern.Text = "*.*";
            // 
            // uiIncludeSubDirectories
            // 
            this.uiIncludeSubDirectories.AutoSize = true;
            this.uiIncludeSubDirectories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiIncludeSubDirectories.ForeColor = System.Drawing.Color.Blue;
            this.uiIncludeSubDirectories.Location = new System.Drawing.Point( 209, 279 );
            this.uiIncludeSubDirectories.Name = "uiIncludeSubDirectories";
            this.uiIncludeSubDirectories.Size = new System.Drawing.Size( 151, 20 );
            this.uiIncludeSubDirectories.TabIndex = 13;
            this.uiIncludeSubDirectories.Text = "&Alt dizinleri de içer.";
            this.uiIncludeSubDirectories.UseVisualStyleBackColor = true;
            this.uiIncludeSubDirectories.CheckedChanged += new System.EventHandler( this.uiSearchAndReplace_CheckedChanged );
            // 
            // uiSearchDirectory
            // 
            this.uiSearchDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uiSearchDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.uiSearchDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiSearchDirectory.Location = new System.Drawing.Point( 65, 251 );
            this.uiSearchDirectory.Name = "uiSearchDirectory";
            this.uiSearchDirectory.Size = new System.Drawing.Size( 293, 23 );
            this.uiSearchDirectory.TabIndex = 11;
            this.uiSearchDirectory.Text = "C:\\";
            this.uiSearchDirectory.TextChanged += new System.EventHandler( this.uiSearchDirectory_TextChanged );
            // 
            // uiBtnFindInResults
            // 
            this.uiBtnFindInResults.Enabled = false;
            this.uiBtnFindInResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnFindInResults.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.uiBtnFindInResults.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiBtnFindInResults.Location = new System.Drawing.Point( 359, 141 );
            this.uiBtnFindInResults.Name = "uiBtnFindInResults";
            this.uiBtnFindInResults.Size = new System.Drawing.Size( 67, 101 );
            this.uiBtnFindInResults.TabIndex = 16;
            this.uiBtnFindInResults.Text = "&Sonuçlar\r\nÝçinde Bul";
            this.uiBtnFindInResults.UseVisualStyleBackColor = true;
            this.uiBtnFindInResults.Click += new System.EventHandler( this.uiBtnFindInResults_Click );
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 64 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ) );
            this.label7.Location = new System.Drawing.Point( 144, 202 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 215, 16 );
            this.label7.TabIndex = 7;
            this.label7.Text = "dan fazla olan dosyalarý okuma.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 64 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ) );
            this.label6.Location = new System.Drawing.Point( 123, 202 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 27, 16 );
            this.label6.TabIndex = 6;
            this.label6.Text = "MB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 64 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ) );
            this.label8.Location = new System.Drawing.Point( 4, 294 );
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size( 52, 16 );
            this.label8.TabIndex = 4;
            this.label8.Text = "Þablon";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point( 4, 202 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 54, 16 );
            this.label5.TabIndex = 4;
            this.label5.Text = "Boyutu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point( 4, 228 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 49, 16 );
            this.label4.TabIndex = 8;
            this.label4.Text = "Maske";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point( 4, 254 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 38, 16 );
            this.label3.TabIndex = 10;
            this.label3.Text = "Dizin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add( this.uiFindFilesList );
            this.panel2.Controls.Add( this.panel3 );
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point( 432, 5 );
            this.panel2.Margin = new System.Windows.Forms.Padding( 0 );
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding( 1 );
            this.panel2.Size = new System.Drawing.Size( 661, 369 );
            this.panel2.TabIndex = 1;
            // 
            // uiFindFilesList
            // 
            this.uiFindFilesList.AllowColumnReorder = true;
            this.uiFindFilesList.BackColor = System.Drawing.Color.AliceBlue;
            this.uiFindFilesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiFindFilesList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.filesize,
            this.filemodifydate,
            this.filedir} );
            this.uiFindFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFindFilesList.Font = new System.Drawing.Font( "Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.uiFindFilesList.FullRowSelect = true;
            this.uiFindFilesList.HoverSelection = true;
            this.uiFindFilesList.Location = new System.Drawing.Point( 1, 1 );
            this.uiFindFilesList.Margin = new System.Windows.Forms.Padding( 0 );
            this.uiFindFilesList.Name = "uiFindFilesList";
            this.uiFindFilesList.ShowItemToolTips = true;
            this.uiFindFilesList.Size = new System.Drawing.Size( 659, 327 );
            this.uiFindFilesList.TabIndex = 0;
            this.uiFindFilesList.UseCompatibleStateImageBehavior = false;
            this.uiFindFilesList.View = System.Windows.Forms.View.Details;
            this.uiFindFilesList.DoubleClick += new System.EventHandler( this.uiFindFilesList_DoubleClick );
            // 
            // filename
            // 
            this.filename.Text = "Dosya Adý";
            this.filename.Width = 190;
            // 
            // filesize
            // 
            this.filesize.Text = "Boyut";
            this.filesize.Width = 115;
            // 
            // filemodifydate
            // 
            this.filemodifydate.Text = "Deðiþtirme Tarihi";
            this.filemodifydate.Width = 170;
            // 
            // filedir
            // 
            this.filedir.Text = "Dizin";
            this.filedir.Width = 280;
            // 
            // panel3
            // 
            this.panel3.Controls.Add( this.uiExitBtn );
            this.panel3.Controls.Add( this.uiDeleteFileBtn );
            this.panel3.Controls.Add( this.uiClearBtn );
            this.panel3.Controls.Add( this.uiOpenDirectoryBtn );
            this.panel3.Controls.Add( this.uiOpenBtn );
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point( 1, 328 );
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size( 659, 40 );
            this.panel3.TabIndex = 0;
            // 
            // uiExitBtn
            // 
            this.uiExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiExitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiExitBtn.Location = new System.Drawing.Point( 557, 1 );
            this.uiExitBtn.Name = "uiExitBtn";
            this.uiExitBtn.Size = new System.Drawing.Size( 98, 39 );
            this.uiExitBtn.TabIndex = 4;
            this.uiExitBtn.Text = "Çý&kýþ";
            this.uiExitBtn.UseVisualStyleBackColor = true;
            this.uiExitBtn.Click += new System.EventHandler( this.uiExitBtn_Click );
            // 
            // uiDeleteFileBtn
            // 
            this.uiDeleteFileBtn.Enabled = false;
            this.uiDeleteFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDeleteFileBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.uiDeleteFileBtn.Location = new System.Drawing.Point( 451, 1 );
            this.uiDeleteFileBtn.Name = "uiDeleteFileBtn";
            this.uiDeleteFileBtn.Size = new System.Drawing.Size( 107, 39 );
            this.uiDeleteFileBtn.TabIndex = 3;
            this.uiDeleteFileBtn.Text = "Dosyayý &Sil";
            this.uiDeleteFileBtn.UseVisualStyleBackColor = true;
            this.uiDeleteFileBtn.Click += new System.EventHandler( this.uiDeleteFileBtn_Click );
            // 
            // uiClearBtn
            // 
            this.uiClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiClearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiClearBtn.Location = new System.Drawing.Point( 331, 1 );
            this.uiClearBtn.Name = "uiClearBtn";
            this.uiClearBtn.Size = new System.Drawing.Size( 121, 39 );
            this.uiClearBtn.TabIndex = 2;
            this.uiClearBtn.Text = "Listeyi &Temizle";
            this.uiClearBtn.UseVisualStyleBackColor = true;
            this.uiClearBtn.Click += new System.EventHandler( this.uiClearBtn_Click );
            // 
            // uiOpenDirectoryBtn
            // 
            this.uiOpenDirectoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOpenDirectoryBtn.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.uiOpenDirectoryBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiOpenDirectoryBtn.Location = new System.Drawing.Point( 204, 0 );
            this.uiOpenDirectoryBtn.Name = "uiOpenDirectoryBtn";
            this.uiOpenDirectoryBtn.Size = new System.Drawing.Size( 128, 40 );
            this.uiOpenDirectoryBtn.TabIndex = 1;
            this.uiOpenDirectoryBtn.Text = "Ýç&eren Klasörü Aç";
            this.uiOpenDirectoryBtn.UseVisualStyleBackColor = true;
            this.uiOpenDirectoryBtn.Click += new System.EventHandler( this.uiOpenDirectoryBtn_Click );
            // 
            // uiOpenBtn
            // 
            this.uiOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOpenBtn.Font = new System.Drawing.Font( "Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 162 ) ) );
            this.uiOpenBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiOpenBtn.Location = new System.Drawing.Point( 3, 0 );
            this.uiOpenBtn.Name = "uiOpenBtn";
            this.uiOpenBtn.Size = new System.Drawing.Size( 201, 40 );
            this.uiOpenBtn.TabIndex = 0;
            this.uiOpenBtn.Text = "&Aç";
            this.uiOpenBtn.UseVisualStyleBackColor = true;
            this.uiOpenBtn.Click += new System.EventHandler( this.uiOpenBtn_Click );
            // 
            // CMainUI
            // 
            this.ClientSize = new System.Drawing.Size( 1098, 379 );
            this.Controls.Add( this.panel2 );
            this.Controls.Add( this.panel1 );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "CMainUI";
            this.Text = "CGrep";
            this.Load += new System.EventHandler( this.onLoad );
            this.panel1.ResumeLayout( false );
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout( false );
            this.panel3.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiReplaceText;
        private System.Windows.Forms.CheckBox uiSearchAndReplace;
        private System.Windows.Forms.Button uiFindBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView uiFindFilesList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button uiExitBtn;
        private System.Windows.Forms.Button uiDeleteFileBtn;
        private System.Windows.Forms.Button uiClearBtn;
        private System.Windows.Forms.Button uiOpenBtn;
        private System.Windows.Forms.Button btnSearchDirList;
        private System.Windows.Forms.TextBox uiSearchDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox uiIncludeSubDirectories;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader filedir;
        private System.Windows.Forms.ColumnHeader filesize;
        private System.Windows.Forms.ColumnHeader filemodifydate;
        private System.Windows.Forms.TextBox uiPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uiOpenDirectoryBtn;
        private System.Windows.Forms.TextBox uiMaxFileSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uiBtnFindInResults;
        private System.Windows.Forms.ComboBox uiDDSablon;
        private System.Windows.Forms.Label label8;

    }
}
