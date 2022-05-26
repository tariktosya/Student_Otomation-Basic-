namespace VtysOdev
{
    partial class fVizeFinal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DERSLER = new System.Windows.Forms.Label();
            this.bListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // DERSLER
            // 
            this.DERSLER.AutoSize = true;
            this.DERSLER.Location = new System.Drawing.Point(127, 44);
            this.DERSLER.Name = "DERSLER";
            this.DERSLER.Size = new System.Drawing.Size(71, 16);
            this.DERSLER.TabIndex = 1;
            this.DERSLER.Text = "DERSLER";
            // 
            // bListele
            // 
            this.bListele.Location = new System.Drawing.Point(611, 33);
            this.bListele.Name = "bListele";
            this.bListele.Size = new System.Drawing.Size(102, 39);
            this.bListele.TabIndex = 2;
            this.bListele.Text = "LİSTELE";
            this.bListele.UseVisualStyleBackColor = true;
            this.bListele.Click += new System.EventHandler(this.bListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 418);
            this.dataGridView1.TabIndex = 3;
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(814, 33);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(102, 39);
            this.bKaydet.TabIndex = 4;
            this.bKaydet.Text = "KAYDET";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // fVizeFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 542);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bListele);
            this.Controls.Add(this.DERSLER);
            this.Controls.Add(this.comboBox1);
            this.Name = "fVizeFinal";
            this.Text = "fVizeFinal";
            this.Load += new System.EventHandler(this.fVizeFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label DERSLER;
        private System.Windows.Forms.Button bListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bKaydet;
    }
}