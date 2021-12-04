using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AGI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void _1_StartForm_Register_Load(object sender, EventArgs e)
        {

        }
        private void _1_StartForm_Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }

        //

        private void button_register_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Users VALUES (@login, @password, N'Заказчик', '')", connection);
                command.Parameters.AddWithValue("@login", textBox_login.Text);
                command.Parameters.AddWithValue("@password", textBox_password.Text);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("gotovo");
                }                    
                catch
                {
                    MessageBox.Show("логин и пароль уже заняты");
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
