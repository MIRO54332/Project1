namespace Project1
{
    partial class Form4
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
            resetButton = new Button();
            stopButton = new Button();
            timerLabel = new Label();
            startButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            plusButton = new Button();
            minusButton = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(12, 104);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(245, 22);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += btnStart_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(144, 72);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(113, 22);
            stopButton.TabIndex = 2;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += btnStop_Click;
            // 
            // timerLabel
            // 
            timerLabel.Location = new Point(89, 20);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(180, 50);
            timerLabel.TabIndex = 4;
            timerLabel.Text = "60 seconds";
            timerLabel.Click += timerLabel_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(12, 72);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(115, 22);
            startButton.TabIndex = 5;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(45, 144);
            plusButton.Margin = new Padding(3, 2, 3, 2);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(82, 22);
            plusButton.TabIndex = 6;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(151, 144);
            minusButton.Margin = new Padding(3, 2, 3, 2);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(82, 22);
            minusButton.TabIndex = 7;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(45, 185);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 8;
            button1.Text = "+10";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 185);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 9;
            button2.Text = "-10";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 231);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(startButton);
            Controls.Add(timerLabel);
            Controls.Add(stopButton);
            Controls.Add(resetButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Count down timer";
            ResumeLayout(false);
        }

        #endregion
        private Button resetButton;
        private Button stopButton;
        private Label timerLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer;
        private Button plusButton;
        private Button minusButton;
        private Button button1;
        private Button button2;
    }
}