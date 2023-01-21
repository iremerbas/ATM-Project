namespace Atm_Uygulamasi
{
    partial class atmScreenSelected
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ParaCekme = new System.Windows.Forms.Button();
            this.btn_ParaYatırma = new System.Windows.Forms.Button();
            this.btn_ParaGonderme = new System.Windows.Forms.Button();
            this.btn_Bakiye = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ParaCekme
            // 
            this.btn_ParaCekme.Location = new System.Drawing.Point(66, 46);
            this.btn_ParaCekme.Name = "btn_ParaCekme";
            this.btn_ParaCekme.Size = new System.Drawing.Size(243, 46);
            this.btn_ParaCekme.TabIndex = 0;
            this.btn_ParaCekme.Text = "Para Çekme";
            this.btn_ParaCekme.UseVisualStyleBackColor = true;
            this.btn_ParaCekme.Click += new System.EventHandler(this.btn_ParaCekme_Click);
            // 
            // btn_ParaYatırma
            // 
            this.btn_ParaYatırma.Location = new System.Drawing.Point(66, 121);
            this.btn_ParaYatırma.Name = "btn_ParaYatırma";
            this.btn_ParaYatırma.Size = new System.Drawing.Size(243, 46);
            this.btn_ParaYatırma.TabIndex = 1;
            this.btn_ParaYatırma.Text = "Para Yatırma";
            this.btn_ParaYatırma.UseVisualStyleBackColor = true;
            this.btn_ParaYatırma.Click += new System.EventHandler(this.btn_ParaYatırma_Click);
            // 
            // btn_ParaGonderme
            // 
            this.btn_ParaGonderme.Location = new System.Drawing.Point(66, 191);
            this.btn_ParaGonderme.Name = "btn_ParaGonderme";
            this.btn_ParaGonderme.Size = new System.Drawing.Size(243, 46);
            this.btn_ParaGonderme.TabIndex = 2;
            this.btn_ParaGonderme.Text = "Para Gönderme";
            this.btn_ParaGonderme.UseVisualStyleBackColor = true;
            this.btn_ParaGonderme.Click += new System.EventHandler(this.btn_ParaGonderme_Click);
            // 
            // btn_Bakiye
            // 
            this.btn_Bakiye.Location = new System.Drawing.Point(66, 263);
            this.btn_Bakiye.Name = "btn_Bakiye";
            this.btn_Bakiye.Size = new System.Drawing.Size(243, 46);
            this.btn_Bakiye.TabIndex = 3;
            this.btn_Bakiye.Text = "Bakiye Sorgulama";
            this.btn_Bakiye.UseVisualStyleBackColor = true;
            this.btn_Bakiye.Click += new System.EventHandler(this.btn_Bakiye_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Banka Bakiye Sorgulama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // atmScreenSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Bakiye);
            this.Controls.Add(this.btn_ParaGonderme);
            this.Controls.Add(this.btn_ParaYatırma);
            this.Controls.Add(this.btn_ParaCekme);
            this.Name = "atmScreenSelected";
            this.Text = "atmScreenSelected";
            this.Load += new System.EventHandler(this.atmScreenSelected_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ParaCekme;
        private System.Windows.Forms.Button btn_ParaYatırma;
        private System.Windows.Forms.Button btn_ParaGonderme;
        private System.Windows.Forms.Button btn_Bakiye;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}