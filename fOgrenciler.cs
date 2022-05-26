using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VtysOdev
{
    public partial class fOgrenciler : Form
    {
        public fOgrenciler()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        tOgrenci ogrenci = new tOgrenci();
        private void bEkle_Click(object sender, EventArgs e)
        {
            
            tOgrenci ogrenci = new tOgrenci();
            ogrenci.ogrenciID = Convert.ToInt32(tId.Text);
            ogrenci.ad = tAd.Text;
            ogrenci.soyad = tSoyad.Text;
            ogrenci.bolumID = Convert.ToInt32(tBolumId.Text);
            con.tOgrenci.Add(ogrenci);
            con.SaveChanges();
            MessageBox.Show("Kayıt Tamamlandı!");
            temizle();
            dataGridView1.DataSource = con.tOgrenci.ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {

            foreach (var ogrencim in con.tOgrenci)
            {
                if (ogrencim.ogrenciID == Convert.ToInt32(tId.Text))
                {
                    con.tOgrenci.Remove(ogrencim);
                    MessageBox.Show("Silme işlemi tamamlandı");
                    
                }

            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tOgrenci.ToList();
            temizle();
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            foreach (var ogrencim in con.tOgrenci)
            {
                if (ogrencim.ogrenciID == Convert.ToInt32(tId.Text))
                {
                    tId.Text = Convert.ToString(ogrencim.ogrenciID);
                    tAd.Text = ogrencim.ad;
                    tSoyad.Text = ogrencim.soyad;
                    tBolumId.Text = Convert.ToString(ogrencim.bolumID);
                }

            }
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var ogrencim in con.tOgrenci)
            {
                if (ogrencim.ogrenciID == Convert.ToInt32(tId.Text))
                {
                    ogrencim.ogrenciID = Convert.ToInt32(tId.Text);
                    ogrencim.ad = tAd.Text;
                    ogrencim.soyad = tSoyad.Text;
                    ogrencim.bolumID = Convert.ToInt32(tBolumId.Text);
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tOgrenci.ToList();
        }

        private void fOgrenciler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.tOgrenci.ToList();
        }
        public void temizle()
        {
            tId.Clear();
            tAd.Clear();
            tSoyad.Clear();
            tBolumId.Clear();
            tId.Focus();
        }
    }
}
