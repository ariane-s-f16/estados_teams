namespace estados_teams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

                txttotal.Text = comboBox1.Items.Count.ToString();

                comboBox1.ResetText();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);

                txtnorte.Text = comboBox2.Items.Count.ToString();

                comboBox2.ResetText();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);

                txtnordeste.Text = comboBox3.Items.Count.ToString();

                comboBox3.ResetText();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                comboBox4.Items.RemoveAt(comboBox4.SelectedIndex);

                txtcentro.Text = comboBox4.Items.Count.ToString();

                comboBox4.ResetText();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {
                comboBox5.Items.RemoveAt(comboBox5.SelectedIndex);

                txtsudeste.Text = comboBox5.Items.Count.ToString();

                comboBox5.ResetText();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex != -1)
            {
                comboBox6.Items.RemoveAt(comboBox6.SelectedIndex);

                txtsul.Text = comboBox6.Items.Count.ToString();

                comboBox6.ResetText();


            }
        }
    }
}
