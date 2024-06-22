namespace Project1
{
    partial class Form3
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
            start = new Button();
            guess = new Button();
            guessnumber = new TextBox();
            hltxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(38, 12);
            start.Name = "start";
            start.Size = new Size(178, 23);
            start.TabIndex = 0;
            start.Text = "Generate random number";
            start.UseVisualStyleBackColor = true;
            start.Click += Start_Click;
            // 
            // guess
            // 
            guess.Location = new Point(244, 12);
            guess.Name = "guess";
            guess.Size = new Size(178, 23);
            guess.TabIndex = 1;
            guess.Text = "guess";
            guess.UseVisualStyleBackColor = true;
            guess.Click += Guess_Click;
            // 
            // guessnumber
            // 
            guessnumber.Location = new Point(71, 41);
            guessnumber.Name = "guessnumber";
            guessnumber.Size = new Size(115, 23);
            guessnumber.TabIndex = 2;
            // 
            // hltxt
            // 
            hltxt.Location = new Point(277, 41);
            hltxt.Name = "hltxt";
            hltxt.Size = new Size(111, 23);
            hltxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(258, 81);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 4;
            label1.Text = "Attempts: ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 109);
            Controls.Add(label1);
            Controls.Add(hltxt);
            Controls.Add(guessnumber);
            Controls.Add(guess);
            Controls.Add(start);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button guess;
        private TextBox guessnumber;
        private TextBox hltxt;
        private Label label1;
    }
}