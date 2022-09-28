using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanSP1Ventas
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool bandera = false;


            //Crea un archivo si no existe
            StreamWriter swArCliente = new StreamWriter("./Cliente.txt", true);
            swArCliente.Close();

            //if(File.Exists(".Cliente.txt"))
            //{

            //}
            //else
            //{
            //    File.Create("./Cliente.txt");
            //}


            StreamReader srCliente = new StreamReader("./Cliente.txt");


            char separador = Convert.ToChar(";");


            while (!srCliente.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] cliente = srCliente.ReadLine().Split(separador);

                //Verifica que el id no se repita
                if (txtIdentificador.Text == cliente[0])
                {
                    bandera = true;
                }
            }

            srCliente.Close();


            // En caso que el id no se repita escribe en el archivo
            if (bandera == false)
            {
                StreamWriter swCliente = new StreamWriter("./Cliente.txt", true);
                swCliente.WriteLine(txtIdentificador.Text + ";" + txtNombre.Text);
                swCliente.Close();

                MessageBox.Show("Datos cargados correctamente.", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }

            else
            {
                MessageBox.Show("El numero de identificador ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimpiarControles();
            }
        }

        private void LimpiarControles()
        {
            txtIdentificador.Text = "";
            txtNombre.Text = "";

            txtIdentificador.Focus();
        }

        //Evento KeyPress: debe permitir ingresar solamente números (y borrar)
        private void txtIdentificador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }
    }
}
