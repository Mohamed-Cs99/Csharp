﻿namespace Archive
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
            label2 = new Label();
            label3 = new Label();
            nameBox = new TextBox();
            PassBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 19);
            label1.Name = "label1";
            label1.Size = new Size(211, 24);
            label1.TabIndex = 0;
            label1.Text = "المجلس الطبى العسكرى العام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 92);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 1;
            label2.Text = "UserName : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 171);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 2;
            label3.Text = "Password  : ";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(154, 91);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(329, 23);
            nameBox.TabIndex = 3;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(154, 170);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(329, 23);
            PassBox.TabIndex = 4;
            PassBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(220, 272);
            button1.Name = "button1";
            button1.Size = new Size(95, 38);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(333, 271);
            button2.Name = "button2";
            button2.Size = new Size(92, 39);
            button2.TabIndex = 6;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkGray;
            ClientSize = new Size(522, 355);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PassBox);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameBox;
        private TextBox PassBox;
        private Button button1;
        private Button button2;
    }
}
