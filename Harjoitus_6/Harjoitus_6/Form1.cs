namespace Harjoitus_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }



        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if (tunnusTB.Text == "Juri"  && salasanaTB.Text == "Ja@kk0ku1ta")
            {
                OikeinPanel.Visible = true;
                
                
            }
            else
            {
                virheLB.Text = "K‰ytt‰j‰ntunnus tai Salasana on v‰‰rin";
                virheLB.Visible = true;
            }
        }
    }
}