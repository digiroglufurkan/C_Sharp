namespace harjoitus_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime synty = dateTimePicker1.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synty).TotalDays);
            vuosianalb.Text = Math.Ceiling(erotus / 365.25) + " Vuotta";
            kuukausinalb.Text = Math.Ceiling(erotus * 12 / 365.25) + " Kuukausi";
            paavinalb.Text = Math.Ceiling(erotus) + " Paivaa";
            tuntianalb.Text = Math.Round((nyt - synty).TotalHours).ToString() + " Tuntia"; 
            minuttianalb.Text = Math.Round((nyt - synty).TotalMinutes).ToString() + " Minuttia";
            sekunttianalb.Text= Math.Round((nyt - synty).TotalSeconds).ToString() + " Sekunttia";
            vuosianalb.Visible = true;
            kuukausinalb.Visible = true;
            minuttianalb.Visible=true;
            sekunttianalb.Visible=true;
            tuntianalb.Visible =true;
            paavinalb.Visible=true;
                
                
                }
    }
}