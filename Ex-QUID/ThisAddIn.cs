using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Ex_QUID
{
    public partial class ThisAddIn
    {
        private Ribbon ribbon;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            ribbon = new Ribbon();
            return ribbon;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
    }
}
