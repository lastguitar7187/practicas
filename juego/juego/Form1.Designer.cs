namespace juego
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
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            none = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(204, 72);
            label1.Name = "label1";
            label1.Size = new Size(24, 31);
            label1.TabIndex = 0;
            label1.Text = "?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(415, 300);
            button1.Name = "button1";
            button1.Size = new Size(108, 56);
            button1.TabIndex = 1;
            button1.Text = "JUGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Piedra", "Papel", "Tijeras" });
            comboBox1.BackColor = SystemColors.HotTrack;
            comboBox1.ForeColor = SystemColors.MenuText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Piedra", "Tijeras", "Papel" });
            comboBox1.Location = new Point(383, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // none
            // 
            none.AutoSize = true;
            none.Font = new Font("Segoe UI", 17F);
            none.Location = new Point(725, 72);
            none.Name = "none";
            none.Size = new Size(24, 31);
            none.TabIndex = 4;
            none.Text = "?";
            none.Click += none_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 29F);
            label3.Location = new Point(146, 365);
            label3.Name = "label3";
            label3.Size = new Size(154, 52);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 29F);
            label4.Location = new Point(681, 355);
            label4.Name = "label4";
            label4.Size = new Size(68, 52);
            label4.TabIndex = 6;
            label4.Text = "PC";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 282);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.ErrorImage = Properties.Resources.interrrogante;
            pictureBox1.Image = Properties.Resources.interrrogante;
            pictureBox1.InitialImage = Properties.Resources.interrrogante;
            pictureBox1.Location = new Point(100, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.interrrogante;
            pictureBox2.Location = new Point(596, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 530);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(none);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Label none;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
