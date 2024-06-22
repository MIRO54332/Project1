namespace Project1
{
    partial class Form7
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            timezoneLabel = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "", "Dawson", "Los Angeles", "New York", "San Francisko", "Portugal", "", "Romania ", "Germany" });
            listBox1.Location = new Point(105, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(91, 109);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(117, 47);
            label1.TabIndex = 1;
            label1.Text = "Time Zone:";
            // 
            // button1
            // 
            button1.Location = new Point(57, 208);
            button1.Name = "button1";
            button1.Size = new Size(185, 23);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timezoneLabel
            // 
            timezoneLabel.Location = new Point(125, 147);
            timezoneLabel.Name = "timezoneLabel";
            timezoneLabel.Size = new Size(164, 39);
            timezoneLabel.TabIndex = 4;
            timezoneLabel.Text = "-----";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 259);
            Controls.Add(timezoneLabel);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Label timezoneLabel;
    }
}