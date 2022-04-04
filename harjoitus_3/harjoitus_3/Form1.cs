namespace harjoitus_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            try
            {
                float x = float.Parse(luku1.Text);
                float y = float.Parse(luku2.Text);
                string merkki = comboBox1.Text;
                switch (merkki)
                {
                    case "+":
                     x = x + y;
                    break;
                    case "-":
                        x = x - y;
                        break;
                    case "*":
                        x = x * y;
                        break;
                    case "/":
                        x = x / y;
                        break;
                }
                label2.Text = x.ToString();

            }
            catch (Exception ex)
            {
                label2.Text = "virhe ";
            }

            

    
        }
    }
}