namespace Project1
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            dayLabel = new Label();
            timeLabel = new Label();
            amLabel = new Label();
            yearLabel = new Label();
            dateLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // dayLabel
            // 
            dayLabel.Location = new Point(62, 236);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(86, 30);
            dayLabel.TabIndex = 0;
            dayLabel.Text = "label1";
            dayLabel.Click += dayLabel_Click;
            // 
            // timeLabel
            // 
            timeLabel.Location = new Point(72, 28);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(92, 37);
            timeLabel.TabIndex = 1;
            timeLabel.Text = "label2";
            timeLabel.Click += timeLabel_Click;
            // 
            // amLabel
            // 
            amLabel.Location = new Point(98, 73);
            amLabel.Name = "amLabel";
            amLabel.Size = new Size(66, 37);
            amLabel.TabIndex = 2;
            amLabel.Text = "label3";
            amLabel.Click += amLabel_Click;
            // 
            // yearLabel
            // 
            yearLabel.Location = new Point(64, 184);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(94, 37);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "label4";
            // 
            // dateLabel
            // 
            dateLabel.Location = new Point(72, 127);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(92, 28);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "label6";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 16);
            label1.Name = "label1";
            label1.Size = new Size(64, 52);
            label1.TabIndex = 6;
            label1.Text = "Time:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 65);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 7;
            label2.Text = "AM / PM: ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 172);
            label3.Name = "label3";
            label3.Size = new Size(56, 52);
            label3.TabIndex = 8;
            label3.Text = "Year: ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2, 115);
            label4.Name = "label4";
            label4.Size = new Size(64, 40);
            label4.TabIndex = 9;
            label4.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(2, 224);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 10;
            label5.Text = "Day:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 281);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateLabel);
            Controls.Add(yearLabel);
            Controls.Add(amLabel);
            Controls.Add(timeLabel);
            Controls.Add(dayLabel);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayLabel;
        private Label timeLabel;
        private Label amLabel;
        private Label yearLabel;
        private Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}