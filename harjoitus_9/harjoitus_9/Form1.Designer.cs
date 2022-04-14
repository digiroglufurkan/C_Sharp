namespace harjoitus_9
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
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.radioButton_celsius = new System.Windows.Forms.RadioButton();
            this.radioButton_fahrenheit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna Asteet";
            // 
            // asteetTB
            // 
            this.asteetTB.Location = new System.Drawing.Point(268, 215);
            this.asteetTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(165, 43);
            this.asteetTB.TabIndex = 1;
            // 
            // radioButton_celsius
            // 
            this.radioButton_celsius.AutoSize = true;
            this.radioButton_celsius.Location = new System.Drawing.Point(495, 207);
            this.radioButton_celsius.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_celsius.Name = "radioButton_celsius";
            this.radioButton_celsius.Size = new System.Drawing.Size(136, 42);
            this.radioButton_celsius.TabIndex = 2;
            this.radioButton_celsius.TabStop = true;
            this.radioButton_celsius.Text = "Celsisus";
            this.radioButton_celsius.UseVisualStyleBackColor = true;
            // 
            // radioButton_fahrenheit
            // 
            this.radioButton_fahrenheit.AutoSize = true;
            this.radioButton_fahrenheit.Location = new System.Drawing.Point(495, 261);
            this.radioButton_fahrenheit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton_fahrenheit.Name = "radioButton_fahrenheit";
            this.radioButton_fahrenheit.Size = new System.Drawing.Size(169, 42);
            this.radioButton_fahrenheit.TabIndex = 3;
            this.radioButton_fahrenheit.TabStop = true;
            this.radioButton_fahrenheit.Text = "Fahrenheit";
            this.radioButton_fahrenheit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miten muunnat ?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Muunna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(189, 358);
            this.vastausLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(109, 38);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "Vastaus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 493);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_fahrenheit);
            this.Controls.Add(this.radioButton_celsius);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox asteetTB;
        private RadioButton radioButton_celsius;
        private RadioButton radioButton_fahrenheit;
        private Label label2;
        private Button button1;
        private Label vastausLB;
    }
}