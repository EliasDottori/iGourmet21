using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;


namespace Seminario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            string scon=ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(scon);
            con.Open();
        }


        //======================================== LOGIN ============================================//

        private void Registrar(string user, string pass)
        {

            OleDbConnection Consulta = new OleDbConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
            if (textUser.Text == "" || textPass.Text == "")
            {
                MessageBox.Show("Todos los campos deben de estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUser.Focus();
            }
            else
            {
                string constring = (ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
                string cmdText = "select Count(*) from Usuarios where usuario=? and clave=?";
                using (OleDbConnection con = new OleDbConnection(constring))
                using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@p1", user);
                    cmd.Parameters.AddWithValue("@p2", pass);
                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Bienvenido " + textUser.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        iGourmet v1 = new iGourmet();
                        v1.Show();

                    }

                    else
                    {
                        MessageBox.Show("Error por favor verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textPass.Clear();
                        textUser.Clear();
                        textUser.Focus();
                        Consulta.Close();
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void textUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonAcept_Click_1(object sender, EventArgs e)
        {

            {
                Registrar(textUser.Text, textPass.Text);
            }


        }
    }
}
