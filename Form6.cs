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
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        public string IDventa { get; set; }

            
        
            

        

        private void pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);

            

            OleDbDataAdapter da = new OleDbDataAdapter();

            string IDVenta = IDventa;

            da.SelectCommand = new OleDbCommand("SELECT Cantidad, Descripcion, Precio FROM DetalleVenta WHERE IDVenta = @IDventa", connection);
            da.SelectCommand.Parameters.AddWithValue("@IDventa", IDVenta);

            da.Fill(dt);


            pedido.DataSource = dt;

            
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@ventaID", IDVenta);
            string query = "SELECT numero, cliente, descuento, total, pago FROM Venta WHERE numero = @ventaID";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                numeroDetalle.Text = reader["numero"].ToString();
                clienteDetalle.Text = reader["cliente"].ToString();
                descuentoDetalle.Text = reader["descuento"].ToString();
                totalDetalle.Text = reader["total"].ToString();
                pagoDetalle.Text = reader["pago"].ToString();


            }
            connection.Close();
            
        }

        private void formaPago_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
