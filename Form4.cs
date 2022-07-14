using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace Seminario
{
    public partial class CargarProducto : Form
    {
        public CargarProducto()
        {
            InitializeComponent();
        }

        private void AceptarCargarProducto_Click(object sender, EventArgs e)
        {

           
                OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
                OleDbCommand command = new OleDbCommand("", connection);
                
                
                    command.Parameters.AddWithValue("@codigo", TextCodigo.Text);
                    command.Parameters.AddWithValue("@descripcion", TextDescripcion.Text);
                    command.Parameters.AddWithValue("@costo", TextCosto.Text);
                    command.Parameters.AddWithValue("@precio", TextPrecio.Text);

                    command.CommandText = "INSERT INTO Productos (codigo, descripcion, costo, precio) VALUES (@codigo, @descripcion, @costo, @precio)";

                    connection.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto creado con Exito");

                    TextCodigo.Clear();
                    TextDescripcion.Clear();
                    TextCosto.Clear();
                    TextPrecio.Clear();
                    TextCodigo.Focus();
                    connection.Close();
                    command.Parameters.Clear();
                
            }
    }
}
