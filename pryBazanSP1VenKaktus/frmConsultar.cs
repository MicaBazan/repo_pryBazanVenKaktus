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
            char separador = Convert.ToChar(";");

            StreamReader srCliente = new StreamReader("./Cliente.txt");

            while (!srCliente.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo
                string[] consultaCliente = srCliente.ReadLine().Split(separador);

                dgvCliente.Rows.Add(consultaCliente);
            }

            srCliente.Close();




            StreamReader srVendedor = new StreamReader("./vendedor.txt");

            while (!srVendedor.EndOfStream)
            {
                //Crea un vector para almacenar los datos del archivo
                string[] consultaVendedor = srVendedor.ReadLine().Split(separador);

                dgvVendedor.Rows.Add(consultaVendedor);
            }

            srVendedor.Close();




            StreamReader srVentas = new StreamReader("./venta.txt");

            while (!srVentas.EndOfStream)
            {
                //Crea un Vector para almacenar los datos del archivo
                string[] consultaVenta = srVentas.ReadLine().Split(separador);

                dgvVentas.Rows.Add(consultaVenta);
            }

            srVentas.Close();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
