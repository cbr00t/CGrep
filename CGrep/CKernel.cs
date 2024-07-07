using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CGrep {
    static class CKernel {
        [STAThread]
        static void Main() { CGlobals.g.registerAppMain("CGrep", run); }
        static bool run(CList<string> args) { Application.Run(new CMainUI()); return true; }
    }
}
