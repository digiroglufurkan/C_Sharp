namespace harjoitus_2
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
            this.otsikkolb = new System.Windows.Forms.Label();
            this.tulostuslb = new System.Windows.Forms.Label();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.tulostabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkolb
            // 
            this.otsikkolb.AutoSize = true;
            this.otsikkolb.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkolb.Location = new System.Drawing.Point(39, 87);
            this.otsikkolb.Name = "otsikkolb";
            this.otsikkolb.Size = new System.Drawing.Size(375, 44);
            this.otsikkolb.TabIndex = 0;
            this.otsikkolb.Text = "anna tulostettava teksti:";
            // 
            // tulostuslb
            // 
            this.tulostuslb.AutoSize = true;
            this.tulostuslb.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulostuslb.Location = new System.Drawing.Point(84, 151);
            this.tulostuslb.Name = "tulostuslb";
            this.tulostuslb.Size = new System.Drawing.Size(96, 44);
            this.tulostuslb.TabIndex = 1;
            this.tulostuslb.Text = "xxxx";
            this.tulostuslb.Visible = false;
            // 
            // viestiTB
            // 
            this.viestiTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viestiTB.Location = new System.Drawing.Point(420, 83);
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(355, 43);
            this.viestiTB.TabIndex = 2;
            // 
            // tulostabtn
            // 
            this.tulostabtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostabtn.ForeColor = System.Drawing.Color.DimGray;
            this.tulostabtn.Location = new System.Drawing.Point(420, 160);
            this.tulostabtn.Name = "tulostabtn";
            this.tulostabtn.Size = new System.Drawing.Size(165, 29);
            this.tulostabtn.TabIndex = 3;
            this.tulostabtn.Text = "Tulosta texti";
            this.tulostabtn.UseVisualStyleBackColor = true;
            this.tulostabtn.Click += new System.EventHandler(this.tulostabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulostabtn);
            this.Controls.Add(this.viestiTB);
            this.Controls.Add(this.tulostuslb);
            this.Controls.Add(this.otsikkolb);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkolb;
        private Label tulostuslb;
        private TextBox viestiTB;
        private Button tulostabtn;
    }
}