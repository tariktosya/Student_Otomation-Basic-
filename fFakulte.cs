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
    public partial class fFakulte : Form
    {
        public fFakulte()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        
        private void bEkle_Click(object sender, EventArgs e)
        {
            tFakulte fakulte = new tFakulte();
            fakulte.fakulteID = Convert.ToInt32(tFakulteId.Text);
            fakulte.fakulteAd = tFakulteAd.Text;
            con.tFakulte.Add(fakulte);
            con.SaveChanges();
            dataGridView1.DataSource = con.tFakulte.ToList();
            MessageBox.Show("Ekleme Tamamlandı.");
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            foreach(var fakultee in con.tFakulte)
            {
                if (tFakulteId.Text != "" && Convert.ToInt32(tFakulteId.Text) == fakultee.fakulteID)
                {
                    con.tFakulte.Remove(fakultee);
                    MessageBox.Show("Silme işlemi tamamlandı.");
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tFakulte.ToList();
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            foreach (var fakultee in con.tFakulte)
            {
                if (tFakulteId.Text != "" && Convert.ToInt32(tFakulteId.Text) == fakultee.fakulteID)
                {
                    tFakulteAd.Text = fakultee.fakulteAd;
                    tFakulteId.Text = Convert.ToString(fakultee.fakulteID);
                }
            }
            
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var fakultee in con.tFakulte)
            {
                if (tFakulteId.Text != "" && Convert.ToInt32(tFakulteId.Text) == fakultee.fakulteID)
                {
                    fakultee.fakulteID = Convert.ToInt32(fakultee.fakulteID);
                    fakultee.fakulteAd = tFakulteAd.Text;
                    MessageBox.Show("Güncelleme Tamamlandı.");
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tFakulte.ToList();
        }

        private void fFakulte_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.tFakulte.ToList();
        }
    }
}
