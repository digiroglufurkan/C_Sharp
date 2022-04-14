namespace harjoitus_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vastaus;
                double ast = Convert.ToDouble( asteetTB.Text);
                if (radioButton_celsius.Checked)
                {
                    vastaus = (ast - 32) / 1.8;
                    vastausLB.Text = ast + "Fahreneit on " + vastaus + " Celsius astetta";
                }
                else if (radioButton_fahrenheit.Checked)
                {
                    vastaus = ast * 1.8 + 32;
                    vastausLB.Text = ast + "Celsius on " + vastaus + " Fahreneit astetta";
                }
                else
                {
                    vastausLB.Text = "Ole hyvä ja valitse muunnettava astetta";
                }
              
            }
            catch (Exception ex)
            {
                vastausLB.Text = "Ole hyvä ja antanut oikea lukua";
            }
        }
    }
}