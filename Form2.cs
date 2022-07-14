using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Seminario
{
    public partial class iGourmet : Form
    {
        public iGourmet()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            Form3 v1 = new Form3();
            v1.Show();
        }

        private void guna2GradientButton18_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton19_Click(object sender, EventArgs e)
        {
            Form3 v1 = new Form3();
            v1.Show();
        }

        private void fACTURACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uTILIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void viewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton20_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
            {

                string query = "select codigo, descripcion, costo, precio, stock from Productos";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }

            viewProducts2.DataSource = dt;
        }

        private void guna2GradientButton18_Click_1(object sender, EventArgs e)
        {
            CargarProducto v1 = new CargarProducto();
            v1.Show();
        }

        private void guna2GradientButton29_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
            OleDbDataAdapter da = new OleDbDataAdapter();

            DateTime desde = pickerDesde.Value;
            DateTime hasta = pickerHasta.Value;
            da.SelectCommand = new OleDbCommand("SELECT numero, fecha,  cliente, total, descuento, pago FROM Venta WHERE fecha BETWEEN @desde AND @hasta", connection);
            da.SelectCommand.Parameters.AddWithValue("@desde", desde);
            da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);

            da.Fill(dt);


            viewVentas.DataSource = dt;


        }

        private void guna2GradientButton21_Click(object sender, EventArgs e)
        {
            Form3 v1 = new Form3();
            v1.Show();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            Form3 v1 = new Form3();
            v1.Show();
        }

        private void guna2GradientButton34_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton35_Click(object sender, EventArgs e)
        {

        }

        public void guna2GradientButton25_Click(object sender, EventArgs e)
        {


            string numero = viewVentas.CurrentRow.Cells[0].Value.ToString();

            Detalle v1 = new Detalle();
            v1.IDventa = numero;
            v1.Show();

        }

        private void viewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewVentas_CellSelected(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
