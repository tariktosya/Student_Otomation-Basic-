namespace VtysOdev
{
    partial class fHoca
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
            this.tHocaSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bGetir = new System.Windows.Forms.Button();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.tHocaAd = new System.Windows.Forms.TextBox();
            this.tHocaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tHocaSoyad
            // 
            this.tHocaSoyad.Location = new System.Drawing.Point(207, 115);
            this.tHocaSoyad.Name = "tHocaSoyad";
            this.tHocaSoyad.Size = new System.Drawing.Size(142, 22);
            this.tHocaSoyad.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Hoca Syoad";
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(396, 104);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(89, 38);
            this.bGetir.TabIndex = 46;
            this.bGetir.Text = "GETİR";
            this.bGetir.UseVisualStyleBackColor = true;
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(491, 104);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(109, 38);
            this.bGuncelle.TabIndex = 45;
            this.bGuncelle.Text = "GÜNCELLE";
            this.bGuncelle.UseVisualStyleBackColor = true;
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(491, 38);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(89, 38);
            this.bSil.TabIndex = 44;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(396, 38);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(89, 38);
            this.bEkle.TabIndex = 43;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // tHocaAd
            // 
            this.tHocaAd.Location = new System.Drawing.Point(207, 75);
            this.tHocaAd.Name = "tHocaAd";
            this.tHocaAd.Size = new System.Drawing.Size(142, 22);
            this.tHocaAd.TabIndex = 42;
            // 
            // tHocaID
            // 
            this.tHocaID.Location = new System.Drawing.Point(207, 38);
            this.tHocaID.Name = "tHocaID";
            this.tHocaID.Size = new System.Drawing.Size(142, 22);
            this.tHocaID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Hoca Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hoca ID";
            // 
            // fHoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tHocaSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.tHocaAd);
            this.Controls.Add(this.tHocaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fHoca";
            this.Text = "fHoca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tHocaSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bGetir;
        private System.Windows.Forms.Button bGuncelle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.TextBox tHocaAd;
        private System.Windows.Forms.TextBox tHocaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}