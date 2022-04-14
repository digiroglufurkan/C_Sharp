namespace Harjoitus_11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.noppaPB1 = new System.Windows.Forms.PictureBox();
            this.noppaPB2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppaPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaPB2)).BeginInit();
            this.SuspendLayout();
            // 
            // noppaPB1
            // 
            this.noppaPB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noppaPB1.BackgroundImage")));
            this.noppaPB1.Image = global::Harjoitus_11.Properties.Resources.dice06;
            this.noppaPB1.Location = new System.Drawing.Point(147, 104);
            this.noppaPB1.Name = "noppaPB1";
            this.noppaPB1.Size = new System.Drawing.Size(286, 283);
            this.noppaPB1.TabIndex = 0;
            this.noppaPB1.TabStop = false;
            // 
            // noppaPB2
            // 
            this.noppaPB2.Image = global::Harjoitus_11.Properties.Resources.dice05;
            this.noppaPB2.Location = new System.Drawing.Point(487, 104);
            this.noppaPB2.Name = "noppaPB2";
            this.noppaPB2.Size = new System.Drawing.Size(287, 283);
            this.noppaPB2.TabIndex = 1;
            this.noppaPB2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(282, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 111);
            this.button1.TabIndex = 2;
            this.button1.Text = "Heitä";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noppaPB2);
            this.Controls.Add(this.noppaPB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noppaPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaPB2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox noppaPB1;
        private PictureBox noppaPB2;
        private Button button1;
    }
}