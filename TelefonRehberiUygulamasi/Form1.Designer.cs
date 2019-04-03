namespace TelefonRehberiUygulamasi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuİslem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeniKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKayitDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKayitSilme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuYenileme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKayitSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSonİslembilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.btnYeniKayit = new System.Windows.Forms.ToolStripButton();
            this.BtnKayitDüzenleme = new System.Windows.Forms.ToolStripButton();
            this.btnKayitSilme = new System.Windows.Forms.ToolStripButton();
            this.btnKayit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuİslem,
            this.menuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKaydet,
            this.menuCikis});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuCikis.Size = new System.Drawing.Size(182, 22);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // menuDuzen
            // 
            this.menuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKes,
            this.menuKopyala,
            this.toolStripMenuItem1,
            this.menuYapistir});
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(52, 20);
            this.menuDuzen.Text = "Düzen";
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(158, 22);
            this.menuKes.Text = "Kes";
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopyala.Size = new System.Drawing.Size(158, 22);
            this.menuKopyala.Text = "Kopyala";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(158, 22);
            this.menuYapistir.Text = "Yapıştır";
            // 
            // menuİslem
            // 
            this.menuİslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeniKayit,
            this.menuKayitDuzen,
            this.toolStripMenuItem2,
            this.menuKayitSilme,
            this.toolStripMenuItem3,
            this.menuYenileme});
            this.menuİslem.Name = "menuİslem";
            this.menuİslem.Size = new System.Drawing.Size(47, 20);
            this.menuİslem.Text = "İşlem";
            // 
            // menuYeniKayit
            // 
            this.menuYeniKayit.Name = "menuYeniKayit";
            this.menuYeniKayit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuYeniKayit.Size = new System.Drawing.Size(204, 22);
            this.menuYeniKayit.Text = "Yeni Kayıt";
            this.menuYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // menuKayitDuzen
            // 
            this.menuKayitDuzen.Name = "menuKayitDuzen";
            this.menuKayitDuzen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuKayitDuzen.Size = new System.Drawing.Size(204, 22);
            this.menuKayitDuzen.Text = "Kayıt Düzenleme";
            this.menuKayitDuzen.Click += new System.EventHandler(this.BtnKayitDüzenleme_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // menuKayitSilme
            // 
            this.menuKayitSilme.Name = "menuKayitSilme";
            this.menuKayitSilme.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKayitSilme.Size = new System.Drawing.Size(204, 22);
            this.menuKayitSilme.Text = "Kayıt Silme";
            this.menuKayitSilme.Click += new System.EventHandler(this.btnKayitSilme_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 6);
            // 
            // menuYenileme
            // 
            this.menuYenileme.Name = "menuYenileme";
            this.menuYenileme.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuYenileme.Size = new System.Drawing.Size(204, 22);
            this.menuYenileme.Text = "Yenileme";
            this.menuYenileme.Click += new System.EventHandler(this.menuYenileme_Click);
            // 
            // menuHakkinda
            // 
            this.menuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYardim,
            this.toolStripMenuItem4,
            this.menuProgram});
            this.menuHakkinda.Name = "menuHakkinda";
            this.menuHakkinda.Size = new System.Drawing.Size(69, 20);
            this.menuHakkinda.Text = "Hakkında";
            // 
            // menuYardim
            // 
            this.menuYardim.Name = "menuYardim";
            this.menuYardim.Size = new System.Drawing.Size(146, 22);
            this.menuYardim.Text = "Yardım";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 6);
            // 
            // menuProgram
            // 
            this.menuProgram.Name = "menuProgram";
            this.menuProgram.Size = new System.Drawing.Size(146, 22);
            this.menuProgram.Text = "Program Bilgi";
            this.menuProgram.Click += new System.EventHandler(this.menuProgram_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.lblKayitSayisi,
            this.lblSonİslembilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaat
            // 
            this.lblSaat.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSaat.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(33, 19);
            this.lblSaat.Text = "Saat";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblKayitSayisi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(69, 19);
            this.lblKayitSayisi.Text = "Kayıt Sayısı";
            // 
            // lblSonİslembilgi
            // 
            this.lblSonİslembilgi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblSonİslembilgi.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lblSonİslembilgi.Name = "lblSonİslembilgi";
            this.lblSonİslembilgi.Size = new System.Drawing.Size(62, 19);
            this.lblSonİslembilgi.Text = "Son İşlem";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeniKayit,
            this.BtnKayitDüzenleme,
            this.btnKayitSilme,
            this.toolStripSeparator1,
            this.btnKayit,
            this.toolStripSeparator,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 375);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(182, 22);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeniKayit.Image = global::TelefonRehberiUygulamasi.Properties.Resources.ekle128;
            this.btnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(23, 22);
            this.btnYeniKayit.Text = "&New";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // BtnKayitDüzenleme
            // 
            this.BtnKayitDüzenleme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnKayitDüzenleme.Image = global::TelefonRehberiUygulamasi.Properties.Resources.düzenle128;
            this.BtnKayitDüzenleme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKayitDüzenleme.Name = "BtnKayitDüzenleme";
            this.BtnKayitDüzenleme.Size = new System.Drawing.Size(23, 22);
            this.BtnKayitDüzenleme.Text = "&Open";
            this.BtnKayitDüzenleme.Click += new System.EventHandler(this.BtnKayitDüzenleme_Click);
            // 
            // btnKayitSilme
            // 
            this.btnKayitSilme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayitSilme.Image = global::TelefonRehberiUygulamasi.Properties.Resources.sil128;
            this.btnKayitSilme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayitSilme.Name = "btnKayitSilme";
            this.btnKayitSilme.Size = new System.Drawing.Size(23, 22);
            this.btnKayitSilme.Text = "&Open";
            this.btnKayitSilme.Click += new System.EventHandler(this.btnKayitSilme_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnKayit.Image")));
            this.btnKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(23, 22);
            this.btnKayit.Text = "&Save";
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Winforms Örnek Telefon Defteri Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripMenuItem menuİslem;
        private System.Windows.Forms.ToolStripMenuItem menuYeniKayit;
        private System.Windows.Forms.ToolStripMenuItem menuKayitDuzen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuKayitSilme;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuYenileme;
        private System.Windows.Forms.ToolStripMenuItem menuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem menuYardim;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuProgram;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblKayitSayisi;
        private System.Windows.Forms.ToolStripStatusLabel lblSonİslembilgi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeniKayit;
        private System.Windows.Forms.ToolStripButton BtnKayitDüzenleme;
        private System.Windows.Forms.ToolStripButton btnKayitSilme;
        private System.Windows.Forms.ToolStripButton btnKayit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.Timer tmrSaat;
    }
}

