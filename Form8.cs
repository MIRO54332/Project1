namespace Project1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            double convert = 0;
            if (comboBox1.SelectedItem == "Levas" && comboBox2.SelectedItem == "Dollar")
            {

                convert = i * 0.55;

                label3.Text = "Converted amount:" + $"{convert:F2}";
            }

            else if (comboBox1.SelectedItem == "Dollar" && comboBox2.SelectedItem == "Levas")
            {

                convert = i / 0.55;

                label3.Text = "Converted amount:" + $"{convert:F2}";
            }

            else if (comboBox1.SelectedItem == "Levas" && comboBox2.SelectedItem == "Euro")
            {

                convert = i * 0.51;

                label3.Text = "Converted amount:" + $"{convert:F2}";
            }

            else if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Levas")
            {

                convert = i / 0.51;

                label3.Text = "Converted amount:" + $"{convert:F2}";
            }


            else if (comboBox1.SelectedItem == "Euro" && comboBox2.SelectedItem == "Dollar")
            {

                convert = i * 0.94;

                label3.Text = "Converted amount:" + $"{convert:F2}";
            }

            else if (comboBox1.SelectedItem == "Dollar" && comboBox2.SelectedItem == "Euro")
            {

                convert = i / 0.94;

                label3.Text = "Converted amount:" + $"{convert:F2}";
            }
            else
            {
                label3.Text = "Converted amount:" + i;
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
