namespace WinFormsApp1
{
    partial class FormMain
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            but_exit = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.DarkMagenta;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 14);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 0;
            button1.Text = "open file";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(270, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 766);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 29);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 113);
            panel1.TabIndex = 4;
            // 
            // but_exit
            // 
            but_exit.BackColor = Color.Black;
            but_exit.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            but_exit.FlatAppearance.MouseOverBackColor = Color.DarkMagenta;
            but_exit.FlatStyle = FlatStyle.Flat;
            but_exit.Font = new Font("Calibri", 10F);
            but_exit.ForeColor = Color.White;
            but_exit.Location = new Point(794, 5);
            but_exit.Margin = new Padding(3, 4, 3, 4);
            but_exit.Name = "but_exit";
            but_exit.Size = new Size(25, 25);
            but_exit.TabIndex = 8;
            but_exit.Text = "X";
            but_exit.UseVisualStyleBackColor = false;
            but_exit.Click += but_exit_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.DarkMagenta;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 59);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 9;
            button2.Text = "search tag";
            button2.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(940, 778);
            ControlBox = false;
            Controls.Add(but_exit);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parser DICOM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button but_exit;
        private Button button2;
        private OpenFileDialog openFileDialog1;
    }
}
