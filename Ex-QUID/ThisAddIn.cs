using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace Ex_QUID
{
    public partial class ThisAddIn
    {
        private Ribbon ribbon;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // Crear una instancia del formulario de inicio de sesión
            DataBaseForm loginForm = new DataBaseForm();

            // Mostrar el formulario de inicio de sesión como modal
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el login es exitoso, continuar con la ejecución del Add-In
                // Aquí puedes poner lógica adicional si lo necesitas
            }
            else
            {
                // Si el login no es exitoso, cerrar Excel
                Application.Quit();
            }
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
