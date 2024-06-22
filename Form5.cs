namespace Project1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dayLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void amLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dayLabel.Text = DateTime.Now.ToString("dddd");
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            amLabel.Text = DateTime.Now.ToString("tt");
            yearLabel.Text = DateTime.Now.ToString("yyyy");
            dateLabel.Text = DateTime.Now.ToString("MMM:dd");


        }


        private void Form5_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
