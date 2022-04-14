namespace Harjoitus_12
{
    public partial class Form1 : Form
    {
        string [] vastaukset = new string [10];
        string[] oikeinvastaukset = { "A", "C", "D", "B", "C", "D", "C", "A", "B", "D" };
        int tulos = 0;
        int  laskuri = 0;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;

            if (laskuri == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (vastaukset[i] == oikeinvastaukset[i])
                    {
                        tulos++;
                    }
                    vastausLB.Text = "Oikeitä vastaus oli : " + tulos.ToString();
                    //vastausLB.Text = vastaukset.ToString();
                    vastausLB.Visible = true;
                    radioButtonA.Enabled = false;
                    radioButtonB.Enabled = false;
                    radioButtonC.Enabled = false;
                    radioButtonD.Enabled = false;
                }
            }
            else
            {
                vastaukset[laskuri ] = rd.Text;
                laskuri++;
                kysysmysLB.Text = "Vastaus " + laskuri + " Kysymykseen";
            }
            tyhjaaa();
        }
        private void tyhjaaa()
        {
            if (radioButtonA.Checked == true)
            {
                radioButtonA.Checked = false;
                laskuri --;
            }
            if (radioButtonB.Checked == true)
            {
                radioButtonB.Checked = false;
                laskuri--;
            }
            if (radioButtonC.Checked == true)
            {
                radioButtonC.Checked = false;
                laskuri--;
            }
            if (radioButtonD.Checked == true)
            {
                radioButtonD.Checked = false;
                laskuri--;
            }

        }
    }
}