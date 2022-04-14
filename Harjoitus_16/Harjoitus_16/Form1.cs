namespace Harjoitus_16
{
    public partial class Laskuri : Form
    {
        private int kokoaika;
        public Laskuri()
        {
            InitializeComponent();
        }

        private void Laskuri_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                minuttiCB.Items.Add(i.ToString());
                sekunttiCB.Items.Add(i.ToString());
            }
            minuttiCB.SelectedIndex = 10;
            sekunttiCB.SelectedIndex = 0;
            stopBT.Enabled = false;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            kokoaika = Int32.Parse( minuttiCB.SelectedItem.ToString()) * 60 ;
            kokoaika += Int32.Parse(sekunttiCB.SelectedItem.ToString());
            timer1.Start();
            startBT.Enabled = false;
            stopBT.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kokoaika > 0)
            {
                kokoaika--;
                timeLB.Text = ((kokoaika -(kokoaika%60))/60).ToString() + " : " + (kokoaika % 60).ToString();
            }
            else
            {
                timer1.Stop();
                stopBT.Enabled = false;
                startBT.Enabled = true;
                timeLB.Text = "00 : 00";
                MessageBox.Show("Aikasi Loppui");
                
            }
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            kokoaika = 0;
            timer1.Stop();
            timeLB.Text = "00 : 00";
            stopBT.Enabled = false;
            startBT.Enabled = true;

        }
    }
}