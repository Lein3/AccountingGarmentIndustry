
namespace AGI
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_control = new System.Windows.Forms.Panel();
            this.groupBox_product = new System.Windows.Forms.GroupBox();
            this.radioButton_product_delete = new System.Windows.Forms.RadioButton();
            this.radioButton_product_update = new System.Windows.Forms.RadioButton();
            this.radioButton_product_create = new System.Windows.Forms.RadioButton();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.label_goodday = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.button_dynamic_product = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_control.SuspendLayout();
            this.groupBox_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(784, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel_control.Controls.Add(this.groupBox_product);
            this.panel_control.Controls.Add(this.button_exit);
            this.panel_control.Controls.Add(this.button_product);
            this.panel_control.Controls.Add(this.label_goodday);
            this.panel_control.Controls.Add(this.pictureBox1);
            this.panel_control.Controls.Add(this.label_Name);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_control.Location = new System.Drawing.Point(0, 120);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(200, 641);
            this.panel_control.TabIndex = 7;
            // 
            // groupBox_product
            // 
            this.groupBox_product.Controls.Add(this.radioButton_product_delete);
            this.groupBox_product.Controls.Add(this.radioButton_product_update);
            this.groupBox_product.Controls.Add(this.radioButton_product_create);
            this.groupBox_product.Location = new System.Drawing.Point(12, 357);
            this.groupBox_product.Name = "groupBox_product";
            this.groupBox_product.Size = new System.Drawing.Size(177, 81);
            this.groupBox_product.TabIndex = 8;
            this.groupBox_product.TabStop = false;
            this.groupBox_product.Visible = false;
            // 
            // radioButton_product_delete
            // 
            this.radioButton_product_delete.AutoSize = true;
            this.radioButton_product_delete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_product_delete.Location = new System.Drawing.Point(69, 49);
            this.radioButton_product_delete.Name = "radioButton_product_delete";
            this.radioButton_product_delete.Size = new System.Drawing.Size(65, 17);
            this.radioButton_product_delete.TabIndex = 5;
            this.radioButton_product_delete.TabStop = true;
            this.radioButton_product_delete.Text = "удалить";
            this.radioButton_product_delete.UseVisualStyleBackColor = true;
            this.radioButton_product_delete.Click += new System.EventHandler(this.radioButton_product_delete_Click);
            // 
            // radioButton_product_update
            // 
            this.radioButton_product_update.AutoSize = true;
            this.radioButton_product_update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_product_update.Location = new System.Drawing.Point(69, 34);
            this.radioButton_product_update.Name = "radioButton_product_update";
            this.radioButton_product_update.Size = new System.Drawing.Size(101, 17);
            this.radioButton_product_update.TabIndex = 4;
            this.radioButton_product_update.TabStop = true;
            this.radioButton_product_update.Text = "редактировать";
            this.radioButton_product_update.UseVisualStyleBackColor = true;
            this.radioButton_product_update.Click += new System.EventHandler(this.radioButton_product_update_Click);
            // 
            // radioButton_product_create
            // 
            this.radioButton_product_create.AutoSize = true;
            this.radioButton_product_create.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radioButton_product_create.Location = new System.Drawing.Point(69, 19);
            this.radioButton_product_create.Name = "radioButton_product_create";
            this.radioButton_product_create.Size = new System.Drawing.Size(66, 17);
            this.radioButton_product_create.TabIndex = 3;
            this.radioButton_product_create.TabStop = true;
            this.radioButton_product_create.Text = "создать";
            this.radioButton_product_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton_product_create.UseVisualStyleBackColor = true;
            this.radioButton_product_create.Click += new System.EventHandler(this.radioButton_product_create_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.button_exit.Location = new System.Drawing.Point(7, 590);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(182, 39);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_product
            // 
            this.button_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.button_product.Location = new System.Drawing.Point(12, 312);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(182, 39);
            this.button_product.TabIndex = 3;
            this.button_product.Text = "Изделия";
            this.button_product.UseVisualStyleBackColor = false;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // label_goodday
            // 
            this.label_goodday.AutoSize = true;
            this.label_goodday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_goodday.Location = new System.Drawing.Point(36, 137);
            this.label_goodday.Name = "label_goodday";
            this.label_goodday.Size = new System.Drawing.Size(114, 20);
            this.label_goodday.TabIndex = 1;
            this.label_goodday.Text = "Добрый день,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(36, 157);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(153, 20);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Имя пользователя";
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_dynamic_product);
            this.panel_bottom.Controls.Add(this.textBox6);
            this.panel_bottom.Controls.Add(this.textBox7);
            this.panel_bottom.Controls.Add(this.textBox8);
            this.panel_bottom.Controls.Add(this.textBox9);
            this.panel_bottom.Controls.Add(this.textBox10);
            this.panel_bottom.Controls.Add(this.textBox5);
            this.panel_bottom.Controls.Add(this.textBox4);
            this.panel_bottom.Controls.Add(this.textBox3);
            this.panel_bottom.Controls.Add(this.textBox2);
            this.panel_bottom.Controls.Add(this.textBox1);
            this.panel_bottom.Controls.Add(this.label10);
            this.panel_bottom.Controls.Add(this.label9);
            this.panel_bottom.Controls.Add(this.label8);
            this.panel_bottom.Controls.Add(this.label7);
            this.panel_bottom.Controls.Add(this.label6);
            this.panel_bottom.Controls.Add(this.label5);
            this.panel_bottom.Controls.Add(this.label4);
            this.panel_bottom.Controls.Add(this.label3);
            this.panel_bottom.Controls.Add(this.label2);
            this.panel_bottom.Controls.Add(this.label1);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(200, 535);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(584, 226);
            this.panel_bottom.TabIndex = 8;
            // 
            // button_dynamic_product
            // 
            this.button_dynamic_product.Location = new System.Drawing.Point(175, 175);
            this.button_dynamic_product.Name = "button_dynamic_product";
            this.button_dynamic_product.Size = new System.Drawing.Size(230, 40);
            this.button_dynamic_product.TabIndex = 21;
            this.button_dynamic_product.UseVisualStyleBackColor = true;
            this.button_dynamic_product.Visible = false;
            this.button_dynamic_product.Click += new System.EventHandler(this.button_dynamic_product_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(360, 15);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(360, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(360, 75);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(360, 105);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(200, 20);
            this.textBox9.TabIndex = 16;
            this.textBox9.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(360, 135);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(200, 20);
            this.textBox10.TabIndex = 15;
            this.textBox10.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(70, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(219, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(70, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(219, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(200, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(584, 415);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // _2_MainForm_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.pictureBox2);
            this.Name = "_2_MainForm_Manager";
            this.Text = "Экран Менеджера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this._2_MainForm_Manager_FormClosed);
            this.Load += new System.EventHandler(this._2_MainForm_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.groupBox_product.ResumeLayout(false);
            this.groupBox_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.GroupBox groupBox_product;
        private System.Windows.Forms.RadioButton radioButton_product_delete;
        private System.Windows.Forms.RadioButton radioButton_product_update;
        private System.Windows.Forms.RadioButton radioButton_product_create;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Label label_goodday;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Button button_dynamic_product;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}