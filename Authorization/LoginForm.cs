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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void _1_FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void _1_FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //

        private void button_login_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM Users Where Login = @login AND Password = @password", connection);
                command.Parameters.AddWithValue("@login", textBox_login.Text);
                command.Parameters.AddWithValue("@password", textBox_password.Text);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if(table.Rows.Count != 0)
                {
                    GlobalUser.name = table.Rows[0][3].ToString();
                    GlobalUser.role = table.Rows[0][2].ToString();
                    switch (GlobalUser.role)
                    {
                        case "Заказчик":
                            _2_MainForm_Customer_Home form1 = new _2_MainForm_Customer_Home();
                            this.Hide();
                            form1.Show();
                            break;

                        case "Директор":
                            _2_MainForm_Director form2 = new _2_MainForm_Director();
                            this.Hide();
                            form2.Show();
                            break;

                        case "Менеджер":
                            ManagerForm form3 = new ManagerForm();
                            this.Hide();
                            form3.Show();
                            break;

                        case "Кладовщик":
                            _2_MainForm_Storekeeper form4 = new _2_MainForm_Storekeeper();
                            this.Hide();
                            form4.Show();
                            break;

                        default:
                            MessageBox.Show("чето не так с ролями ну кто так делает то");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Авторизация не удалась");
                }
            }
        }

        private void label_register_Click(object sender, EventArgs e)
        {
            RegisterForm form5 = new RegisterForm();
            this.Hide();
            form5.Show();
        }
    }
}
