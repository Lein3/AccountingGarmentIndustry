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
using System.IO;

namespace AGI
{
    public partial class ConstructorForm : Form
    {
        bool ftutorial = true;
        bool tutorial = false;
        bool isCliced = false;
        bool isDrawed = false;
        bool fromMove = false;
        int realX;
        int realY;
        int dx = 0;
        int dy = 0;
        int i = 0;
        int listCliced = 0;
        Rectangle rectangle = new Rectangle(30, 30, 0, 0);
        List<Rectangle> furnitures = new List<Rectangle>();
        Image imageForFillFirst;
        List<Image> images = new List<Image>();
        Pen pen = new Pen(Color.Black, 5);

        public ConstructorForm()
        {
            InitializeComponent();
            tabPage1_textbox_width.Text = "50";
            tabPage1_textbox_height.Text = "50";           
        }
        private void _2_MainForm_Customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAGI.Furniture". При необходимости она может быть перемещена или удалена.
            this.furnitureTableAdapter.Fill(this.dataSetAGI.Furniture);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetAGI.Cloth". При необходимости она может быть перемещена или удалена.
            this.clothTableAdapter.Fill(this.dataSetAGI.Cloth);
        }
        private void _2_MainForm_Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_1_StartForm_Login form = new _1_StartForm_Login();
            //form.Show();
            Application.Exit();
        }
        private void tutorialEvent()
        {
            var result = MessageBox.Show("Добро пожаловать в конструктор изделий. Желаете пройти обучение?", "Обучение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ftutorial = false;
                tutorial = true;
            }              
            else
            {
                ftutorial = false;
                tutorial = false;
            }               
            if (tutorial)
                MessageBox.Show("Это стартовое окно конструктора. Здесь необходимо создать заготовку для вашего продукта, укажите его длину и ширину, затем нажмите кнопку создать");
        }

        //

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Добро пожаловать в конструктор изделий. Желаете пройти обучение?", "Обучение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ftutorial = false;
                tutorial = true;
            }
            else
            {
                ftutorial = false;
                tutorial = false;
            }
            if (tutorial)
                MessageBox.Show("Это стартовое окно конструктора. Здесь необходимо создать заготовку для вашего продукта, укажите его длину и ширину, затем нажмите кнопку создать");
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            switch(progressBar.Value)
            {
                case 1:
                    if(!isDrawed) MessageBox.Show("сначала создайте заготовку");
                    else
                    {
                        progressBar.Value += progressBar.Step;
                        tabControl.SelectTab(tabPage2);
                        tabPage1_panel.Enabled = false;
                        tabPage2_panel.Enabled = true;
                        tabPage2_panel.Visible = true;
                        if (tutorial)
                            MessageBox.Show("Это окно выбора ткани. Здесь вы можете выбрать готовую ткань с нашего склада, используя первый выпадающий список, после выбора вам отобразится выбранная ткань, далее вы можете подтвердить выбранную ткань либо продолжить выбор из других вариантов. Если вас не устраивают ткани нашего склада, вы можете использовать вторую строку и выбрать сообственный материал");
                    }
                    break;
                case 2:
                    if (imageForFillFirst == null) MessageBox.Show("изображение не выбрано");
                    else
                    {
                        progressBar.Value += progressBar.Step;
                        tabControl.SelectTab(tabPage3);
                        tabPage2_panel.Enabled = false;
                        tabPage3_panel.Enabled = true;
                        tabPage3_panel.Visible = true;
                        if (tutorial)
                            MessageBox.Show("Это Окно выбора окантовки, вы можете выбрать готовый вариант из списка ниже, либо создать сообственную окантовку - будет открыто новое окно где вы можете выбрать ее цвет, форму и размер, после выбора нажмите далее");
                    }                  
                    break;
                case 3:
                    progressBar.Value += progressBar.Step;
                    tabControl.SelectTab(tabPage4);
                    tabPage3_panel.Enabled = false;
                    tabPage4_panel.Enabled = true;
                    tabPage4_panel.Visible = true;
                    if (tutorial)
                        MessageBox.Show("Завершающий этап, здесь вы можете выбрать готовую фурнитуру для вашего изделия, используйте левую кнопку для того, чтобы указать ее расположение, правую - для того, чтобы выбрать размер. После этого нажмите кнопку закончить создание изделия");
                    break;
                default: break;
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            switch (progressBar.Value)
            {
                case 2:
                    progressBar.Value -= progressBar.Step;
                    tabControl.SelectTab(tabPage1);
                    tabPage2_panel.Enabled = false;
                    tabPage2_panel.Visible = false;
                    tabPage1_panel.Enabled = true;
                    pictureBox_main_Paint(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
                    break;
                case 3:
                    progressBar.Value -= progressBar.Step;
                    tabControl.SelectTab(tabPage2);
                    tabPage3_panel.Enabled = false;
                    tabPage3_panel.Visible = false;
                    tabPage2_panel.Enabled = true;
                    break;
                case 4:
                    progressBar.Value -= progressBar.Step;
                    tabControl.SelectTab(tabPage3);
                    tabPage4_panel.Enabled = false;
                    tabPage4_panel.Visible = false;
                    tabPage3_panel.Enabled = true;
                    break;
                default: break;
            }
        }

        //step1

        private void tabPage1_button_draw_Click(object sender, EventArgs e)
        {
            if (tutorial)
                MessageBox.Show("Теперь когда изделие создано вы можете его отредактировать. Используйте левую кнопку для перетаскивания изделия, правую - для изменения размеров и формы. После того как редактирование завершено нажмите кнопку далее в правом верхнем углу.");

            pictureBox_main.Invalidate();
            isDrawed = true;
            realX = Convert.ToInt32(tabPage1_textbox_width.Text);
            realY = Convert.ToInt32(tabPage1_textbox_height.Text);
            rectangle.Width = Convert.ToInt32(tabPage1_textbox_width.Text) % 700;
            rectangle.Height = Convert.ToInt32(tabPage1_textbox_height.Text) % 700;
            pictureBox_main_Paint(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
        }

        private void pictureBox_main_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressBar.Value == 1)
                if ((e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.X))
                    if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
                    {
                        isCliced = true;
                        dx = e.X - rectangle.X;
                        dy = e.Y - rectangle.Y;
                    }
            if (progressBar.Value == 4)
                foreach(Rectangle rectangle in furnitures)
                {
                    if ((e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.X))
                        if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
                        {
                            isCliced = true;
                            listCliced = furnitures.IndexOf(rectangle);
                            dx = e.X - rectangle.X;
                            dy = e.Y - rectangle.Y;
                        }
                }    
        }

        private void pictureBox_main_MouseMove(object sender, MouseEventArgs e)
        {          
            if (progressBar.Value == 1)
            {
                if (e.Button == MouseButtons.Left)
                    if (isCliced)
                    {
                        rectangle.X = e.X - dx;
                        rectangle.Y = e.Y - dy;
                        pictureBox_main.Invalidate();
                    }
                if (e.Button == MouseButtons.Right)
                    if (isCliced)
                    {
                        rectangle.Width = e.X - dx;
                        rectangle.Height = e.Y - dy;
                        pictureBox_main.Invalidate();
                    }
            }
            if (progressBar.Value == 4)
            {
                if (e.Button == MouseButtons.Left)
                    if (isCliced)
                    {
                        Rectangle temp = furnitures[listCliced];
                        temp.X = e.X - dx;
                        temp.Y = e.Y - dy;
                        furnitures[listCliced] = temp;
                        fromMove = true;
                        pictureBox_main.Invalidate();
                    }
                if (e.Button == MouseButtons.Right)
                    if (isCliced)
                    {
                        Rectangle temp = furnitures[listCliced];
                        temp.Width = e.X - dx;
                        temp.Height = e.Y - dy;
                        furnitures[listCliced] = temp;
                        fromMove = true;
                        pictureBox_main.Invalidate();
                    }
            }
        }

        private void pictureBox_main_MouseUp(object sender, MouseEventArgs e)
        {
            if (progressBar.Value == 1)
                isCliced = false;
            if (progressBar.Value == 4)
                isCliced = false;
        }

        private void pictureBox_main_Paint(object sender, PaintEventArgs e)
        {
            if (ftutorial)
                tutorialEvent();

            e.Graphics.DrawRectangle(pen, rectangle);
            if (imageForFillFirst != null)
                pictureBox_main_PaintFirstRectangle(sender, e);
            if (fromMove)
                pictureBox_main_PaintFurnitures(sender, e);
        }

        private void pictureBox_main_PaintFirstRectangle(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imageForFillFirst, rectangle);
        }

        private void pictureBox_main_PaintFurnitures(object sender, PaintEventArgs e)
        {
            if(!fromMove)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Transparent), furnitures[i]);
                e.Graphics.DrawImage(images[i], 1, 1);
                i++;
            }
            else
            {
                int j = 0;
                foreach (Rectangle rectangle in furnitures)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Transparent), rectangle);
                    e.Graphics.DrawImage(images[j], rectangle);
                    j++;
                }
            }                                
        }

        //step2

        private void comboBox_cloth_SelectedIndexChanged(object sender, EventArgs e)
        {
            _2_MainForm_Customer_ShowImage form = new _2_MainForm_Customer_ShowImage(comboBox_cloth.SelectedValue.ToString());
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                imageForFillFirst = Image.FromStream(new MemoryStream(Convert.FromBase64String(comboBox_cloth.SelectedValue.ToString())));
                pictureBox_main_PaintFirstRectangle(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
                textBox_ChoseImage.Text = "Выберите изображение с компьютера";
            }
        }

        private void textBox_ChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageString = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
                imageForFillFirst = Image.FromStream(new MemoryStream(Convert.FromBase64String(imageString)));
                pictureBox_main_PaintFirstRectangle(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
            }
            textBox_ChoseImage.Text = openFileDialog.FileName;
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            if (isDrawed)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка ? ", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes:
                        Bitmap sFile = new Bitmap(pictureBox_main.Image);
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.Filter = "Bitmap image|.bmp|Jpeg image|.jpg|Gif image|.gif|PNG inage|.png";
                        if (saveFile.ShowDialog() == DialogResult.OK)
                            switch (saveFile.FilterIndex)
                            {
                                case 1:
                                    saveFile.DefaultExt = "bmp";
                                    sFile.Save(saveFile.FileName);
                                    break;
                                case 2:
                                    saveFile.DefaultExt = "jpg";
                                    sFile.Save(saveFile.FileName);
                                    break;
                                case 3:
                                    saveFile.DefaultExt = "gif";
                                    sFile.Save(saveFile.FileName);
                                    break;
                                case 4:
                                    saveFile.DefaultExt = "png";
                                    sFile.Save(saveFile.FileName);
                                    break;
                            }
                        saveFile.Dispose();
                        sFile.Dispose();
                        break;
                    case DialogResult.Cancel: return;
                }
                pictureBox_main.Invalidate();
                rectangle.Width = 0;
                rectangle.Height = 0;
                progressBar.Value = 1;
                tabControl.SelectTab(tabPage1);
                tabPage1_panel.Enabled = true;
                tabPage1_panel.Visible = true;
                tabPage2_panel.Enabled = false;
                tabPage2_panel.Visible = false;
                tabPage3_panel.Enabled = false;
                tabPage3_panel.Visible = false;
                tabPage4_panel.Enabled = false;
                tabPage4_panel.Visible = false;
                pictureBox_main_Paint(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
            }
        }

        //step3

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                ConstructorForm_ChoseEdge form = new ConstructorForm_ChoseEdge();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    pen = form.pen;
                }                   
                pictureBox_main.Invalidate();
                pictureBox_main_Paint(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
                pictureBox_main.Update();
                pictureBox_main_PaintFirstRectangle(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
            }
        }

        //step4

        private void comboBox_furniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            _2_MainForm_Customer_ShowImage form = new _2_MainForm_Customer_ShowImage(comboBox_furniture.SelectedValue.ToString());
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                images.Add(Image.FromStream(new MemoryStream(Convert.FromBase64String(comboBox_furniture.SelectedValue.ToString()))));
                furnitures.Add(new Rectangle(10, 10, imageForFillFirst.Width, imageForFillFirst.Height));
                fromMove = false;
                pictureBox_main_PaintFurnitures(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
                textBox_ChoseImage.Text = "Выберите изображение с компьютера";
            }
        }

        private void textBox_choseFurniture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageString = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
                images.Add(Image.FromStream(new MemoryStream(Convert.FromBase64String(imageString))));
                furnitures.Add(new Rectangle(10, 10, imageForFillFirst.Width, imageForFillFirst.Height));
                fromMove = false;
                pictureBox_main_PaintFurnitures(sender, new PaintEventArgs(pictureBox_main.CreateGraphics(), pictureBox_main.Bounds));
            }
            textBox_choseFurniture.Text = openFileDialog.FileName;
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            //Bitmap sFile = new Bitmap(null);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF File | .pdf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            saveFile.Dispose();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF File | .pdf";
            if (saveFile.ShowDialog() == DialogResult.OK)
                saveFile.Dispose();
        }
    }
}
