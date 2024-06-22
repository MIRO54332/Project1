namespace Project1
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }

        int num;
        int sum = 0;
        private void Start_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(0, 10);
        }

        private void Guess_Click(object sender, EventArgs e)
        {

            sum += 1;
            int guessed = int.Parse(guessnumber.Text);
            if (guessed == num + 2 || guessed == num + 1)
            {
                hltxt.Text = "A little too high ";
                label1.Text = "Attempts:" + sum;
            }
            else if (guessed == num - 1 || guessed == num - 2)
            {
                hltxt.Text = "A little too low";
                label1.Text = "Attempts:" + sum;
            }
            else if (guessed == num)
            {
                hltxt.Text = "Correct" + num;
                sum = 0;
                label1.Text = "Attempts:" + sum;
            }

            else
            {
                if (guessed < num)
                {
                    hltxt.Text = "Too low";
                    label1.Text = "Attempts:" + sum;
                }
                else if (guessed > num)
                {
                    hltxt.Text = "Too high";
                    label1.Text = "Attempts:" + sum;
                }
            }
        }
    }
}
