using System;
using System.Diagnostics;
using System.Timers;

namespace harjoitus_15_
{
    public partial class Form1 : Form
    {
        private Stopwatch sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw = new Stopwatch();
            Timer1.Start();
        }
        private void StartBt_Click(object sender, EventArgs e)
        {
            sw.Start();
            

        }
        private void StopBt_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void ResetBt_Click(object sender, EventArgs e)
        {
            sw.Reset();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
             
          timeLB.Text= String.Format("{0:hh\\:mm\\:ss\\:fff}", sw.Elapsed);
        }




    }
}