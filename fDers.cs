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
    public partial class fDers : Form
    {
        public fDers()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        
        private void bEkle_Click(object sender, EventArgs e)
        {
            tDers ders = new tDers();
            ders.dersID = Convert.ToInt32(tDersID.Text);
            ders.dersAD = tDersAD.Text;
            ders.hocaID = Convert.ToInt32(yHocaID.Text);
            con.tDers.Add(ders);
            con.SaveChanges();
            MessageBox.Show("Ekleme Tamamlandı.");
            dataGridView1.DataSource = con.tDers.ToList();
        }
        private void bSil_Click(object sender, EventArgs e)
        {
            foreach(var derss in con.tDers)
            {
                if(Convert.ToInt32(tDersID.Text)==derss.dersID && tDersID.Text != "")
                {
                    con.tDers.Remove(derss);
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource=con.tDers.ToList();
            MessageBox.Show("Silme işlemi tamamlandı.");

        }
        private void bGetir_Click(object sender, EventArgs e)
        {
            foreach(var derss in con.tDers)
            {
                if (Convert.ToInt32(tDersID.Text) == derss.dersID && tDersID.Text != "")
                {
                    tDersAD.Text = derss.dersAD;
                    tDersID.Text = Convert.ToString(derss.dersID);
                }
            }
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var derss in con.tDers)
            {
                if (Convert.ToInt32(tDersID.Text) == derss.dersID && tDersID.Text != "")
                {
                    derss.dersID=Convert.ToInt32(tDersID.Text);
                    derss.dersAD = tDersAD.Text;
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tDers.ToList();
            MessageBox.Show("Güncelleme Tamamlandı.");
        }

        private void fDers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.tDers.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
