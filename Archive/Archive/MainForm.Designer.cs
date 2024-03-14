namespace Archive
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            fileBox = new TextBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 1;
            label1.Text = "أرشيف المجلس الطبى العسكرى العام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(606, 99);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 2;
            label2.Text = ":الاسم";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 97);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(325, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(548, 168);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = ":الرقم العسكرى";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 166);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(325, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(609, 261);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(407, 344);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 7;
            button1.Text = "رفع الملف ";
            button1.UseVisualStyleBackColor = false;
            // 
            // fileBox
            // 
            fileBox.Location = new Point(208, 276);
            fileBox.Name = "fileBox";
            fileBox.RightToLeft = RightToLeft.Yes;
            fileBox.Size = new Size(325, 23);
            fileBox.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(571, 276);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "الملف";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(599, 223);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 11;
            label5.Text = ":الرتبه";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(208, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(325, 23);
            comboBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(208, 344);
            button3.Name = "button3";
            button3.Size = new Size(126, 45);
            button3.TabIndex = 13;
            button3.Text = "تسجيل الخروج ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(726, 444);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(fileBox);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private TextBox fileBox;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private ComboBox comboBox1;
        private Button button3;
    }
}