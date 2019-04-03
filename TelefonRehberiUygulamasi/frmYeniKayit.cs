using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberiUygulamasi
{
    public partial class frmYeniKayit : Form
    {
        public Kisi YeniKisi { get; set; }
        public frmYeniKayit()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnKydet_Click(object sender, EventArgs e)
        {
            this.YeniKisi = new Kisi();
            this.YeniKisi.ıd = Guid.NewGuid();
            this.YeniKisi.Ad =this. txtBoxAd.Text;
            this.YeniKisi.Soyad =this. txtBxSoyad.Text;
            this.YeniKisi.TelefonNo = this.txtBxTelNo.Text;
           this. DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
