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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet ds = new DataSet();

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit frm = new frmYeniKayit();
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc==System.Windows.Forms.DialogResult.OK)
            {
                Kisi yenikisi = frm.YeniKisi;

                DataTable dt = this.dataGridView1.DataSource as DataTable;

                DataRow dr = dt.NewRow();
                dr[0] = yenikisi.ıd;
                dr[1] = yenikisi.Ad;
                dr[2] = yenikisi.Soyad;
                dr[3] = yenikisi.TelefonNo;

                dt.Rows.Add(dr);
                this.KayitSayisiHesaplama();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable("Kişiler");
            //DataColumn dcId = new DataColumn("ID");
            //DataColumn dcAd = new DataColumn("Ad");
            //DataColumn dcSoyad = new DataColumn("Soyad");
            //DataColumn dcTelNo = new DataColumn("TelefonNo");
            //dt.Columns.Add(dcId);
            //dt.Columns.Add(dcAd);
            //dt.Columns.Add(dcSoyad);
            //dt.Columns.Add(dcTelNo);
            //ds.Tables.Add(dt);
            //this.dataGridView1.DataSource = dt;
            this.VerileriYukle();
         
            }

        private void VerileriYukle()
        {
            ds.Tables.Clear();
            ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);
            if (ds.Tables.Count > 0)
            {
                this.dataGridView1.DataSource = ds.Tables[0];
                this.KayitSayisiHesaplama();
                this.lblSonİslembilgi.Text = "Yeni Kayıt Eklendi.";
            }
    }

        private void BtnKayitDüzenleme_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow!=null)
            {
                

                FrmDuzenle frm = new FrmDuzenle();

                frm.GuncellenecekKisi = new Kisi();
                frm.GuncellenecekKisi.Ad = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.GuncellenecekKisi.Soyad = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.GuncellenecekKisi.TelefonNo = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();


                DialogResult sonuc = frm.ShowDialog();

                if (sonuc==System.Windows.Forms.DialogResult.OK)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow dr = drv.Row;

                    dr[1] = frm.GuncellenecekKisi.Ad;
                    dr[2] = frm.GuncellenecekKisi.Soyad;
                    dr[3] = frm.GuncellenecekKisi.TelefonNo;
                    this.KayitSayisiHesaplama();
                    this.lblSonİslembilgi.Text = "Kayıt düzenlendi.";
                }

            }
        }

        private void btnKayitSilme_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow!=null)
            {
                DialogResult sonuc = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?","Kayıt Silme İşlemi",MessageBoxButtons.YesNoCancel);
                if (sonuc==System.Windows.Forms.DialogResult.Yes)
                {
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow dr = drv.Row;
                    dr.Delete();
                    this.KayitSayisiHesaplama();
                    this.lblSonİslembilgi.Text = "Kayıt Silindi.";
                }
            }

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            ds.WriteXml(Application.StartupPath + "\\" + "data.xml", XmlWriteMode.WriteSchema);
            this.lblSonİslembilgi.Text = "Veriler kayıt edildi.";
        }

        private void KayitSayisiHesaplama()
        {
            this.lblKayitSayisi.Text = "Kayıt Sayısı:" + this.dataGridView1.RowCount.ToString();
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            this.lblSaat.Text = DateTime.Now.ToShortTimeString();
        }


        private void menuYenileme_Click(object sender, EventArgs e)
        {
            this.VerileriYukle();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuProgram_Click(object sender, EventArgs e)
        {
            FrmHakkinda frm = new FrmHakkinda();
            frm.ShowDialog();
        }
    }
}
