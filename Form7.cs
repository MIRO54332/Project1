namespace Project1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city;
            if (listBox1.SelectedIndex != 0)
            {
                city = listBox1.SelectedItem.ToString();


                switch (city)
                {
                    case "Dawson":
                        timezoneLabel.Text = "Mountain"; break;
                    case "Los Angeles":
                        timezoneLabel.Text = "Pacific"; break;
                    case "Romania":
                        timezoneLabel.Text = "Eastern European time"; break;
                    case "New York":
                        timezoneLabel.Text = "Central American time"; break;
                    case "San Francisko":
                        timezoneLabel.Text = "Eastern American time"; break;
                    case "Germany":
                        timezoneLabel.Text = "Central European time"; break;
                    case "Portugal":
                        timezoneLabel.Text = "Western European time"; break;


                }


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
