namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add logic here if needed, or leave empty
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Görüntüle = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Görüntüle
            // 
            Görüntüle.BackColor = Color.RoyalBlue;
            Görüntüle.Location = new Point(853, 489);
            Görüntüle.Name = "Görüntüle";
            Görüntüle.Size = new Size(158, 45);
            Görüntüle.TabIndex = 0;
            Görüntüle.Text = "Görüntüle";
            Görüntüle.UseVisualStyleBackColor = false;
            Görüntüle.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(61, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(950, 240);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ilacad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ilacsirketi";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ilacturu";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ilackutuadedi";
            columnHeader5.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Location = new Point(853, 427);
            button1.Name = "button1";
            button1.Size = new Size(158, 45);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(50, 305);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 3;
            label1.Text = "Sıra:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(50, 347);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 5;
            label2.Text = "İlaç Adı:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 334);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(222, 431);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(222, 480);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(50, 386);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 10;
            label3.Text = "İlaç Şirketi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(50, 432);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 11;
            label4.Text = "İlaç Türü:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(50, 480);
            label5.Name = "label5";
            label5.Size = new Size(134, 23);
            label5.TabIndex = 12;
            label5.Text = "İlaç Kutu Adeti:";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Location = new Point(853, 364);
            button2.Name = "button2";
            button2.Size = new Size(158, 45);
            button2.TabIndex = 13;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Location = new Point(853, 298);
            button3.Name = "button3";
            button3.Size = new Size(158, 45);
            button3.TabIndex = 14;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1192, 584);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(Görüntüle);
            Name = "Form1";
            Text = "Bozkurt Eczanesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Görüntüle;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}
