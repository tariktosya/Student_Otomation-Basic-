namespace VtysOdev
{
    partial class fOgrenciDers
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
            this.tDersID = new System.Windows.Forms.TextBox();
            this.tOgrenciID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tGuncelleDers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(958, 288);
            this.dataGridView1.TabIndex = 45;
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(405, 80);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(89, 38);
            this.bGetir.TabIndex = 44;
            this.bGetir.Text = "GETİR";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(725, 64);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(109, 38);
            this.bGuncelle.TabIndex = 43;
            this.bGuncelle.Text = "GÜNCELLE";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // bSil
            // 
            this.bSil.Location = new System.Drawing.Point(456, 28);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(89, 38);
            this.bSil.TabIndex = 42;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(361, 28);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(89, 38);
            this.bEkle.TabIndex = 41;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // tDersID
            // 
            this.tDersID.Location = new System.Drawing.Point(165, 65);
            this.tDersID.Name = "tDersID";
            this.tDersID.Size = new System.Drawing.Size(142, 22);
            this.tDersID.TabIndex = 40;
            // 
            // tOgrenciID
            // 
            this.tOgrenciID.Location = new System.Drawing.Point(165, 28);
            this.tOgrenciID.Name = "tOgrenciID";
            this.tOgrenciID.Size = new System.Drawing.Size(142, 22);
            this.tOgrenciID.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ders ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Öğrenci Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Yarıyıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Yıl";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022"});
            this.comboBox1.Location = new System.Drawing.Point(165, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 48;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GÜZ",
            "BAHAR"});
            this.comboBox2.Location = new System.Drawing.Point(165, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 24);
            this.comboBox2.TabIndex = 49;
            // 
            // tGuncelleDers
            // 
            this.tGuncelleDers.Location = new System.Drawing.Point(706, 36);
            this.tGuncelleDers.Name = "tGuncelleDers";
            this.tGuncelleDers.Size = new System.Drawing.Size(142, 22);
            this.tGuncelleDers.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ders ID";
            // 
            // fOgrenciDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 578);
            this.Controls.Add(this.tGuncelleDers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bGuncelle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.tDersID);
            this.Controls.Add(this.tOgrenciID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fOgrenciDers";
            this.Text = "fOgrenciDers";
            this.Load += new System.EventHandler(this.fOgrenciDers_Load);
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
        private System.Windows.Forms.TextBox tDersID;
        private System.Windows.Forms.TextBox tOgrenciID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tGuncelleDers;
        private System.Windows.Forms.Label label5;
    }
}