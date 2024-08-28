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
            if (cboEstados.SelectedIndex != -1)
            {
                string estado = cboEstados.SelectedItem.ToString();
                //norte
                if (estado == "acre" || estado == "Amazonas" || estado == "pará" ||
                    estado == "roraima" || estado == "rondônia" || estado == "tocantins" ||
                    estado == "amapá")
                {

                    combobox1.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.RemoveAt(cboEstados.SelectedIndex);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countNorte.Text = cboNorte.Items.Count.ToString();
                }
                //nordeste
                if (estado == "Alagoas" || estado == "Bahia" || estado == "Ceará" ||
                     estado == "Maranhão" || estado == "Paraíba" || estado == "Pernambuco" ||
                     estado == "Piauí" || estado == "Rio Grande do Norte")
                {
                    cboNordeste.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countNordeste.Text = cboNordeste.Items.Count.ToString();
                }
                // CEntro Oeste 
                if (estado == "Distrito Federal" || estado == "Goiás" ||
         estado == "Mato Grosso" || estado == "Mato Grosso do Sul")
                {
                    cboCentro.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    CountCentro.Text = cboCentro.Items.Count.ToString();
                }

                //sudeste
                if (estado == "Espírito Santo" || estado == "Minas Gerais" ||
         estado == "Rio de Janeiro" || estado == "São Paulo")
                {
                    cboSudeste.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countSudeste.Text = cboSudeste.Items.Count.ToString();
                }
                //Sul
                if (estado == "Paraná" || estado == "Santa Catarina" ||
         estado == "Rio Grande do Sul")
                {
                    cboSul.Items.Add(cboEstados.SelectedItem);
                    cboEstados.Items.Remove(cboEstados.SelectedItem);
                    countEstados.Text = cboEstados.Items.Count.ToString();
                    countSul.Text = cboSul.Items.Count.ToString();
                }
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
