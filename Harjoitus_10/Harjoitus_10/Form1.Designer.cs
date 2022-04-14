namespace Harjoitus_10
{
    partial class BMI_Laskuri
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
            this.tulosLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.piitusTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna Paino :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna Pituus :";
            // 
            // tulosLB
            // 
            this.tulosLB.AutoSize = true;
            this.tulosLB.Location = new System.Drawing.Point(127, 369);
            this.tulosLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tulosLB.Name = "tulosLB";
            this.tulosLB.Size = new System.Drawing.Size(77, 38);
            this.tulosLB.TabIndex = 2;
            this.tulosLB.Text = "tulos";
            this.tulosLB.Visible = false;
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(356, 62);
            this.painoTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(231, 43);
            this.painoTB.TabIndex = 3;
            // 
            // piitusTB
            // 
            this.piitusTB.Location = new System.Drawing.Point(356, 139);
            this.piitusTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.piitusTB.Name = "piitusTB";
            this.piitusTB.Size = new System.Drawing.Size(231, 43);
            this.piitusTB.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(334, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Laske Painoindeksi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kuvausLB
            // 
            this.kuvausLB.AutoSize = true;
            this.kuvausLB.Location = new System.Drawing.Point(127, 430);
            this.kuvausLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kuvausLB.Name = "kuvausLB";
            this.kuvausLB.Size = new System.Drawing.Size(102, 38);
            this.kuvausLB.TabIndex = 6;
            this.kuvausLB.Text = "kuvaus";
            this.kuvausLB.Visible = false;
            // 
            // BMI_Laskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 511);
            this.Controls.Add(this.kuvausLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.piitusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.tulosLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BMI_Laskuri";
            this.Text = "BMI Laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label tulosLB;
        private TextBox painoTB;
        private TextBox piitusTB;
        private Button button1;
        private Label kuvausLB;
    }
}