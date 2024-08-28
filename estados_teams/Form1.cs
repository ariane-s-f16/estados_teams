namespace estados_teams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //botão remover tds os estados
            if (cboEstados.SelectedIndex != -1)
            {
                string estado = comboBox1.SelectedItem.ToString();


                // comboBox2= norte; comboBox1= total
                if (estado == "Acre" || estado == "Amazonas" || estado == "Pará" ||
                    estado == "Roraima" || estado == "Rondônia" || estado == "Tocantins" ||
                    estado == "Amapá")
                {

                    comboBox2.Items.Add(comboBox1.SelectedItem);
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    counttotal.Text = comboBox1.Items.Count.ToString();
                    counttxtnorte.Text = comboBox2.Items.Count.ToString();
                }


                // comboBox3= Nordeste; comboBox1= total
                if (estado == "Alagoas" || estado == "Bahia" || estado == "Ceará" ||
                     estado == "Maranhão" || estado == "Paraíba" || estado == "Pernambuco" ||
                     estado == "Piauí" || estado == "Rio Grande do Norte")
                {
                    comboBox3.Items.Add(comboBox1.SelectedItem);
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    counttotal.Text = comboBox1.Items.Count.ToString();
                    counttxtnordeste.Text = comboBox3.Items.Count.ToString();
                }



               //comboBox4= centro oeste; comboBox1= total

                if (estado == "Distrito Federal" || estado == "Goiás" ||
         estado == "Mato Grosso" || estado == "Mato Grosso do Sul")
                {
                    ComboBox4.Items.Add(comboBox1.SelectedItem);
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    counttotal.Text = comboBox1.Items.Count.ToString();
                    counttxtcentro.Text = comboBox4.Items.Count.ToString();
                }




                //comboBox5= sudeste; comboBox1= total
                if (estado == "Espírito Santo" || estado == "Minas Gerais" ||
         estado == "Rio de Janeiro" || estado == "São Paulo")
                {
                    comboBox5.Items.Add(comboBox1.SelectedItem);
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    counttotal.Text = cboEstados.Items.Count.ToString();
                    counttxtsudeste.Text = comboBox5.Items.Count.ToString();
                }

                
                //comboBox6= sul; comboBox1= total
                if (estado == "Paraná" || estado == "Santa Catarina" ||
         estado == "Rio Grande do Sul")
                {
                    comboBox6.Items.Add(comboBox1.SelectedItem);
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    counttotal.Text = comboBox1.Items.Count.ToString();
                    counttxtsul.Text = comboBox6.Items.Count.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { //botão remover norte
        
            if(comboBox2.SelectedIndex != -1)
            {
                comboBox1.Items.Add(comboBox1.SelectedItem);
                comboBox2.Items.Remove(comboBox2.SelectedItem);
                counttotal.Text = comboBox1.Items.Count.ToString();
                counttxtnorte.Text = comboBox2.Items.Count.ToString();
                
                comboBox2.ResetText();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        { //botão remover nordeste
            
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox1.Items.Add(comboBox1.SelectedItem);
                comboBox3.Items.Remove(comboBox3.SelectedItem);
                counttotal.Text = comboBox1.Items.Count.ToString();
                counttxtnordeste.Text = comboBox3.Items.Count.ToString();
                
                comboBox3.ResetText();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { //botão remover centro oeste
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox1.Items.Add(comboBox1.SelectedItem);
                comboBox4.Items.Remove(comboBox4.SelectedItem);
                counttotal.Text = comboBox1.Items.Count.ToString();
                counttxtcentro.Text = comboBox4.Items.Count.ToString();
                
                comboBox4.ResetText();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        { //botão remover sudeste

            if (comboBox3.SelectedIndex != -1)
            {
                comboBox1.Items.Add(comboBox1.SelectedItem);
                comboBox5.Items.Remove(comboBox5.SelectedItem);
                counttotal.Text = comboBox1.Items.Count.ToString();
                counttxtsudeste.Text = comboBox5.Items.Count.ToString();
                
                comboBox3.ResetText();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        //botão remover sul
            if (comboBox3.SelectedIndex != -1)
            {
                comboBox1.Items.Add(comboBox1.SelectedItem);
                comboBox6.Items.Remove(comboBox6.SelectedItem);
                counttotal.Text = comboBox1.Items.Count.ToString();
                counttxtsul.Text = comboBox6.Items.Count.ToString();
                
                comboBox6.ResetText();
            }
        }
    }
}
