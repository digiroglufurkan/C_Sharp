namespace harjoitus_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> luvut = new List<int>();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(textBox1.Text == "-999")
                {
                    label2.Text = "";
                    int [] taulukko = luvut.ToArray();
                    Array.Sort(taulukko);
                    foreach(int i in taulukko)
                    {
                        label2.Text += " " + i;
                    }
                    label2.Visible = true;
                }
                else
                {
                    luvut.Add(Int32.Parse(textBox1.Text));
                    textBox1.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                textBox1.Text = "";
            }

        }
    }
}