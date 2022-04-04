namespace Harjoitus_6
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.OikeinPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.virheLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.tunnusTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.tunnusLB = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.OikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.OikeinPanel);
            this.SalasanaPanel.Controls.Add(this.virheLB);
            this.SalasanaPanel.Controls.Add(this.tarkistaBT);
            this.SalasanaPanel.Controls.Add(this.salasanaTB);
            this.SalasanaPanel.Controls.Add(this.tunnusTB);
            this.SalasanaPanel.Controls.Add(this.salasanaLB);
            this.SalasanaPanel.Controls.Add(this.tunnusLB);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(780, 336);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // OikeinPanel
            // 
            this.OikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.OikeinPanel.Controls.Add(this.label1);
            this.OikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.OikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.OikeinPanel.Name = "OikeinPanel";
            this.OikeinPanel.Size = new System.Drawing.Size(780, 336);
            this.OikeinPanel.TabIndex = 6;
            this.OikeinPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetulua Sivilleni";
            // 
            // virheLB
            // 
            this.virheLB.AutoSize = true;
            this.virheLB.Location = new System.Drawing.Point(291, 241);
            this.virheLB.Name = "virheLB";
            this.virheLB.Size = new System.Drawing.Size(61, 36);
            this.virheLB.TabIndex = 5;
            this.virheLB.Text = "Virhe";
            this.virheLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.tarkistaBT.Location = new System.Drawing.Point(141, 188);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(99, 49);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(328, 120);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(228, 43);
            this.salasanaTB.TabIndex = 3;
            // 
            // tunnusTB
            // 
            this.tunnusTB.Location = new System.Drawing.Point(325, 56);
            this.tunnusTB.Name = "tunnusTB";
            this.tunnusTB.Size = new System.Drawing.Size(231, 43);
            this.tunnusTB.TabIndex = 2;
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Location = new System.Drawing.Point(131, 117);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(97, 36);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana";
            // 
            // tunnusLB
            // 
            this.tunnusLB.AutoSize = true;
            this.tunnusLB.Location = new System.Drawing.Point(131, 59);
            this.tunnusLB.Name = "tunnusLB";
            this.tunnusLB.Size = new System.Drawing.Size(160, 36);
            this.tunnusLB.TabIndex = 0;
            this.tunnusLB.Text = "Käyttäjäntunnus";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 336);
            this.Controls.Add(this.SalasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasana Tarkastus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.OikeinPanel.ResumeLayout(false);
            this.OikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaPanel;
        private Label salasanaLB;
        private Label tunnusLB;
        private Label virheLB;
        private Button tarkistaBT;
        private TextBox salasanaTB;
        private TextBox tunnusTB;
        private Panel OikeinPanel;
        private Label label1;
    }
}