namespace Harjoitus_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            char [] luku  = textBox1.Text.ToCharArray();
            luku = luku.Reverse().ToArray();
            string vastaus = "";
            int value = 0;
            string [] romamerkki = { "IVX", "XLC", "CDM", "M  " };
            string[] esi = { "", "a", "aa", "aaa", "ab", "b", "ba", "baa", "baaa", "ac" };
            string muuta = "";
            for (int i = 0; i < luku.Length; i++)
            {
                value = Int32.Parse(luku[i].ToString());
                muuta = esi[value];
                muuta = muuta.Replace('a', romamerkki[i][0]);
                muuta = muuta.Replace('b', romamerkki[i][1]);
                muuta = muuta.Replace('c', romamerkki[i][2]);
                vastaus = muuta + vastaus;
            }
            label3.Text = vastaus;
            label3.Visible = true;
        }
    }
}