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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        private void _2_MainForm_Manager_Load(object sender, EventArgs e)
        {
            label_Name.Text = GlobalUser.name;
        }
        private void _2_MainForm_Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }

        //

        private void button_product_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Product", connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Cloth");
                dataGridView.DataSource = dataSet.Tables["Cloth"];
            }
            groupBox_product.Visible = true;

            textBox1.Text = null;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Article";

            textBox2.Text = null;
            textBox2.Visible = true;
            label2.Visible = true;
            label2.Text = "Name";

            textBox3.Text = null;
            textBox3.Visible = true;
            label3.Visible = true;
            label3.Text = "Width";

            textBox4.Text = null;
            textBox4.Visible = true;
            label4.Visible = true;
            label4.Text = "Lenght";

            textBox5.Text = null;
            textBox5.Visible = true;
            label5.Visible = true;
            label5.Text = "Image";

            textBox6.Text = null;
            textBox6.Visible = true;
            label6.Visible = true;
            label6.Text = "Comments";

            textBox7.Text = null;
            textBox7.Visible = false;
            label7.Visible = false;
            label7.Text = "";

            textBox8.Text = null;
            textBox8.Visible = false;
            label8.Visible = false;
            label8.Text = "";

            textBox9.Text = null;
            textBox9.Visible = false;
            label9.Visible = false;
            label9.Text = "";

            textBox10.Text = null;
            textBox10.Visible = false;
            label10.Visible = false;
            label10.Text = "";
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedId.id = Convert.ToString(dataGridView.CurrentRow.Cells[0].Value);
        }

        private void radioButton_product_create_Click(object sender, EventArgs e)
        {
            button_dynamic_product.Visible = true;
            button_dynamic_product.Text = "Создать";
        }

        private void radioButton_product_update_Click(object sender, EventArgs e)
        {
            button_dynamic_product.Visible = true;
            button_dynamic_product.Text = "Редактировать";
        }

        private void radioButton_product_delete_Click(object sender, EventArgs e)
        {
            button_dynamic_product.Visible = true;
            button_dynamic_product.Text = "удалить";
        }

        private void button_dynamic_product_Click(object sender, EventArgs e)
        {
            if (radioButton_product_create.Checked)
                using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Product VALUES (@article, @name, @width, @lenght, @image, @comments)", connection);
                    command.Parameters.AddWithValue("@article", textBox1.Text);
                    command.Parameters.AddWithValue("@name", textBox2.Text);
                    command.Parameters.AddWithValue("@width", Convert.ToDouble(textBox3.Text));
                    command.Parameters.AddWithValue("@lenght", Convert.ToDouble(textBox4.Text));
                    command.Parameters.AddWithValue("@image", textBox5.Text);
                    command.Parameters.AddWithValue("@comments", textBox6.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("gotovo");
                    }
                    catch
                    {
                        MessageBox.Show("запись уже существует");
                    }
                    button_product_Click(sender, e);
                }
            if (radioButton_product_update.Checked && SelectedId.id != null)
                using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Product Set Article = @article, Name = @name, Width = @width, Lenght = @lenght, Image = @image, Comments = @comments WHERE Article = @id", connection);
                    command.Parameters.AddWithValue("@id", SelectedId.id);
                    command.Parameters.AddWithValue("@article", textBox1.Text);
                    command.Parameters.AddWithValue("@name", textBox2.Text);
                    command.Parameters.AddWithValue("@width", Convert.ToDouble(textBox3.Text));
                    command.Parameters.AddWithValue("@lenght", Convert.ToDouble(textBox4.Text));
                    command.Parameters.AddWithValue("@image", textBox5.Text);
                    command.Parameters.AddWithValue("@comments", textBox6.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("gotovo");
                    }
                    catch
                    {
                        MessageBox.Show("запись уже существует");
                    }
                    button_product_Click(sender, e);
                }
            if (radioButton_product_delete.Checked)
                if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DELETE FROM Product WHERE Article = @id", connection);
                        command.Parameters.AddWithValue("@id", SelectedId.id);
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("gotovo");
                        }
                        catch
                        {
                            MessageBox.Show("запись уже существует");
                        }
                        button_product_Click(sender, e);
                    }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
