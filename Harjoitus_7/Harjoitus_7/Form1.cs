namespace Harjoitus_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilometritTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakutuus, pesut, huollot, renkaat, muut, polttanesteet, kustanukset, kilometri;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            vakutuus=Convert.ToDouble(VakutusTB.Text);
            pesut=Convert.ToDouble(PesutTB.Text);
            huollot=Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut =Convert.ToDouble(muukuulutTB.Text);
            polttanesteet = Convert.ToDouble(polttonestteTB.Text);
            kilometri = Convert.ToDouble(KilometritTB.Text);
            kustanukset = (laina +nesteet+vakutuus+pesut+huollot+renkaat+muut+polttanesteet)/(kilometri/12);
            VastausLB.Text = "Kustannukset kilometriä kohta ovat:  " + Math.Round(kustanukset,2);
            VastausLB.Visible = true;
        }
    }
}