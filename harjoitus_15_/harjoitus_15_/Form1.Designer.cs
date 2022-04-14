namespace harjoitus_15_
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
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLB = new System.Windows.Forms.Label();
            this.StartBt = new System.Windows.Forms.Button();
            this.StopBt = new System.Windows.Forms.Button();
            this.ResetBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLB.Location = new System.Drawing.Point(75, 60);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(730, 159);
            this.timeLB.TabIndex = 0;
            this.timeLB.Text = "00:00:00:000";
            // 
            // StartBt
            // 
            this.StartBt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBt.Location = new System.Drawing.Point(111, 281);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(125, 49);
            this.StartBt.TabIndex = 1;
            this.StartBt.Text = "Start";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // StopBt
            // 
            this.StopBt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBt.Location = new System.Drawing.Point(377, 281);
            this.StopBt.Name = "StopBt";
            this.StopBt.Size = new System.Drawing.Size(125, 49);
            this.StopBt.TabIndex = 2;
            this.StopBt.Text = "Stop";
            this.StopBt.UseVisualStyleBackColor = true;
            this.StopBt.Click += new System.EventHandler(this.StopBt_Click);
            // 
            // ResetBt
            // 
            this.ResetBt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetBt.Location = new System.Drawing.Point(659, 281);
            this.ResetBt.Name = "ResetBt";
            this.ResetBt.Size = new System.Drawing.Size(125, 49);
            this.ResetBt.TabIndex = 3;
            this.ResetBt.Text = "Reset";
            this.ResetBt.UseVisualStyleBackColor = true;
            this.ResetBt.Click += new System.EventHandler(this.ResetBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 392);
            this.Controls.Add(this.ResetBt);
            this.Controls.Add(this.StopBt);
            this.Controls.Add(this.StartBt);
            this.Controls.Add(this.timeLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private Label timeLB;
        private Button StartBt;
        private Button StopBt;
        private Button ResetBt;
    }
}