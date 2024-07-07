using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGrep {
    public class CSablon {
        protected string text;
        public string Mask { get; set; } public string SearchDir { get; set; }
        public string Text {
            get { if (text == null) { return string.Format("{0} {1}", (Mask ?? "").ayarla(15), (SearchDir ?? "")); } return text; }
            set { text = value; }
        }

        public CSablon(string mask, string searchDir, string text) : this(mask, searchDir) { this.Text = text; }
        public CSablon(string mask, string searchDir) : this() { this.Mask = mask; this.SearchDir = searchDir; }
        public CSablon() { }
        public override string ToString() => this.Text;
    }
}
