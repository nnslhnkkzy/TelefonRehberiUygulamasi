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
    public partial class FrmDuzenle : Form
    {
        public Kisi GuncellenecekKisi { get; set; }
        public FrmDuzenle()
        {
            InitializeComponent();
        }

        private void btnKydet_Click(object sender, EventArgs e)
        {
            this.GuncellenecekKisi.Ad = this.txtBoxAd.Text;
            this.GuncellenecekKisi.Soyad = this.txtBxSoyad.Text;
            this.GuncellenecekKisi.TelefonNo = this.txtBxTelNo.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void FrmDuzenle_Load(object sender, EventArgs e)
        {
            if (this.GuncellenecekKisi!=null)
            {
                this.txtBoxAd.Text = this.GuncellenecekKisi.Ad;
                this.txtBxSoyad.Text = this.GuncellenecekKisi.Soyad;
                this.txtBxTelNo.Text = this.GuncellenecekKisi.TelefonNo;
            }
        }
    }
}
