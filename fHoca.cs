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
    public partial class fHoca : Form
    {
        public fHoca()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        private void bEkle_Click(object sender, EventArgs e)
        {
            tHoca hoca = new tHoca();
            hoca.hocaID = Convert.ToInt32(tHocaID.Text);
            hoca.hocaAD = tHocaAd.Text;
            hoca.hocaSoyad = tHocaSoyad.Text;
            con.tHoca.Add(hoca);
            con.SaveChanges();
        }
    }
}
