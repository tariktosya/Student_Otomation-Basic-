namespace VtysOdev
{
    partial class fFakulte
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
            this.tFakulteAd = new System.Windows.Forms.TextBox();
            this.tFakulteId = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.TabIndex = 45;
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(354, 94);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(89, 38);
            this.bGetir.TabIndex = 44;
            this.bGetir.Text = "GETİR";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(449, 94);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(109, 38);
            this.bGuncelle.TabIndex = 43;
            this.bGuncelle.Text = "GÜNCELLE";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(449, 28);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(89, 38);
            this.bSil.TabIndex = 42;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(354, 28);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(89, 38);
            this.bEkle.TabIndex = 41;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // tFakulteAd
            // 
            this.tFakulteAd.Location = new System.Drawing.Point(165, 65);
            this.tFakulteAd.Name = "tFakulteAd";
            this.tFakulteAd.Size = new System.Drawing.Size(142, 22);
            this.tFakulteAd.TabIndex = 40;
            // 
            // tFakulteId
            // 
            this.tFakulteId.Location = new System.Drawing.Point(165, 28);
            this.tFakulteId.Name = "tFakulteId";
            this.tFakulteId.Size = new System.Drawing.Size(142, 22);
            this.tFakulteId.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fakülte Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fakülte ID";
            // 
            // fFakulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.tFakulteAd);
            this.Controls.Add(this.tFakulteId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fFakulte";
            this.Text = "fFakulte";
            this.Load += new System.EventHandler(this.fFakulte_Load);
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
        private System.Windows.Forms.TextBox tFakulteAd;
        private System.Windows.Forms.TextBox tFakulteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}