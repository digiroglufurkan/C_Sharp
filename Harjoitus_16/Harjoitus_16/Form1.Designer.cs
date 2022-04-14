namespace Harjoitus_16
{
    partial class Laskuri
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
            this.components = new System.ComponentModel.Container();
            this.minuttiCB = new System.Windows.Forms.ComboBox();
            this.sekunttiCB = new System.Windows.Forms.ComboBox();
            this.timeLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuttiCB
            // 
            this.minuttiCB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minuttiCB.FormattingEnabled = true;
            this.minuttiCB.Location = new System.Drawing.Point(101, 107);
            this.minuttiCB.Name = "minuttiCB";
            this.minuttiCB.Size = new System.Drawing.Size(132, 62);
            this.minuttiCB.TabIndex = 0;
            // 
            // sekunttiCB
            // 
            this.sekunttiCB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sekunttiCB.FormattingEnabled = true;
            this.sekunttiCB.Location = new System.Drawing.Point(261, 107);
            this.sekunttiCB.Name = "sekunttiCB";
            this.sekunttiCB.Size = new System.Drawing.Size(128, 62);
            this.sekunttiCB.TabIndex = 1;
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLB.Location = new System.Drawing.Point(111, 193);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(280, 108);
            this.timeLB.TabIndex = 2;
            this.timeLB.Text = "00 : 00";
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBT.Location = new System.Drawing.Point(101, 324);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(107, 61);
            this.startBT.TabIndex = 3;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopBT.Location = new System.Drawing.Point(292, 324);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(107, 61);
            this.stopBT.TabIndex = 4;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minutit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sekuntit";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Laskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.timeLB);
            this.Controls.Add(this.sekunttiCB);
            this.Controls.Add(this.minuttiCB);
            this.Name = "Laskuri";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.Laskuri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox minuttiCB;
        private ComboBox sekunttiCB;
        private Label timeLB;
        private Button startBT;
        private Button stopBT;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}