using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Seminario
{
    public partial class Cobro : Form
    {
        public Cobro(string text)
        {
            InitializeComponent();

            TotalFinal.Text = text;
        }

        public void Cobro_Load(object sender, EventArgs e)
        {

            
        }

        public class ID
        {
            public static int lastID;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void descuento_TextChanged(object sender, EventArgs e)
        {
            int total;

            total = int.Parse(TotalFinal.Text) - int.Parse(descuento.Text);

            TotalFinal.Text = Convert.ToString(total);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string rbdtext = "";

            if (Efectivo.Checked)
            {
                rbdtext = Efectivo.Text;
            }
            else if (Debito.Checked)
            {
                rbdtext = Debito.Text;
            }
            else if (Credito.Checked)
            {
                rbdtext = Credito.Text;
            }
            else if (Cuenta.Checked)
            {
                rbdtext = Cuenta.Text;
            }
            else if (MercadoPago.Checked)
            {
                rbdtext = MercadoPago.Text;
            }
            else if (Otro.Checked)
            {
                rbdtext = Otro.Text;
            }


            OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);

            string query = "select MAX(numero) AS lastID from Venta";

            OleDbCommand cmd = new OleDbCommand(query, connection);

            connection.Open();

            int lastID = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            OleDbCommand command = new OleDbCommand("", connection);

            

            command.Parameters.AddWithValue("@numero", lastID + 1);
            command.Parameters.AddWithValue("@total", TotalFinal.Text);
            command.Parameters.AddWithValue("@descuento", descuento.Text);
            command.Parameters.AddWithValue("@cliente", clienteVenta.Text);
            command.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            command.Parameters.AddWithValue("@pago", rbdtext);

            command.CommandText = "INSERT INTO Venta (numero, total, descuento, cliente, fecha, pago) VALUES (@numero, @total, @descuento, @cliente, @fecha, @pago)";

            connection.Open();

            command.ExecuteNonQuery();
            MessageBox.Show("Venta exitosa");
            connection.Close();
            command.Parameters.Clear();
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
