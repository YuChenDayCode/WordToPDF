namespace WordToPDF
{
    partial class WordToPDF
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
            label1 = new Label();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 14);
            button1.Name = "button1";
            button1.Size = new Size(148, 31);
            button1.TabIndex = 0;
            button1.Text = "待转换Word文件夹";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 163);
            button2.Name = "button2";
            button2.Size = new Size(472, 51);
            button2.TabIndex = 2;
            button2.Text = "开始转换";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 123);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(472, 34);
            progressBar1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(12, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 27);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(313, 76);
            button3.Name = "button3";
            button3.Size = new Size(147, 29);
            button3.TabIndex = 6;
            button3.Text = "导出PDF文件夹";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(186, 130);
            label2.Name = "label2";
            label2.Size = new Size(13, 20);
            label2.TabIndex = 7;
            label2.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 214);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Word转PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Label label2;
    }
}