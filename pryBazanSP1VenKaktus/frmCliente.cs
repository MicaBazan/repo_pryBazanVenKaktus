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

            //creo una bandera
            bool bandera = false;


            //Crea un archivo si no existe
            StreamWriter swArCliente = new StreamWriter("./Cliente.txt", true);
            swArCliente.Close();

            //probar
            //if(File.Exists(".Cliente.txt"))
            //{

            //}
            //else
            //{
            //    File.Create("./Cliente.txt");
            //}


            //Lee el archivo de texto
            StreamReader srCliente = new StreamReader("./Cliente.txt");


            //se crea una variable de tipo char para separar por caracter
            char separador = Convert.ToChar(";");


            //Mientras el archivo sea distinto al final
            while (!srCliente.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] cliente = srCliente.ReadLine().Split(separador);


                //Verifica que no se repita el id
                //En el caso de que este repetido bandera pasa a verdadero
                if (txtIdentificador.Text == cliente[0])
                {
                    bandera = true;
                }
            }

            //Se cierra el archivo de texto
            srCliente.Close();


            // En caso que el id no se repita escribe en el archivo, sino muestra un mensaje de id repetido
            if (bandera == false)
            {
                StreamWriter swCliente = new StreamWriter("./Cliente.txt", true);
                swCliente.WriteLine(txtIdentificador.Text + ";" + txtNombre.Text);
                swCliente.Close();

                MessageBox.Show("Datos cargados correctamente.", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtIdentificador.Text = "";
                txtNombre.Text = "";

                txtIdentificador.Focus();
            }

            else
            {
                MessageBox.Show("El numero de identificador ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtIdentificador.Text = "";
                txtNombre.Text = "";

                txtIdentificador.Focus();
            }
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
