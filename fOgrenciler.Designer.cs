namespace VtysOdev
{
    partial class fOgrenciler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tAd = new System.Windows.Forms.TextBox();
            this.tSoyad = new System.Windows.Forms.TextBox();
            this.tBolumId = new System.Windows.Forms.TextBox();
            this.bEkle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.bGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm ID";
            // 
            // tId
            // 
            this.tId.Location = new System.Drawing.Point(173, 44);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(142, 22);
            this.tId.TabIndex = 4;
            // 
            // tAd
            // 
            this.tAd.Location = new System.Drawing.Point(173, 81);
            this.tAd.Name = "tAd";
            this.tAd.Size = new System.Drawing.Size(142, 22);
            this.tAd.TabIndex = 5;
            // 
            // tSoyad
            // 
            this.tSoyad.Location = new System.Drawing.Point(173, 118);
            this.tSoyad.Name = "tSoyad";
            this.tSoyad.Size = new System.Drawing.Size(142, 22);
            this.tSoyad.TabIndex = 6;
            // 
            // tBolumId
            // 
            this.tBolumId.Location = new System.Drawing.Point(173, 160);
            this.tBolumId.Name = "tBolumId";
            this.tBolumId.Size = new System.Drawing.Size(142, 22);
            this.tBolumId.TabIndex = 7;
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(362, 44);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(89, 38);
            this.bEkle.TabIndex = 8;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(457, 44);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(89, 38);
            this.bSil.TabIndex = 9;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(457, 110);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(109, 38);
            this.bGuncelle.TabIndex = 10;
            this.bGuncelle.Text = "GÜNCELLE";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(362, 110);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(89, 38);
            this.bGetir.TabIndex = 11;
            this.bGetir.Text = "GETİR";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 216);
            this.dataGridView1.TabIndex = 12;
            // 
            // fOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.tBolumId);
            this.Controls.Add(this.tSoyad);
            this.Controls.Add(this.tAd);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fOgrenciler";
            this.Text = "ÖĞRENCİLER";
            this.Load += new System.EventHandler(this.fOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tAd;
        private System.Windows.Forms.TextBox tSoyad;
        private System.Windows.Forms.TextBox tBolumId;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bGuncelle;
        private System.Windows.Forms.Button bGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}