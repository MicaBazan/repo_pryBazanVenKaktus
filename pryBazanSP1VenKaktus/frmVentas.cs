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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            //if(lstFactura.Text == "" & txtNumeroFac.Text == "" & lstIdCliente.Text == "" & lstIdVendedor.Text == "" & txtMonto.Text == "")
            //{
            //    MessageBox.Show("Debe completar los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
            
            //Creo una bandera
            bool bandera = false;


            //Crea un archivo si no existe
            StreamWriter swArVenta = new StreamWriter("./venta.txt", true);

            swArVenta.Close();


            //probar
            //if(File.Exists(".Cliente.txt")
            //{

            //}
            //else
            //{
            //    File.Create("./Cliente.txt");
            //}


            //Lee el archivo de texto
            StreamReader srVenta = new StreamReader("./venta.txt");


            //se crea una variable de tipo char para separar por caracter
            char separador = Convert.ToChar(";");


            //Mientras el archivo sea distinto al final
            while (!srVenta.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] venta = srVenta.ReadLine().Split(separador);


                //Verifica que no se repita el id
                //En el caso de que este repetido bandera pasa a verdadero
                if (txtNumeroFac.Text == venta[0])
                {
                    bandera = true;
                }
            }

            //Se cierra el archivo de texto
            srVenta.Close();


            // En caso que el id no se repita escribe en el archivo, sino muestra un mensaje de id repetido
            if (bandera == false)
            {

                StreamWriter swVenta = new StreamWriter("./venta.txt", true);

                DateTime fecha = dtpFecha.Value.Date;

                swVenta.WriteLine(lstFactura.Text + ";" + txtNumeroFac.Text + ";" + fecha + ";" + lstIdCliente.Text + ";" + lstIdVendedor.Text + ";" + txtMonto.Text);
                swVenta.Close();

                MessageBox.Show("Datos cargados correctamente.", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstFactura.Text = "";
                txtNumeroFac.Text = "";
                lstIdCliente.Text = "";
                lstIdVendedor.Text = "";
                txtMonto.Text = "";

                lstFactura.Focus();

            }


            else
            {
                MessageBox.Show("El numero de factura ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lstFactura.Text = "";
                txtNumeroFac.Text = "";
                lstIdCliente.Text = "";
                lstIdVendedor.Text = "";
                txtMonto.Text = "";

                lstFactura.Focus();
            }
        }


        //Evento KeyPress: debe permitir ingresar solamente números (y borrar)
        private void txtNumeroFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sin NO es un digito y NO es la tecla borrar
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sin NO es un digito y NO es la tecla borrar
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }

        private void s(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(";");

            StreamReader srIdCliente = new StreamReader("./Cliente.txt");

            while(!srIdCliente.EndOfStream)
            {
                string[] vecIdCliente = srIdCliente.ReadLine().Split(separador);

                lstIdCliente.Items.Add(vecIdCliente[0]);
            }

            srIdCliente.Close();

            StreamReader srIdVendedor = new StreamReader("./vendedor.txt");

            while(!srIdVendedor.EndOfStream)
            {
                string[] vecIdVendedor = srIdVendedor.ReadLine().Split(separador);

                lstIdVendedor.Items.Add(vecIdVendedor[0]);
            }

            srIdVendedor.Close();
        }
    }
}
