namespace Project1
{
    partial class Form6
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
            Button1 = new Button();
            Button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(160, 77);
            label1.TabIndex = 0;
            label1.Text = "Timezones ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(206, 77);
            label2.TabIndex = 1;
            label2.Text = "Currency conventer";
            // 
            // Button1
            // 
            Button1.Location = new Point(224, 42);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Click me";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Location = new Point(224, 119);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 3;
            Button2.Text = "Click me";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(41, 195);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(200, 195);
            button4.Name = "button4";
            button4.Size = new Size(119, 29);
            button4.TabIndex = 5;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 238);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Button1;
        private Button Button2;
        private Button button3;
        private Button button4;
    }
}