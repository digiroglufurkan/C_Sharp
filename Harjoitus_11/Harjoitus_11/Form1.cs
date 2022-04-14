using System;
using System.Drawing;
using System.IO;

namespace Harjoitus_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random randomluku = new Random();
            string  luku = randomluku.Next(1,7).ToString();
            noppaPB1.ImageLocation = Directory.GetCurrentDirectory() + "\\Resources\\dice0" + luku +".png";
            luku = randomluku.Next(1, 7).ToString();
            noppaPB2.ImageLocation = Directory.GetCurrentDirectory() + "\\Resources\\dice0" + luku + ".png";
        }
         
    }
}