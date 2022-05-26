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
    public partial class fBolum : Form
    {
        public fBolum()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        
        private void fBolum_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.tBolum.ToList();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            tBolum bolum = new tBolum();
            bolum.bolumID=Convert.ToInt32(tBolumId.Text);
            bolum.bolumAd = tBolumAd.Text;
            bolum.fakulteID = Convert.ToInt32(tFakulteId.Text);
            con.tBolum.Add(bolum);
            con.SaveChanges();
            dataGridView1.DataSource = con.tBolum.ToList();
            MessageBox.Show("Ekleme Tamamlandı.");
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            foreach(var bolums in con.tBolum)
            {
                if(tBolumId.Text!="" && Convert.ToInt32(tBolumId.Text)==bolums.bolumID)
                {
                    con.tBolum.Remove(bolums);
                    MessageBox.Show("Silme işlemi tamam.");
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tBolum.ToList();
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            foreach(var bolums in con.tBolum)
            {
                if (tBolumId.Text != "" && Convert.ToInt32(tBolumId.Text) == bolums.bolumID)
                {
                    tBolumAd.Text = bolums.bolumAd;
                    tFakulteId.Text = Convert.ToString(bolums.fakulteID);
                    tBolumId.Text = Convert.ToString(bolums.bolumID);
                }
            }
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var bolums in con.tBolum)
            {
                if ((tBolumId.Text != "" && Convert.ToInt32(tBolumId.Text) == bolums.bolumID))
                {
                    bolums.bolumAd=tBolumAd.Text;
                    bolums.fakulteID = Convert.ToInt32(tFakulteId.Text);
                    bolums.bolumID = Convert.ToInt32(tBolumId.Text);
                    MessageBox.Show("Güncelleme Tamamlandı.");
                    
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tBolum.ToList();
        }
    }
}
