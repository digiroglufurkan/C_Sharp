namespace Harjoitus_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.nesteetTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VakutusTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.muukuulutTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.polttonestteTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.KilometritTB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton Kustannuslaskuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennykset korkoineen";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(307, 170);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(125, 27);
            this.LainaTB.TabIndex = 2;
            // 
            // nesteetTB
            // 
            this.nesteetTB.Location = new System.Drawing.Point(307, 229);
            this.nesteetTB.Name = "nesteetTB";
            this.nesteetTB.Size = new System.Drawing.Size(125, 27);
            this.nesteetTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lisättävät nesteet  yms";
            // 
            // VakutusTB
            // 
            this.VakutusTB.Location = new System.Drawing.Point(307, 289);
            this.VakutusTB.Name = "VakutusTB";
            this.VakutusTB.Size = new System.Drawing.Size(125, 27);
            this.VakutusTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vaakutusmaksut";
            // 
            // muukuulutTB
            // 
            this.muukuulutTB.Location = new System.Drawing.Point(307, 363);
            this.muukuulutTB.Name = "muukuulutTB";
            this.muukuulutTB.Size = new System.Drawing.Size(125, 27);
            this.muukuulutTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Muu kuulut";
            // 
            // polttonestteTB
            // 
            this.polttonestteTB.Location = new System.Drawing.Point(307, 421);
            this.polttonestteTB.Name = "polttonestteTB";
            this.polttonestteTB.Size = new System.Drawing.Size(125, 27);
            this.polttonestteTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Polttonestte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kilometrit /vuosi";
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(691, 289);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(125, 27);
            this.RenkaatTB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Renkaat";
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(691, 225);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(125, 27);
            this.HuollotTB.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Huollot";
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(691, 170);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(125, 27);
            this.PesutTB.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pesut";
            // 
            // KilometritTB
            // 
            this.KilometritTB.FormattingEnabled = true;
            this.KilometritTB.Items.AddRange(new object[] {
            "10.000",
            "20.000",
            "30.000",
            "40.000",
            "50.000",
            "60.000",
            "70.000",
            "80.000",
            "90.000",
            "100.000"});
            this.KilometritTB.Location = new System.Drawing.Point(691, 362);
            this.KilometritTB.Name = "KilometritTB";
            this.KilometritTB.Size = new System.Drawing.Size(151, 28);
            this.KilometritTB.TabIndex = 18;
            this.KilometritTB.SelectedIndexChanged += new System.EventHandler(this.KilometritTB_SelectedIndexChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(100, 505);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(58, 20);
            this.VastausLB.TabIndex = 19;
            this.VastausLB.Text = "label11";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 554);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KilometritTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.polttonestteTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.muukuulutTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VakutusTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nesteetTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LainaTB;
        private TextBox nesteetTB;
        private Label label3;
        private TextBox VakutusTB;
        private Label label4;
        private TextBox muukuulutTB;
        private Label label5;
        private TextBox polttonestteTB;
        private Label label6;
        private Label label7;
        private TextBox RenkaatTB;
        private Label label8;
        private TextBox HuollotTB;
        private Label label9;
        private TextBox PesutTB;
        private Label label10;
        private ComboBox KilometritTB;
        private Label VastausLB;
    }
}