namespace VtysOdev
{
    partial class fListele
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
            this.list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tOgrenciNo = new System.Windows.Forms.TextBox();
            this.bOgrenciNo = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bYilYariyil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(60, 203);
            this.list.Name = "list";
            this.list.RowHeadersWidth = 51;
            this.list.RowTemplate.Height = 24;
            this.list.Size = new System.Drawing.Size(869, 377);
            this.list.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci No";
            // 
            // tOgrenciNo
            // 
            this.tOgrenciNo.Location = new System.Drawing.Point(192, 31);
            this.tOgrenciNo.Name = "tOgrenciNo";
            this.tOgrenciNo.Size = new System.Drawing.Size(100, 22);
            this.tOgrenciNo.TabIndex = 2;
            // 
            // bOgrenciNo
            // 
            this.bOgrenciNo.Location = new System.Drawing.Point(318, 24);
            this.bOgrenciNo.Name = "bOgrenciNo";
            this.bOgrenciNo.Size = new System.Drawing.Size(88, 37);
            this.bOgrenciNo.TabIndex = 3;
            this.bOgrenciNo.Text = "LİSTELE";
            this.bOgrenciNo.UseVisualStyleBackColor = true;
            this.bOgrenciNo.Click += new System.EventHandler(this.bOgrenciNo_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GÜZ",
            "BAHAR"});
            this.comboBox2.Location = new System.Drawing.Point(623, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 24);
            this.comboBox2.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022"});
            this.comboBox1.Location = new System.Drawing.Point(623, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Yarıyıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Yıl";
            // 
            // bYilYariyil
            // 
            this.bYilYariyil.Location = new System.Drawing.Point(813, 24);
            this.bYilYariyil.Name = "bYilYariyil";
            this.bYilYariyil.Size = new System.Drawing.Size(88, 37);
            this.bYilYariyil.TabIndex = 54;
            this.bYilYariyil.Text = "LİSTELE";
            this.bYilYariyil.UseVisualStyleBackColor = true;
            this.bYilYariyil.Click += new System.EventHandler(this.bYilYariyil_Click);
            // 
            // fListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 609);
            this.Controls.Add(this.bYilYariyil);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bOgrenciNo);
            this.Controls.Add(this.tOgrenciNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Name = "fListele";
            this.Text = "fListele";
            this.Load += new System.EventHandler(this.fListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tOgrenciNo;
        private System.Windows.Forms.Button bOgrenciNo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bYilYariyil;
    }
}