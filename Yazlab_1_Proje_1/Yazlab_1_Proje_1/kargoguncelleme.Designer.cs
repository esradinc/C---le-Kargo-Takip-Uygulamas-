
namespace Yazlab_1_Proje_1
{
    partial class kargoguncelleme
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
            this.kargoidgir = new System.Windows.Forms.TextBox();
            this.musteriadigir = new System.Windows.Forms.TextBox();
            this.adresgir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guncellebutonu = new System.Windows.Forms.Button();
            this.bulbutonu = new System.Windows.Forms.Button();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kargoidgir
            // 
            this.kargoidgir.Location = new System.Drawing.Point(217, 82);
            this.kargoidgir.Name = "kargoidgir";
            this.kargoidgir.Size = new System.Drawing.Size(100, 22);
            this.kargoidgir.TabIndex = 15;
            // 
            // musteriadigir
            // 
            this.musteriadigir.Location = new System.Drawing.Point(217, 182);
            this.musteriadigir.Name = "musteriadigir";
            this.musteriadigir.Size = new System.Drawing.Size(100, 22);
            this.musteriadigir.TabIndex = 14;
            // 
            // adresgir
            // 
            this.adresgir.Location = new System.Drawing.Point(217, 246);
            this.adresgir.Name = "adresgir";
            this.adresgir.Size = new System.Drawing.Size(100, 22);
            this.adresgir.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Musteri Lokasyonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Musteri Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kargo Id";
            // 
            // guncellebutonu
            // 
            this.guncellebutonu.Location = new System.Drawing.Point(217, 320);
            this.guncellebutonu.Name = "guncellebutonu";
            this.guncellebutonu.Size = new System.Drawing.Size(100, 23);
            this.guncellebutonu.TabIndex = 9;
            this.guncellebutonu.Text = "GUNCELLE";
            this.guncellebutonu.UseVisualStyleBackColor = true;
            this.guncellebutonu.Click += new System.EventHandler(this.guncellebutonu_Click);
            // 
            // bulbutonu
            // 
            this.bulbutonu.Location = new System.Drawing.Point(77, 124);
            this.bulbutonu.Name = "bulbutonu";
            this.bulbutonu.Size = new System.Drawing.Size(240, 30);
            this.bulbutonu.TabIndex = 17;
            this.bulbutonu.Text = "BUL";
            this.bulbutonu.UseVisualStyleBackColor = true;
            this.bulbutonu.Click += new System.EventHandler(this.bulbutonu_Click);
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(25, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 20;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // kargoguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.bulbutonu);
            this.Controls.Add(this.kargoidgir);
            this.Controls.Add(this.musteriadigir);
            this.Controls.Add(this.adresgir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guncellebutonu);
            this.Name = "kargoguncelleme";
            this.Text = "kargoguncelleme";
            this.Load += new System.EventHandler(this.kargoguncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kargoidgir;
        private System.Windows.Forms.TextBox musteriadigir;
        private System.Windows.Forms.TextBox adresgir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guncellebutonu;
        private System.Windows.Forms.Button bulbutonu;
        private System.Windows.Forms.Button geributonu;
    }
}