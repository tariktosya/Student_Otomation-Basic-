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
    public partial class fVizeFinal : Form
    {
        public fVizeFinal()
        {
            InitializeComponent();
        }
        Model1 con = new Model1();
        DataTable table = new DataTable();
        private void fVizeFinal_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Öğrenci No", typeof(int));
            table.Columns.Add("Adı", typeof(String));
            table.Columns.Add("Soyadı", typeof(String));
            table.Columns.Add("Ders ID", typeof(int));
            table.Columns.Add("Ders Adı", typeof(String));
            table.Columns.Add("Vize", typeof(float));
            table.Columns.Add("Final", typeof(float));
            foreach (var dersler in con.tDers)
            {
                comboBox1.Items.Add(dersler.dersAD);  
            }
        }

        private void bListele_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            foreach(var ders in con.tDers.Where(a=>a.dersAD==comboBox1.Text)) 
            {
                foreach (var ogrenciDers in con.tOgrenciDers.Where(x => x.dersID == ders.dersID ))
                {
                    foreach(var ogrenci in con.tOgrenci.Where(y => y.ogrenciID == ogrenciDers.ogrenciID))
                    {
                        table.Rows.Add(ogrenci.ogrenciID, ogrenci.ad, ogrenci.soyad,ders.dersID, ders.dersAD, ogrenciDers.vize, ogrenciDers.final);
                    }
                }
            }
            dataGridView1.DataSource = table;
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                int a = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                int b = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                foreach (var ogrenciDers in con.tOgrenciDers.Where(x => x.ogrenciID == a && x.dersID==b))
                {
                    if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "")
                    {
                        ogrenciDers.vize = 0;
                        if(dataGridView1.Rows[i].Cells[6].Value.ToString() == "")
                        {
                            ogrenciDers.final = 0;
                        }
                        else
                        {
                            double final = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value.ToString());
                            ogrenciDers.final = final;
                        }
                        
                    }
                    else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "")
                    {
                        ogrenciDers.final = 0;
                        double vize = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        ogrenciDers.vize = vize;
                    }
                    else
                    {
                        double vize = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        double final = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value.ToString());
                        ogrenciDers.vize = vize;
                        ogrenciDers.final = final;
                    }
                    
                }
            }
            con.SaveChanges();
        }
    }
}
