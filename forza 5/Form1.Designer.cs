﻿namespace forza_5
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
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(575, 59);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 275);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 172);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(78, 20);
            button3.TabIndex = 1;
            button3.Text = "esci";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 128);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 1;
            button2.Text = "ricomincare";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(27, 20);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 0;
            button1.Text = "INIZIA A GIOCARE!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 382);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(718, 391);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
    }
}
