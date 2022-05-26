namespace VtysOdev
{
    partial class fHome
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
            this.bFakulte = new System.Windows.Forms.Button();
            this.bBolum = new System.Windows.Forms.Button();
            this.bOgrenci = new System.Windows.Forms.Button();
            this.bDers = new System.Windows.Forms.Button();
            this.bListele = new System.Windows.Forms.Button();
            this.bVizeFinal = new System.Windows.Forms.Button();
            this.bHoca = new System.Windows.Forms.Button();
            this.bOgrenciDers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFakulte
            // 
            this.bFakulte.Location = new System.Drawing.Point(222, 41);
            this.bFakulte.Name = "bFakulte";
            this.bFakulte.Size = new System.Drawing.Size(308, 67);
            this.bFakulte.TabIndex = 0;
            this.bFakulte.Text = "FAKÜLTE CRUD";
            this.bFakulte.UseVisualStyleBackColor = true;
            this.bFakulte.Click += new System.EventHandler(this.bFakulte_Click);
            // 
            // bBolum
            // 
            this.bBolum.Location = new System.Drawing.Point(222, 114);
            this.bBolum.Name = "bBolum";
            this.bBolum.Size = new System.Drawing.Size(308, 67);
            this.bBolum.TabIndex = 1;
            this.bBolum.Text = "BÖLÜM CRUD";
            this.bBolum.UseVisualStyleBackColor = true;
            this.bBolum.Click += new System.EventHandler(this.bBolum_Click);
            // 
            // bOgrenci
            // 
            this.bOgrenci.Location = new System.Drawing.Point(222, 260);
            this.bOgrenci.Name = "bOgrenci";
            this.bOgrenci.Size = new System.Drawing.Size(308, 67);
            this.bOgrenci.TabIndex = 2;
            this.bOgrenci.Text = "ÖĞRENCİ CRUD";
            this.bOgrenci.UseVisualStyleBackColor = true;
            this.bOgrenci.Click += new System.EventHandler(this.bOgrenci_Click);
            // 
            // bDers
            // 
            this.bDers.Location = new System.Drawing.Point(222, 187);
            this.bDers.Name = "bDers";
            this.bDers.Size = new System.Drawing.Size(308, 67);
            this.bDers.TabIndex = 3;
            this.bDers.Text = "DERS CRUD";
            this.bDers.UseVisualStyleBackColor = true;
            this.bDers.Click += new System.EventHandler(this.bDers_Click);
            // 
            // bListele
            // 
            this.bListele.Location = new System.Drawing.Point(222, 333);
            this.bListele.Name = "bListele";
            this.bListele.Size = new System.Drawing.Size(308, 67);
            this.bListele.TabIndex = 4;
            this.bListele.Text = "LİSTELE";
            this.bListele.UseVisualStyleBackColor = true;
            this.bListele.Click += new System.EventHandler(this.bListele_Click);
            // 
            // bVizeFinal
            // 
            this.bVizeFinal.Location = new System.Drawing.Point(222, 406);
            this.bVizeFinal.Name = "bVizeFinal";
            this.bVizeFinal.Size = new System.Drawing.Size(308, 67);
            this.bVizeFinal.TabIndex = 5;
            this.bVizeFinal.Text = "VİZE FİNAL";
            this.bVizeFinal.UseVisualStyleBackColor = true;
            this.bVizeFinal.Click += new System.EventHandler(this.bVizeFinal_Click);
            // 
            // bHoca
            // 
            this.bHoca.Location = new System.Drawing.Point(222, 479);
            this.bHoca.Name = "bHoca";
            this.bHoca.Size = new System.Drawing.Size(308, 67);
            this.bHoca.TabIndex = 6;
            this.bHoca.Text = "HOCA";
            this.bHoca.UseVisualStyleBackColor = true;
            this.bHoca.Click += new System.EventHandler(this.bHoca_Click);
            // 
            // bOgrenciDers
            // 
            this.bOgrenciDers.Location = new System.Drawing.Point(222, 552);
            this.bOgrenciDers.Name = "bOgrenciDers";
            this.bOgrenciDers.Size = new System.Drawing.Size(308, 67);
            this.bOgrenciDers.TabIndex = 7;
            this.bOgrenciDers.Text = "DERS";
            this.bOgrenciDers.UseVisualStyleBackColor = true;
            this.bOgrenciDers.Click += new System.EventHandler(this.bOgrenciDers_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 651);
            this.Controls.Add(this.bOgrenciDers);
            this.Controls.Add(this.bHoca);
            this.Controls.Add(this.bVizeFinal);
            this.Controls.Add(this.bListele);
            this.Controls.Add(this.bDers);
            this.Controls.Add(this.bOgrenci);
            this.Controls.Add(this.bBolum);
            this.Controls.Add(this.bFakulte);
            this.Name = "fHome";
            this.Text = "fHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFakulte;
        private System.Windows.Forms.Button bBolum;
        private System.Windows.Forms.Button bOgrenci;
        private System.Windows.Forms.Button bDers;
        private System.Windows.Forms.Button bListele;
        private System.Windows.Forms.Button bVizeFinal;
        private System.Windows.Forms.Button bHoca;
        private System.Windows.Forms.Button bOgrenciDers;
    }
}