namespace VtysOdev
{
    partial class fBolum
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bGetir = new System.Windows.Forms.Button();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.tFakulteId = new System.Windows.Forms.TextBox();
            this.tBolumAd = new System.Windows.Forms.TextBox();
            this.tBolumId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 216);
            this.dataGridView1.TabIndex = 25;
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(354, 94);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(89, 38);
            this.bGetir.TabIndex = 24;
            this.bGetir.Text = "GETİR";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(449, 94);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(109, 38);
            this.bGuncelle.TabIndex = 23;
            this.bGuncelle.Text = "GÜNCELLE";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(449, 28);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(89, 38);
            this.bSil.TabIndex = 22;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(354, 28);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(89, 38);
            this.bEkle.TabIndex = 21;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // tFakulteId
            // 
            this.tFakulteId.Location = new System.Drawing.Point(165, 102);
            this.tFakulteId.Name = "tFakulteId";
            this.tFakulteId.Size = new System.Drawing.Size(142, 22);
            this.tFakulteId.TabIndex = 19;
            // 
            // tBolumAd
            // 
            this.tBolumAd.Location = new System.Drawing.Point(165, 65);
            this.tBolumAd.Name = "tBolumAd";
            this.tBolumAd.Size = new System.Drawing.Size(142, 22);
            this.tBolumAd.TabIndex = 18;
            // 
            // tBolumId
            // 
            this.tBolumId.Location = new System.Drawing.Point(165, 28);
            this.tBolumId.Name = "tBolumId";
            this.tBolumId.Size = new System.Drawing.Size(142, 22);
            this.tBolumId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fakulte ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bölüm Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bölüm ID";
            // 
            // fBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.tFakulteId);
            this.Controls.Add(this.tBolumAd);
            this.Controls.Add(this.tBolumId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fBolum";
            this.Text = "Bolum";
            this.Load += new System.EventHandler(this.fBolum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bGetir;
        private System.Windows.Forms.Button bGuncelle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.TextBox tFakulteId;
        private System.Windows.Forms.TextBox tBolumAd;
        private System.Windows.Forms.TextBox tBolumId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

