using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_QUID
{
    public partial class DataBaseForm : Form
    {
        // Constructor
        public DataBaseForm()
        {
            InitializeComponent();

            this.Text = "Database Access";

            ConfigureForm();
            AddFormFields();
        }

        private void ConfigureForm()
        {
            // Establecer el tamaño del formulario
            this.Size = new System.Drawing.Size(400, 300); // Ancho = 400, Alto = 300

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Método para agregar los TextBox y Labels al formulario
        private void AddFormFields()
        {
            // Crear los Label y TextBox para los 4 campos
            for (int i = 1; i <= 4; i++)
            {
                // Crear un Label para cada campo
                Label label = new Label();
                label.Text = $"Campo {i}:";
                label.Location = new Point(50, 30 * i); // Posición en el formulario
                label.AutoSize = true;

                // Crear un TextBox para cada campo
                TextBox textBox = new TextBox();
                textBox.Name = $"txtCampo{i}";
                textBox.Size = new Size(200, 20);
                textBox.Location = new Point(120, 30 * i); // Posición en el formulario

                // Agregar los controles al formulario
                this.Controls.Add(label);
                this.Controls.Add(textBox);
            }

            // Crear un botón para agregar los datos
            Button btnAgregar = new Button();
            btnAgregar.Text = "Agregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.Location = new Point(120, 160); // Ubicación del botón debajo de los TextBox

            // Agregar evento al botón para manejar el click
            btnAgregar.Click += new EventHandler(BtnAgregar_Click);

            // Agregar el botón al formulario
            this.Controls.Add(btnAgregar);
        }

        // Evento al hacer clic en el botón "Agregar"
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox
            string campo1 = this.Controls["txtCampo1"].Text;
            string campo2 = this.Controls["txtCampo2"].Text;
            string campo3 = this.Controls["txtCampo3"].Text;
            string campo4 = this.Controls["txtCampo4"].Text;

            // Lógica para guardar estos valores en la base de datos
            // Aquí debes agregar tu código de conexión e inserción de datos
            MessageBox.Show($"Datos a insertar: {campo1}, {campo2}, {campo3}, {campo4}");
        }
    }
}
