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
    public partial class fOgrenciDers : Form
    {
        public fOgrenciDers()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        tOgrenci ogrenci = new tOgrenci();
        
        private void bEkle_Click(object sender, EventArgs e)
        {
            tOgrenciDers ogrenciDers = new tOgrenciDers();
            ogrenciDers.ogrenciID = Convert.ToInt32(tOgrenciID.Text);
            ogrenciDers.dersID = Convert.ToInt32(tDersID.Text);
            ogrenciDers.yil = comboBox1.Text;
            ogrenciDers.yariyil = comboBox2.Text;
            
            int x = con.tOgrenciDers.Max(a=>a.id);
            MessageBox.Show(x.ToString());
            ogrenciDers.id = x + 1;
            con.tOgrenciDers.Add(ogrenciDers);
            con.SaveChanges();
            dataGridView1.DataSource = con.tOgrenciDers.ToList();
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            tOgrenciDers ogrenciDers = new tOgrenciDers();
            foreach(var ogrenciDerss in con.tOgrenciDers)
            {
                if(ogrenciDerss.ogrenciID== Convert.ToInt32(tOgrenciID.Text) && ogrenciDerss.dersID == Convert.ToInt32(tDersID.Text))
                {
                    ogrenciDerss.dersID = Convert.ToInt32(tGuncelleDers.Text);
                    tDersID.Text = tGuncelleDers.Text;
                    MessageBox.Show("Güncelleme Tamam");
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tOgrenciDers.ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            tOgrenciDers ogrenciDers = new tOgrenciDers();
            foreach (var ogrenciDerss in con.tOgrenciDers)
            {
                if (ogrenciDerss.ogrenciID == Convert.ToInt32(tOgrenciID.Text) && ogrenciDerss.dersID == Convert.ToInt32(tDersID.Text))
                {
                    con.tOgrenciDers.Remove(ogrenciDerss);
                }
            }
            con.SaveChanges();
            dataGridView1.DataSource = con.tOgrenciDers.ToList();
            MessageBox.Show("Silme işlemi tamam");

        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            tOgrenciDers ogrenciDers = new tOgrenciDers();
            foreach (var ogrenciDerss in con.tOgrenciDers)
            {
                if (ogrenciDerss.ogrenciID == Convert.ToInt32(tOgrenciID.Text) && ogrenciDerss.dersID == Convert.ToInt32(tDersID.Text))
                {
                    comboBox1.Text = ogrenciDerss.yil;
                    comboBox2.Text = ogrenciDerss.yariyil;
                }
            }
        }

        private void fOgrenciDers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.tOgrenciDers.ToList();
        }
    }
}
