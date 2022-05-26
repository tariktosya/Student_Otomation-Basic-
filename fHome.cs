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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void bFakulte_Click(object sender, EventArgs e)
        {
            fFakulte fakulteForm = new fFakulte();
            fakulteForm.Show();
        }

        private void bBolum_Click(object sender, EventArgs e)
        {
            fBolum fBolumForm = new fBolum();
            fBolumForm.Show();
        }

        private void bDers_Click(object sender, EventArgs e)
        {
            fDers fDersForm = new fDers();
            fDersForm.Show();
        }

        private void bOgrenci_Click(object sender, EventArgs e)
        {
            fOgrenciler fOgrencilerForm = new fOgrenciler();
            fOgrencilerForm.Show();
        }

        private void bListele_Click(object sender, EventArgs e)
        {
            fListele fListeleForm = new fListele();
            fListeleForm.Show();
        }

        private void bVizeFinal_Click(object sender, EventArgs e)
        {
            fVizeFinal fVizeFinalForm = new fVizeFinal();
            fVizeFinalForm.Show();
        }

        private void bHoca_Click(object sender, EventArgs e)
        {
            fHoca fHocaForm = new fHoca();
            fHocaForm.Show();
        }

        private void bOgrenciDers_Click(object sender, EventArgs e)
        {
            fOgrenciDers ogrenci = new fOgrenciDers();
            ogrenci.Show();
        }
    }
}
