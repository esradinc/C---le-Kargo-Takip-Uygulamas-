
namespace Yazlab_1_Proje_1
{
    partial class kargoekleme
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
            this.eklebutonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adresgir = new System.Windows.Forms.TextBox();
            this.musteriadigir = new System.Windows.Forms.TextBox();
            this.kargoidgir = new System.Windows.Forms.TextBox();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eklebutonu
            // 
            this.eklebutonu.Location = new System.Drawing.Point(225, 296);
            this.eklebutonu.Name = "eklebutonu";
            this.eklebutonu.Size = new System.Drawing.Size(100, 23);
            this.eklebutonu.TabIndex = 0;
            this.eklebutonu.Text = "EKLE";
            this.eklebutonu.UseVisualStyleBackColor = true;
            this.eklebutonu.Click += new System.EventHandler(this.eklebutonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kargo Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Musteri Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Musteri Lokasyonu";
            // 
            // adresgir
            // 
            this.adresgir.Location = new System.Drawing.Point(225, 236);
            this.adresgir.Name = "adresgir";
            this.adresgir.Size = new System.Drawing.Size(100, 22);
            this.adresgir.TabIndex = 6;
            // 
            // musteriadigir
            // 
            this.musteriadigir.Location = new System.Drawing.Point(225, 172);
            this.musteriadigir.Name = "musteriadigir";
            this.musteriadigir.Size = new System.Drawing.Size(100, 22);
            this.musteriadigir.TabIndex = 7;
            // 
            // kargoidgir
            // 
            this.kargoidgir.Location = new System.Drawing.Point(225, 113);
            this.kargoidgir.Name = "kargoidgir";
            this.kargoidgir.Size = new System.Drawing.Size(100, 22);
            this.kargoidgir.TabIndex = 8;
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(31, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 19;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // kargoekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.kargoidgir);
            this.Controls.Add(this.musteriadigir);
            this.Controls.Add(this.adresgir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eklebutonu);
            this.Name = "kargoekleme";
            this.Text = "kargoekleme";
            this.Load += new System.EventHandler(this.kargoekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eklebutonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresgir;
        private System.Windows.Forms.TextBox musteriadigir;
        private System.Windows.Forms.TextBox kargoidgir;
        private System.Windows.Forms.Button geributonu;
    }
}