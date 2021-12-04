using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGI
{
    public partial class ConstructorForm_ChoseEdge : Form
    {
        public Color color { get; set; } = Color.Black;
        public Pen pen { get; set; } = new Pen(Color.Black, 5);
        public void UpdateColor()
        {
            picResultColor.BackColor = color;            
        }

        //

        public ConstructorForm_ChoseEdge()
        {
            InitializeComponent();
            UpdateColor();
        }

        //

        public void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pen.DashStyle = DashStyle.Dash;
                pictureBox1.Invalidate();
                pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
            }
            if (radioButton2.Checked == true)
            {
                pen.DashStyle = DashStyle.DashDot;
                pictureBox1.Invalidate();
                pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
            }
            if (radioButton3.Checked == true)
            {
                pen.DashStyle = DashStyle.DashDotDot;
                pictureBox1.Invalidate();
                pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
            }
            if (radioButton4.Checked == true)
            {
                pen.DashStyle = DashStyle.Dot;
                pictureBox1.Invalidate();
                pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
            }
            if (radioButton5.Checked == true)
            {
                pen.DashStyle = DashStyle.Solid;
                pictureBox1.Invalidate();
                pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
            }
        }

        public void OtherColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                pen.Color = color;
                UpdateColor();
                pictureBox1.Invalidate();
                pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            pictureBox1.Invalidate();
            pictureBox1_Paint(sender, new PaintEventArgs(pictureBox1.CreateGraphics(), pictureBox1.Bounds));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {           
            e.Graphics.DrawLine(pen, 5, 5, 470, 5);
        }
    }
}
