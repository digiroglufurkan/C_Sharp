namespace harjoitus_4
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.vuosianalb = new System.Windows.Forms.Label();
            this.kuukausinalb = new System.Windows.Forms.Label();
            this.paavinalb = new System.Windows.Forms.Label();
            this.sekunttianalb = new System.Windows.Forms.Label();
            this.minuttianalb = new System.Windows.Forms.Label();
            this.tuntianalb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 120);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(342, 34);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "LASKE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vuosianalb
            // 
            this.vuosianalb.AutoSize = true;
            this.vuosianalb.Location = new System.Drawing.Point(154, 227);
            this.vuosianalb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vuosianalb.Name = "vuosianalb";
            this.vuosianalb.Size = new System.Drawing.Size(65, 28);
            this.vuosianalb.TabIndex = 2;
            this.vuosianalb.Text = "label1";
            this.vuosianalb.Visible = false;
            // 
            // kuukausinalb
            // 
            this.kuukausinalb.AutoSize = true;
            this.kuukausinalb.Location = new System.Drawing.Point(154, 324);
            this.kuukausinalb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kuukausinalb.Name = "kuukausinalb";
            this.kuukausinalb.Size = new System.Drawing.Size(65, 28);
            this.kuukausinalb.TabIndex = 3;
            this.kuukausinalb.Text = "label2";
            this.kuukausinalb.Visible = false;
            // 
            // paavinalb
            // 
            this.paavinalb.AutoSize = true;
            this.paavinalb.Location = new System.Drawing.Point(154, 425);
            this.paavinalb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paavinalb.Name = "paavinalb";
            this.paavinalb.Size = new System.Drawing.Size(65, 28);
            this.paavinalb.TabIndex = 4;
            this.paavinalb.Text = "label3";
            this.paavinalb.Visible = false;
            // 
            // sekunttianalb
            // 
            this.sekunttianalb.AutoSize = true;
            this.sekunttianalb.Location = new System.Drawing.Point(598, 425);
            this.sekunttianalb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sekunttianalb.Name = "sekunttianalb";
            this.sekunttianalb.Size = new System.Drawing.Size(65, 28);
            this.sekunttianalb.TabIndex = 7;
            this.sekunttianalb.Text = "label4";
            this.sekunttianalb.Visible = false;
            // 
            // minuttianalb
            // 
            this.minuttianalb.AutoSize = true;
            this.minuttianalb.Location = new System.Drawing.Point(598, 324);
            this.minuttianalb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minuttianalb.Name = "minuttianalb";
            this.minuttianalb.Size = new System.Drawing.Size(65, 28);
            this.minuttianalb.TabIndex = 6;
            this.minuttianalb.Text = "label5";
            this.minuttianalb.Visible = false;
            // 
            // tuntianalb
            // 
            this.tuntianalb.AutoSize = true;
            this.tuntianalb.Location = new System.Drawing.Point(598, 227);
            this.tuntianalb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuntianalb.Name = "tuntianalb";
            this.tuntianalb.Size = new System.Drawing.Size(65, 28);
            this.tuntianalb.TabIndex = 5;
            this.tuntianalb.Text = "label6";
            this.tuntianalb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 556);
            this.Controls.Add(this.sekunttianalb);
            this.Controls.Add(this.minuttianalb);
            this.Controls.Add(this.tuntianalb);
            this.Controls.Add(this.paavinalb);
            this.Controls.Add(this.kuukausinalb);
            this.Controls.Add(this.vuosianalb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label vuosianalb;
        private Label kuukausinalb;
        private Label paavinalb;
        private Label sekunttianalb;
        private Label minuttianalb;
        private Label tuntianalb;
    }
}