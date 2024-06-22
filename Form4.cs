namespace Project1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int timeleft = 60;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            timerLabel.Text = timeleft + " seconds";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft -= 1;
                timerLabel.Text = timeleft + " seconds";

            }
            else
            {
                timer.Stop();
                timerLabel.Text = "Time is up";

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            timeleft += 5;
            timerLabel.Text = timeleft.ToString();
            timerLabel.Text = timeleft + " seconds";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            timeleft -= 5;
            timerLabel.Text = timeleft.ToString();
            timerLabel.Text = timeleft + " seconds";
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeleft += 10;
            timerLabel.Text = timeleft.ToString();
            timerLabel.Text = timeleft + " seconds";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeleft -= 10;
            timerLabel.Text = timeleft.ToString();
            timerLabel.Text = timeleft + " seconds";
        }
    }
}
