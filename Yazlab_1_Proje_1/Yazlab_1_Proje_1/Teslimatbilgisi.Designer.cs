
namespace Yazlab_1_Proje_1
{
    partial class Teslimatbilgisi
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
            this.geributonu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kargoıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(22, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 20;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kargoıd,
            this.musteriadi,
            this.adres});
            this.dataGridView1.Location = new System.Drawing.Point(22, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 484);
            this.dataGridView1.TabIndex = 21;
            // 
            // kargoıd
            // 
            this.kargoıd.HeaderText = "Kargo Id";
            this.kargoıd.MinimumWidth = 6;
            this.kargoıd.Name = "kargoıd";
            this.kargoıd.Width = 125;
            // 
            // musteriadi
            // 
            this.musteriadi.HeaderText = "Musteri Adi";
            this.musteriadi.MinimumWidth = 6;
            this.musteriadi.Name = "musteriadi";
            this.musteriadi.Width = 125;
            // 
            // adres
            // 
            this.adres.HeaderText = "Musteri Lokasyonu";
            this.adres.MinimumWidth = 6;
            this.adres.Name = "adres";
            this.adres.Width = 125;
            // 
            // Teslimatbilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geributonu);
            this.Name = "Teslimatbilgisi";
            this.Text = "Teslimatbilgisi";
            this.Load += new System.EventHandler(this.Teslimatbilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geributonu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
    }
}