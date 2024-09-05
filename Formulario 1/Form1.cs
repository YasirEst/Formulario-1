using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string numTel = txtTelefono.Text;
            string estatura = txtEstatura.Text;
            string edad = txtEdad.Text;


            // Género seleccionado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            // Cadena de datos
            string datos = $"Nombres: {nombres}\r\n Apellidos: {apellidos}\r\n Teléfono: {numTel}\r\n Estatura: {estatura}\r\n Edad: {edad}\r\n Género: {genero}\r\n";

            //datos de un archivo
            string rutaArchivo = "C:\\Users\\ryasi\\OneDrive\\Escritorio\\formulario\\datos.txt";

            //verificar si el archivo ya existe
            bool archivoexiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                // No se necesita una verificación adicional, simplemente escribe los datos
                writer.WriteLine(datos);
                writer.WriteLine(); // Añade una línea en blanco después de los datos
            }

            MessageBox.Show("Datos guardados exitosamente.");
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {

            // Limpiar campos de texto y radio buttons
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;

        }
    }
}
