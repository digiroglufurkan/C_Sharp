namespace harjoitus_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tulostabtn_Click(object sender, EventArgs e)
        {
            string text = viestiTB.Text;    
            tulostuslb.Text = text;
            tulostuslb.Visible = true;
        }
    }
}