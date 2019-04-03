namespace TelefonRehberiUygulamasi
{
    partial class frmYeniKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKayit));
            this.lblKisiAd = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtBxSoyad = new System.Windows.Forms.TextBox();
            this.lblKisiSoyad = new System.Windows.Forms.Label();
            this.txtBxTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.btnKydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKisiAd
            // 
            this.lblKisiAd.AutoSize = true;
            this.lblKisiAd.Location = new System.Drawing.Point(68, 44);
            this.lblKisiAd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKisiAd.Name = "lblKisiAd";
            this.lblKisiAd.Size = new System.Drawing.Size(64, 23);
            this.lblKisiAd.TabIndex = 0;
            this.lblKisiAd.Text = "Kişi Adı";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.Location = new System.Drawing.Point(73, 88);
            this.txtBoxAd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBoxAd.MaxLength = 30;
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(321, 31);
            this.txtBoxAd.TabIndex = 1;
            // 
            // txtBxSoyad
            // 
            this.txtBxSoyad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxSoyad.Location = new System.Drawing.Point(73, 186);
            this.txtBxSoyad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBxSoyad.MaxLength = 30;
            this.txtBxSoyad.Name = "txtBxSoyad";
            this.txtBxSoyad.Size = new System.Drawing.Size(321, 31);
            this.txtBxSoyad.TabIndex = 3;
            // 
            // lblKisiSoyad
            // 
            this.lblKisiSoyad.AutoSize = true;
            this.lblKisiSoyad.Location = new System.Drawing.Point(68, 157);
            this.lblKisiSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKisiSoyad.Name = "lblKisiSoyad";
            this.lblKisiSoyad.Size = new System.Drawing.Size(90, 23);
            this.lblKisiSoyad.TabIndex = 2;
            this.lblKisiSoyad.Text = "Kişi Soyadı";
            // 
            // txtBxTelNo
            // 
            this.txtBxTelNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxTelNo.Location = new System.Drawing.Point(73, 292);
            this.txtBxTelNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBxTelNo.MaxLength = 25;
            this.txtBxTelNo.Name = "txtBxTelNo";
            this.txtBxTelNo.Size = new System.Drawing.Size(321, 31);
            this.txtBxTelNo.TabIndex = 5;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(68, 264);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(91, 23);
            this.lblTelNo.TabIndex = 4;
            this.lblTelNo.Text = "Telefon No";
            // 
            // btnKydet
            // 
            this.btnKydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKydet.Location = new System.Drawing.Point(273, 372);
            this.btnKydet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnKydet.Name = "btnKydet";
            this.btnKydet.Size = new System.Drawing.Size(125, 41);
            this.btnKydet.TabIndex = 6;
            this.btnKydet.Text = "Kaydet";
            this.btnKydet.UseVisualStyleBackColor = true;
            this.btnKydet.Click += new System.EventHandler(this.btnKydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(433, 372);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 41);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmYeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKydet);
            this.Controls.Add(this.txtBxTelNo);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtBxSoyad);
            this.Controls.Add(this.lblKisiSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.lblKisiAd);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmYeniKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKisiAd;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.TextBox txtBxSoyad;
        private System.Windows.Forms.Label lblKisiSoyad;
        private System.Windows.Forms.TextBox txtBxTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Button btnKydet;
        private System.Windows.Forms.Button btnIptal;
    }
}