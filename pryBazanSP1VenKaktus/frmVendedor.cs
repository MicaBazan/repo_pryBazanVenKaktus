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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            //Crea un archivo si no existe
            StreamWriter swArVendedor = new StreamWriter("./vendedor.txt", true);
            swArVendedor.Close();

            //probar
            //if(File.Exists(".Cliente.txt")
            //{

            //}
            //else
            //{
            //    File.Create("./Cliente.txt");
            //}


            StreamReader srVendedor = new StreamReader("./vendedor.txt");

            char separador = Convert.ToChar(";");

            while (!srVendedor.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo
                string[] vendedor = srVendedor.ReadLine().Split(separador);

                //Verifica que no se repita el id
                if (txtIdentificador.Text == vendedor[0])
                {
                    bandera = true;
                }
            }

            srVendedor.Close();


            // En caso que el id no se repita escribe en el archivo
            if(bandera == false)
            {
                StreamWriter swVendedor = new StreamWriter("./vendedor.txt", true);
                swVendedor.WriteLine(txtIdentificador.Text + ";" + txtNombre.Text + ";" + txtActivo.Text + ";" + txtComision.Text);
                swVendedor.Close();

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
            txtActivo.Text = "";
            txtComision.Text = "";

            txtIdentificador.Focus();
        }


        private void txtActivo_TextChanged(object sender, EventArgs e)
        {
           
        }


        //Evento KeyPress: debe permitir ingresar solamente números (y borrar)
        private void txtIdentificador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
