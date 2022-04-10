
namespace Yazlab_1_Proje_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kayitolbutonu = new System.Windows.Forms.Button();
            this.girisyapbutonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "HOSGELDINIZ";
            // 
            // kayitolbutonu
            // 
            this.kayitolbutonu.Location = new System.Drawing.Point(54, 230);
            this.kayitolbutonu.Name = "kayitolbutonu";
            this.kayitolbutonu.Size = new System.Drawing.Size(149, 33);
            this.kayitolbutonu.TabIndex = 6;
            this.kayitolbutonu.Text = "KAYIT OL";
            this.kayitolbutonu.UseVisualStyleBackColor = true;
            this.kayitolbutonu.Click += new System.EventHandler(this.kayitolbutonu_Click);
            // 
            // girisyapbutonu
            // 
            this.girisyapbutonu.Location = new System.Drawing.Point(228, 230);
            this.girisyapbutonu.Name = "girisyapbutonu";
            this.girisyapbutonu.Size = new System.Drawing.Size(147, 33);
            this.girisyapbutonu.TabIndex = 7;
            this.girisyapbutonu.Text = "GIRIS YAP";
            this.girisyapbutonu.UseVisualStyleBackColor = true;
            this.girisyapbutonu.Click += new System.EventHandler(this.girisyapbutonu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.girisyapbutonu);
            this.Controls.Add(this.kayitolbutonu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitolbutonu;
        private System.Windows.Forms.Button girisyapbutonu;
    }
}

