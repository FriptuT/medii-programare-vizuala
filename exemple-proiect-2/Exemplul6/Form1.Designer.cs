namespace Exemplul6
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 261);
            button1.Name = "button1";
            button1.Size = new Size(185, 63);
            button1.TabIndex = 0;
            button1.Text = "Verifica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 209);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(32, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "1";
            checkBox1.ThreeState = true;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(105, 209);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(32, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "2";
            checkBox2.ThreeState = true;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(174, 209);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(32, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "3";
            checkBox3.ThreeState = true;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(238, 209);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(32, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "4";
            checkBox4.ThreeState = true;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(303, 209);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(32, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "5";
            checkBox5.ThreeState = true;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 91);
            label1.Name = "label1";
            label1.Size = new Size(814, 21);
            label1.TabIndex = 6;
            label1.Text = "Ionel are 5 mere si trebuie sa puna merele in saci astfel incat in fiecare sac sa fie un numar diferit de mere.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 130);
            label2.Name = "label2";
            label2.Size = new Size(245, 21);
            label2.TabIndex = 7;
            label2.Text = "Cati saci cu mere poate utiliza?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(304, 291);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 8;
            label3.Text = "Sunteti sigur ???";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(475, 294);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(41, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "DA";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(475, 330);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(42, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "NU";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
