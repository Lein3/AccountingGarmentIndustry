using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AGI
{
    public partial class InformationupdateForm : Form
    {
        string parent;
        string imageString;
        public InformationupdateForm(string article, string name, string color, string drawing, string image, string structure, double width, double lenght, double price)
        {
            InitializeComponent();
            parent = "cloth";
            imageString = image;

            label1.Text = "article";
            textBox1.Text = article;

            label2.Text = "name";
            textBox2.Text = name;

            label3.Text = "color";
            textBox3.Text = color;

            label4.Text = "drawing";
            textBox4.Text = drawing;

            label5.Text = "image";
            textBox5.Text = "выберите изображение";
            textBox5.ForeColor = Color.Gray;
            try
            {
                var imageR = Image.FromStream(new MemoryStream(Convert.FromBase64String(image)));
                pictureBox2.Image = imageR;
            }
            catch
            {
                MessageBox.Show("изображение отсутсвтует");
            }

            label6.Text = "structure";
            textBox6.Text = structure;

            label7.Text = "width";
            textBox7.Text = Convert.ToString(width);

            label8.Text = "lenght";
            textBox8.Text = Convert.ToString(lenght);

            label9.Text = "price";
            textBox9.Text = Convert.ToString(price);

            label10.Visible = false;
            textBox10.Visible = false;
        }

        public InformationupdateForm(string article, string name, string type, double price, string image, double width, double lenght, double weight)
        {
            InitializeComponent();
            parent = "furniture";
            imageString = image;

            label1.Text = "article";
            textBox1.Text = article;

            label2.Text = "name";
            textBox2.Text = name;

            label3.Text = "type";
            textBox3.Text = type;

            label4.Text = "price";
            textBox4.Text = Convert.ToString(price);

            label5.Text = "image";
            textBox5.Text = "выберите изображение...";
            textBox5.ForeColor = Color.Gray;
            try
            {
                var imageR = Image.FromStream(new MemoryStream(Convert.FromBase64String(image)));
                pictureBox2.Image = imageR;
            }
            catch
            {
                MessageBox.Show("изображение отсутсвтует");
            }

            label6.Text = "width";
            textBox6.Text = Convert.ToString(width);

            label7.Text = "lenght";
            textBox7.Text = Convert.ToString(lenght);

            label8.Text = "weight";
            textBox8.Text = Convert.ToString(weight);

            label9.Visible = false;
            textBox9.Visible = false;

            label10.Visible = false;
            textBox10.Visible = false;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageString = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
                var imageReady = Image.FromStream(new MemoryStream(Convert.FromBase64String(imageString)));
                pictureBox2.Image = imageReady;
            }
            textBox5.Text = openFileDialog.FileName;
            textBox5.ForeColor = Color.Black;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            switch(parent)
            {
                case "cloth":
                    using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE Cloth Set Article = @article, Name = @name, Color = @color, Drawing = @drawing, Image = @image, Structure = @structure, Width = @width, Lenght = @lenght, Price = @price WHERE Article = @id", connection);
                        command.Parameters.AddWithValue("@id", SelectedId.id);
                        command.Parameters.AddWithValue("@article", textBox1.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        command.Parameters.AddWithValue("@color", textBox3.Text);
                        command.Parameters.AddWithValue("@drawing", textBox4.Text);
                        command.Parameters.AddWithValue("@image", imageString);
                        command.Parameters.AddWithValue("@structure", textBox6.Text);
                        command.Parameters.AddWithValue("@width", Convert.ToDouble(textBox7.Text));
                        command.Parameters.AddWithValue("@lenght", Convert.ToDouble(textBox8.Text));
                        command.Parameters.AddWithValue("@price", Convert.ToDouble(textBox9.Text));
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("gotovo");
                        }
                        catch
                        {
                            MessageBox.Show("запись уже существует");
                        }
                        this.Close();
                    }
                    break;
                case "furniture":
                    using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("UPDATE Furniture Set Article = @article, Name = @name, Type = @type, Price = @price, Image = @image, Width = @width, Lenght = @lenght, Weight = @weight  WHERE Article = @id", connection);
                        command.Parameters.AddWithValue("@id", SelectedId.id);
                        command.Parameters.AddWithValue("@article", textBox1.Text);
                        command.Parameters.AddWithValue("@name", textBox2.Text);
                        command.Parameters.AddWithValue("@type", textBox3.Text);
                        command.Parameters.AddWithValue("@price", Convert.ToInt32(textBox4.Text));
                        command.Parameters.AddWithValue("@image", imageString);
                        command.Parameters.AddWithValue("@width", Convert.ToDouble(textBox6.Text));
                        command.Parameters.AddWithValue("@lenght", Convert.ToDouble(textBox7.Text));
                        command.Parameters.AddWithValue("@wieght", Convert.ToDouble(textBox8.Text));
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("gotovo");
                        }
                        catch
                        {
                            MessageBox.Show("запись уже существует");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
