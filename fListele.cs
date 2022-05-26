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
    public partial class fListele : Form
    {
        public fListele()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        DataTable tableOgrenciNo = new DataTable();
        DataTable tableYilYariyil = new DataTable();
        private void fListele_Load(object sender, EventArgs e)
        {
            tableOgrenciNo.Columns.Add("Öğrenci No", typeof(int));
            tableOgrenciNo.Columns.Add("Adı", typeof(String));
            tableOgrenciNo.Columns.Add("Soyadı", typeof(String));
            tableOgrenciNo.Columns.Add("Ders Adı", typeof(String));

            tableYilYariyil.Columns.Add("Ders Adı", typeof(String));
            tableYilYariyil.Columns.Add("Toplam", typeof(int));
        }

        private void bYilYariyil_Click(object sender, EventArgs e)
        {
            tableYilYariyil.Rows.Clear();
           
            foreach(var ders in con.tOgrenciDers.Where(x => x.yil == comboBox1.Text && x.yariyil == comboBox2.Text).GroupBy(x => x.dersID).Select(n => new { Ders = n.Key, Sayi = n.Count() }))
            {
                foreach(var dersAdlari in con.tDers.Where(x => x.dersID == ders.Ders)) 
                {
                    tableYilYariyil.Rows.Add(dersAdlari.dersAD, ders.Sayi);
                }
                
            }
            list.DataSource = tableYilYariyil;
        }
        private void bOgrenciNo_Click(object sender, EventArgs e)
        {
            tableOgrenciNo.Rows.Clear();
            foreach(var ogrenci in con.tOgrenci)
            {
                if (tOgrenciNo.Text!="" && Convert.ToInt32(tOgrenciNo.Text) == ogrenci.ogrenciID)
                {
                    foreach(var ogrenciDers in con.tOgrenciDers)
                    {
                        if (ogrenci.ogrenciID == ogrenciDers.ogrenciID)
                        {
                           foreach(var ders in con.tDers)
                            {
                                if (ogrenciDers.dersID == ders.dersID)
                                {
                                    tableOgrenciNo.Rows.Add(ogrenci.ogrenciID, ogrenci.ad, ogrenci.soyad, ders.dersAD);
                                }
                            }  
                        }
                    }
                }
            }
            list.DataSource = tableOgrenciNo;
            list.DataSource = tableOgrenciNo;
        }

        
    }
}
