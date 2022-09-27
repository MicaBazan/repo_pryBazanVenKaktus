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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            //se crea una variable de tipo char para separar por caracter
            char separador = Convert.ToChar(";");


            //Carga los datos del archivo al DataGridView


            //Lee el archivo cliente.txt
            StreamReader srCliente = new StreamReader("./Cliente.txt");

            //Mientras el archivo sea distinto al final
            while (!srCliente.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] consultaCliente = srCliente.ReadLine().Split(separador);


                //Carga los datos del vector en DataGridView
                dgvCliente.Rows.Add(consultaCliente);
            }

            //se cierra el archivo de texto
            srCliente.Close();




            
            //Carga los datos del archivo al DataGridView
            StreamReader srVendedor = new StreamReader("./vendedor.txt");

            //Mientras el archivo sea distinto al final
            while (!srVendedor.EndOfStream)
            {
                //Crea un vector para almacenar los datos del archivo, y los separa con el split (divide una cadena)
                string[] consultaVendedor = srVendedor.ReadLine().Split(separador);

                //Carga los datos del vector en DataGridView
                dgvVendedor.Rows.Add(consultaVendedor);
            }






            //Se cierra el archivo de texto
            srVendedor.Close();

            //Lee el archivo cliente.txt
            StreamReader srVentas = new StreamReader("./venta.txt");

            //Mientras el archivo sea distinto al final
            while (!srVentas.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo, y los separa con el Split (Divide una cadena)
                string[] consultaVenta = srVentas.ReadLine().Split(separador);


                //Carga los datos del vector en DataGridView
                dgvVentas.Rows.Add(consultaVenta);
            }

            //se cierra el archivo de texto
            srVentas.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
