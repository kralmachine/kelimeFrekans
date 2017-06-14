namespace WinFrekansKelime
{
    partial class WinFrekansKelime
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFrekansDosyasi = new System.Windows.Forms.RichTextBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDurumSec = new System.Windows.Forms.ComboBox();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.btnDosyadan = new System.Windows.Forms.Button();
            this.rdBosluklu = new System.Windows.Forms.RadioButton();
            this.rdBoşluksuz = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGV);
            this.groupBox2.Location = new System.Drawing.Point(448, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuç";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFrekansDosyasi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 329);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdBoşluksuz);
            this.panel2.Controls.Add(this.rdBosluklu);
            this.panel2.Controls.Add(this.btnDosyadan);
            this.panel2.Controls.Add(this.btnAnaliz);
            this.panel2.Controls.Add(this.cbDurumSec);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 88);
            this.panel2.TabIndex = 1;
            // 
            // txtFrekansDosyasi
            // 
            this.txtFrekansDosyasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFrekansDosyasi.Location = new System.Drawing.Point(0, 0);
            this.txtFrekansDosyasi.Name = "txtFrekansDosyasi";
            this.txtFrekansDosyasi.Size = new System.Drawing.Size(422, 327);
            this.txtFrekansDosyasi.TabIndex = 1;
            this.txtFrekansDosyasi.Text = "";
            // 
            // dGV
            // 
            this.dGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.Location = new System.Drawing.Point(3, 19);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersVisible = false;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(304, 417);
            this.dGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "(lblBilgi)";
            // 
            // cbDurumSec
            // 
            this.cbDurumSec.DisplayMember = "None";
            this.cbDurumSec.FormattingEnabled = true;
            this.cbDurumSec.Items.AddRange(new object[] {
            "En çok tekrar eden karakterler",
            "En az tekrar eden karakterler",
            "En çok tekrar eden 2 harfli karakterler",
            "En çok tekrar eden 3 harfli karakterler"});
            this.cbDurumSec.Location = new System.Drawing.Point(6, 28);
            this.cbDurumSec.Name = "cbDurumSec";
            this.cbDurumSec.Size = new System.Drawing.Size(284, 24);
            this.cbDurumSec.TabIndex = 1;
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliz.Location = new System.Drawing.Point(296, 17);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(123, 29);
            this.btnAnaliz.TabIndex = 2;
            this.btnAnaliz.Text = "Analiz";
            this.btnAnaliz.UseVisualStyleBackColor = false;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // btnDosyadan
            // 
            this.btnDosyadan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDosyadan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyadan.Location = new System.Drawing.Point(296, 47);
            this.btnDosyadan.Name = "btnDosyadan";
            this.btnDosyadan.Size = new System.Drawing.Size(123, 28);
            this.btnDosyadan.TabIndex = 3;
            this.btnDosyadan.Text = "Dosyadan";
            this.btnDosyadan.UseVisualStyleBackColor = false;
            this.btnDosyadan.Click += new System.EventHandler(this.btnDosyadan_Click);
            // 
            // rdBosluklu
            // 
            this.rdBosluklu.AutoSize = true;
            this.rdBosluklu.Location = new System.Drawing.Point(6, 55);
            this.rdBosluklu.Name = "rdBosluklu";
            this.rdBosluklu.Size = new System.Drawing.Size(78, 20);
            this.rdBosluklu.TabIndex = 4;
            this.rdBosluklu.TabStop = true;
            this.rdBosluklu.Text = "Boşluklu";
            this.rdBosluklu.UseVisualStyleBackColor = true;
            // 
            // rdBoşluksuz
            // 
            this.rdBoşluksuz.AutoSize = true;
            this.rdBoşluksuz.Location = new System.Drawing.Point(90, 55);
            this.rdBoşluksuz.Name = "rdBoşluksuz";
            this.rdBoşluksuz.Size = new System.Drawing.Size(89, 20);
            this.rdBoşluksuz.TabIndex = 5;
            this.rdBoşluksuz.TabStop = true;
            this.rdBoşluksuz.Text = "Boşluksuz";
            this.rdBoşluksuz.UseVisualStyleBackColor = true;
            // 
            // WinFrekansKelime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinFrekansKelime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frekans Kelime";
            this.Load += new System.EventHandler(this.WinFrekansKelime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtFrekansDosyasi;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnDosyadan;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.ComboBox cbDurumSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBoşluksuz;
        private System.Windows.Forms.RadioButton rdBosluklu;
    }
}