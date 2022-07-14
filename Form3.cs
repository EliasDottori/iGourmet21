using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Seminario
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString))
            { 
                string query = "select descripcion, precio from Productos";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }

            viewProducts.DataSource = dt;
        }

        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton19_Click(object sender, EventArgs e)
        {

        }

        public void viewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }


        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void guna2GradientButton22_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);

                string query = "select MAX(numero) AS lastID from Venta";

                OleDbCommand cmd = new OleDbCommand(query, connection);

                connection.Open();

                int lastID = Convert.ToInt32(cmd.ExecuteScalar());

                connection.Close();

                OleDbCommand command = new OleDbCommand("", connection);

                for (int s = 0; s <= pedido.Rows.Count - 1; s++)
                {
                    command.Parameters.AddWithValue("@numero", lastID + 1);
                    command.Parameters.AddWithValue("@cantidad", pedido.Rows[s].Cells[0].Value);
                    command.Parameters.AddWithValue("@descripcion", pedido.Rows[s].Cells[1].Value);
                    command.Parameters.AddWithValue("@precio", pedido.Rows[s].Cells[2].Value);

                    command.CommandText = "INSERT INTO DetalleVenta (IDVenta, Cantidad, Descripcion, Precio) VALUES (@numero, @cantidad, @descripcion, @precio)";

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Parameters.Clear();

                }

                Cobro v1 = new Cobro(TotalTxt.Text);
                v1.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error   " + ex.Message);
            }


        }

        public void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void viewProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pedido.Rows.Add(new string[]
            {
                Convert.ToString (1),
                Convert.ToString(viewProducts[0, viewProducts.CurrentRow.Index].Value),
                Convert.ToString(viewProducts[1, viewProducts.CurrentRow.Index].Value)
            });

            int suma = 0;


            foreach (DataGridViewRow row in pedido.Rows)

            {

                suma += Convert.ToInt32(row.Cells[2].Value);

            }

            TotalTxt.Text = Convert.ToString(suma);

        }
    }
        
    
}
