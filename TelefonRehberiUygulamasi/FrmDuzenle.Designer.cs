namespace TelefonRehberiUygulamasi
{
    partial class FrmDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuzenle));
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKydet = new System.Windows.Forms.Button();
            this.txtBxTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtBxSoyad = new System.Windows.Forms.TextBox();
            this.lblKisiSoyad = new System.Windows.Forms.Label();
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.lblKisiAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(558, 417);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 41);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKydet
            // 
            this.btnKydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKydet.Location = new System.Drawing.Point(385, 417);
            this.btnKydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKydet.Name = "btnKydet";
            this.btnKydet.Size = new System.Drawing.Size(125, 41);
            this.btnKydet.TabIndex = 14;
            this.btnKydet.Text = "Kaydet";
            this.btnKydet.UseVisualStyleBackColor = true;
            this.btnKydet.Click += new System.EventHandler(this.btnKydet_Click);
            // 
            // txtBxTelNo
            // 
            this.txtBxTelNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxTelNo.Location = new System.Drawing.Point(52, 275);
            this.txtBxTelNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxTelNo.MaxLength = 25;
            this.txtBxTelNo.Name = "txtBxTelNo";
            this.txtBxTelNo.Size = new System.Drawing.Size(321, 31);
            this.txtBxTelNo.TabIndex = 13;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(47, 247);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(60, 13);
            this.lblTelNo.TabIndex = 12;
            this.lblTelNo.Text = "Telefon No";
            // 
            // txtBxSoyad
            // 
            this.txtBxSoyad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxSoyad.Location = new System.Drawing.Point(52, 169);
            this.txtBxSoyad.Margin = new System.Windows.Forms.Padding(5);
            this.txtBxSoyad.MaxLength = 30;
            this.txtBxSoyad.Name = "txtBxSoyad";
            this.txtBxSoyad.Size = new System.Drawing.Size(321, 31);
            this.txtBxSoyad.TabIndex = 11;
            // 
            // lblKisiSoyad
            // 
            this.lblKisiSoyad.AutoSize = true;
            this.lblKisiSoyad.Location = new System.Drawing.Point(47, 140);
            this.lblKisiSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKisiSoyad.Name = "lblKisiSoyad";
            this.lblKisiSoyad.Size = new System.Drawing.Size(58, 13);
            this.lblKisiSoyad.TabIndex = 10;
            this.lblKisiSoyad.Text = "Kişi Soyadı";
            // 
            // txtBoxAd
            // 
            this.txtBoxAd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAd.Location = new System.Drawing.Point(52, 71);
            this.txtBoxAd.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxAd.MaxLength = 30;
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Size = new System.Drawing.Size(321, 31);
            this.txtBoxAd.TabIndex = 9;
            // 
            // lblKisiAd
            // 
            this.lblKisiAd.AutoSize = true;
            this.lblKisiAd.Location = new System.Drawing.Point(47, 27);
            this.lblKisiAd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKisiAd.Name = "lblKisiAd";
            this.lblKisiAd.Size = new System.Drawing.Size(41, 13);
            this.lblKisiAd.TabIndex = 8;
            this.lblKisiAd.Text = "Kişi Adı";
            // 
            // FrmDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 492);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKydet);
            this.Controls.Add(this.txtBxTelNo);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtBxSoyad);
            this.Controls.Add(this.lblKisiSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.Controls.Add(this.lblKisiAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Düzenleme";
            this.Load += new System.EventHandler(this.FrmDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKydet;
        private System.Windows.Forms.TextBox txtBxTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtBxSoyad;
        private System.Windows.Forms.Label lblKisiSoyad;
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.Label lblKisiAd;
    }
}