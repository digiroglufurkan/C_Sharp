namespace Harjoitus_10
{
    public partial class BMI_Laskuri : Form
    {
        public BMI_Laskuri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double paino = 0;
            double piitus;
            double bmi =0 ;
            try
            {
                paino = Convert.ToDouble(painoTB.Text);
                piitus = Convert.ToDouble(piitusTB.Text.Replace(',', '.'));
                bmi = Math.Round(paino /( piitus*piitus), 2);
            }
            catch (Exception ex)
            {
                tulosLB.Text = "Ole hyvä ja syöttä oikein luvut";
            }
            if(bmi < 18.5 && bmi > 0)
                {
                tulosLB.Text = "Painoindeksisi on:  " + bmi;
                tulosLB.ForeColor = Color.Aqua;
                tulosLB.Visible = true;
                kuvausLB.Text = "Alipaino";
                kuvausLB.ForeColor = Color.Aqua;
                kuvausLB.Visible = true;
            }
           else  if (bmi < 25 && bmi > 0)
            {
                tulosLB.Text = "Painoindeksisi on:  " + bmi;
                tulosLB.ForeColor = Color.Green;
                tulosLB.Visible = true;
                kuvausLB.Text = "Normaali paino";
                kuvausLB.ForeColor = Color.Green;
                kuvausLB.Visible = true;
            }
            else if (bmi < 40 && bmi > 0)
            {
                tulosLB.Text = "Painoindeksisi on:  " + bmi;
                tulosLB.ForeColor = Color.Gold;
                tulosLB.Visible = true;
                kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor = Color.Gold;
                kuvausLB.Visible = true;
            }
            else
            {
                tulosLB.Text = "Painoindeksisi on:  " + bmi;
                tulosLB.ForeColor = Color.Red;
                tulosLB.Visible = true;
                kuvausLB.Text = "Huomattava ylipaino";
                kuvausLB.ForeColor = Color.Red;
                kuvausLB.Visible = true;
            }

        }
    }
}