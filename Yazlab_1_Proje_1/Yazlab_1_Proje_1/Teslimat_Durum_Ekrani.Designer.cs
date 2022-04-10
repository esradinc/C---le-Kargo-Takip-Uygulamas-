
namespace Yazlab_1_Proje_1
{
    partial class Teslimat_Durum_Ekrani
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
            this.silmebutonu = new System.Windows.Forms.Button();
            this.teslimatbilgisibutonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eklemebutonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guncellemebutonu = new System.Windows.Forms.Button();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // silmebutonu
            // 
            this.silmebutonu.Location = new System.Drawing.Point(300, 257);
            this.silmebutonu.Name = "silmebutonu";
            this.silmebutonu.Size = new System.Drawing.Size(140, 23);
            this.silmebutonu.TabIndex = 1;
            this.silmebutonu.Text = "SIL";
            this.silmebutonu.UseVisualStyleBackColor = true;
            this.silmebutonu.Click += new System.EventHandler(this.silmebutonu_Click);
            // 
            // teslimatbilgisibutonu
            // 
            this.teslimatbilgisibutonu.Location = new System.Drawing.Point(300, 306);
            this.teslimatbilgisibutonu.Name = "teslimatbilgisibutonu";
            this.teslimatbilgisibutonu.Size = new System.Drawing.Size(140, 23);
            this.teslimatbilgisibutonu.TabIndex = 2;
            this.teslimatbilgisibutonu.Text = "GIT";
            this.teslimatbilgisibutonu.UseVisualStyleBackColor = true;
            this.teslimatbilgisibutonu.Click += new System.EventHandler(this.teslimatbilgisibutonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kargo eklemek icin tıkla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kargo silmek için tıkla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teslimat bilgisi girmek için tıkla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "kargo listelenecek";
            // 
            // eklemebutonu
            // 
            this.eklemebutonu.Location = new System.Drawing.Point(300, 166);
            this.eklemebutonu.Name = "eklemebutonu";
            this.eklemebutonu.Size = new System.Drawing.Size(140, 23);
            this.eklemebutonu.TabIndex = 7;
            this.eklemebutonu.Text = "EKLE";
            this.eklemebutonu.UseVisualStyleBackColor = true;
            this.eklemebutonu.Click += new System.EventHandler(this.eklemebutonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kargo guncellemek için tıkla";
            // 
            // guncellemebutonu
            // 
            this.guncellemebutonu.Location = new System.Drawing.Point(300, 209);
            this.guncellemebutonu.Name = "guncellemebutonu";
            this.guncellemebutonu.Size = new System.Drawing.Size(140, 23);
            this.guncellemebutonu.TabIndex = 9;
            this.guncellemebutonu.Text = "GUNCELLE";
            this.guncellemebutonu.UseVisualStyleBackColor = true;
            this.guncellemebutonu.Click += new System.EventHandler(this.guncellemebutonu_Click);
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(12, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 19;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // Teslimat_Durum_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.guncellemebutonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eklemebutonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teslimatbilgisibutonu);
            this.Controls.Add(this.silmebutonu);
            this.Name = "Teslimat_Durum_Ekrani";
            this.Text = "Teslimat_Durum_Ekrani";
            this.Load += new System.EventHandler(this.Teslimat_Durum_Ekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button silmebutonu;
        private System.Windows.Forms.Button teslimatbilgisibutonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eklemebutonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guncellemebutonu;
        private System.Windows.Forms.Button geributonu;
    }
}