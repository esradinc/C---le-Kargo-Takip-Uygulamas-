
namespace Yazlab_1_Proje_1
{
    partial class kullanicisayfasi
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
            this.label2 = new System.Windows.Forms.Label();
            this.adresbutonu = new System.Windows.Forms.Button();
            this.durumbutonu = new System.Windows.Forms.Button();
            this.geributonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teslimat durum ekranına gitmek için tıklayın.";
            // 
            // adresbutonu
            // 
            this.adresbutonu.Location = new System.Drawing.Point(180, 166);
            this.adresbutonu.Name = "adresbutonu";
            this.adresbutonu.Size = new System.Drawing.Size(128, 33);
            this.adresbutonu.TabIndex = 2;
            this.adresbutonu.Text = "GIT";
            this.adresbutonu.UseVisualStyleBackColor = true;
            this.adresbutonu.Click += new System.EventHandler(this.adresbutonu_Click);
            // 
            // durumbutonu
            // 
            this.durumbutonu.Location = new System.Drawing.Point(180, 268);
            this.durumbutonu.Name = "durumbutonu";
            this.durumbutonu.Size = new System.Drawing.Size(132, 33);
            this.durumbutonu.TabIndex = 3;
            this.durumbutonu.Text = "GIT";
            this.durumbutonu.UseVisualStyleBackColor = true;
            this.durumbutonu.Click += new System.EventHandler(this.durumbutonu_Click);
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(262, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(154, 30);
            this.geributonu.TabIndex = 19;
            this.geributonu.Text = "CIKIS YAP";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Teslimat adres ekranına gitmek icin tıklayın.";
            // 
            // kullanicisayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.durumbutonu);
            this.Controls.Add(this.adresbutonu);
            this.Controls.Add(this.label2);
            this.Name = "kullanicisayfasi";
            this.Text = "kullanicisayfasi";
            this.Load += new System.EventHandler(this.kullanicisayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adresbutonu;
        private System.Windows.Forms.Button durumbutonu;
        private System.Windows.Forms.Button geributonu;
        private System.Windows.Forms.Label label1;
    }
}