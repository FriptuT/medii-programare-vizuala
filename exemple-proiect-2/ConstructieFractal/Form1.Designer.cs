namespace ConstructieFractal
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            START = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label1.Location = new Point(244, 51);
            label1.Name = "label1";
            label1.Size = new Size(227, 24);
            label1.TabIndex = 0;
            label1.Text = "Construirea unui fractal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label2.Location = new Point(35, 140);
            label2.Name = "label2";
            label2.Size = new Size(298, 30);
            label2.TabIndex = 1;
            label2.Text = "Introduceti numarul de patrate";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // START
            // 
            START.ForeColor = Color.CornflowerBlue;
            START.Location = new Point(463, 147);
            START.Name = "START";
            START.Size = new Size(84, 25);
            START.TabIndex = 3;
            START.Text = "START";
            START.UseVisualStyleBackColor = true;
            START.Click += START_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(724, 501);
            Controls.Add(START);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button START;
        private System.Windows.Forms.Timer timer1;
        int m;
    }
}
