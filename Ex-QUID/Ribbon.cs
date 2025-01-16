using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office = Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace Ex_QUID
{
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility
    {
        public string GetCustomUI(string ribbonID)
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\"?><customUI xmlns=\"http://schemas.microsoft.com/office/2009/07/customui\"><ribbon><tabs><tab id=\"customTab\" label=\"Ex-QUID\"><group id=\"connectionGroup\" label=\"Connection\"><button id=\"button1\" label=\"Botón 1\" size=\"large\" onAction=\"OnButtonClick\" /></group><group id=\"group2\" label=\"Grupo 2\"><button id=\"button2\" label=\"Botón 2\" size=\"large\" onAction=\"OnButtonClick\" /></group><group id=\"group3\" label=\"Grupo 3\"><button id=\"button3\" label=\"Botón 3\" size=\"large\" onAction=\"OnButtonClick\" /></group><group id=\"group4\" label=\"Grupo 4\"><button id=\"button4\" label=\"Botón 4\" size=\"large\" onAction=\"OnButtonClick\" /></group><group id=\"group5\" label=\"Grupo 5\"><button id=\"button5\" label=\"Botón 5\" size=\"large\" onAction=\"OnButtonClick\" /></group></tab></tabs></ribbon></customUI>";
        }

        #region Connection types (SQL Server and MySQL)
        public SqlConnection ConnectToSqlServer()
        {
            string connectionString = "Server=localhost;Database=YourDatabaseName;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                return null;
            }
        }

        public MySqlConnection ConnectToMySql()
        {
            string connectionString = "Server=localhost;Database=YourDatabaseName;Uid=YourUsername;Pwd=YourPassword;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                return null;
            }
        }
        #endregion

    }
}
