namespace first_gui
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
            label4 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "No 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "No 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 130);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Avarage";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 176);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Sum";
            // 
            // txt1
            // 
            txt1.Location = new Point(126, 48);
            txt1.Name = "txt1";
            txt1.Size = new Size(194, 23);
            txt1.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Location = new Point(126, 88);
            txt2.Name = "txt2";
            txt2.Size = new Size(194, 23);
            txt2.TabIndex = 5;
            // 
            // txt3
            // 
            txt3.Location = new Point(126, 127);
            txt3.Name = "txt3";
            txt3.Size = new Size(194, 23);
            txt3.TabIndex = 6;
            // 
            // txt4
            // 
            txt4.Location = new Point(126, 173);
            txt4.Name = "txt4";
            txt4.Size = new Size(194, 23);
            txt4.TabIndex = 7;
            // 
            // btn1
            // 
            btn1.Location = new Point(41, 237);
            btn1.Name = "btn1";
            btn1.Size = new Size(119, 23);
            btn1.TabIndex = 8;
            btn1.Text = "Calculate";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(200, 237);
            btn2.Name = "btn2";
            btn2.Size = new Size(120, 23);
            btn2.TabIndex = 9;
            btn2.Text = "Close";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 304);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private Button btn1;
        private Button btn2;
    }
}