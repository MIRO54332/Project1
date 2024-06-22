namespace Project1
{
    partial class Form8
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
            amountLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            amountLabel.Location = new Point(12, 21);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(162, 83);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Enter amount: ";
            amountLabel.Click += amountLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(162, 83);
            label1.TabIndex = 2;
            label1.Text = "Convert from: ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(133, 83);
            label2.TabIndex = 3;
            label2.Text = "To: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Levas", "Dollar", "Euro" });
            comboBox1.Location = new Point(178, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Levas", "Dollar", "Euro" });
            comboBox2.Location = new Point(178, 118);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(91, 216);
            button1.Name = "button1";
            button1.Size = new Size(188, 23);
            button1.TabIndex = 6;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(39, 178);
            label3.Name = "label3";
            label3.Size = new Size(275, 23);
            label3.TabIndex = 7;
            label3.Text = "Converted amount: ";
            label3.Click += label3_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 270);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(amountLabel);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label amountLabel;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Label label3;
    }
}