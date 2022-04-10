
namespace Yazlab_1_Proje_1
{
    partial class kayitol
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
            this.sifregir = new System.Windows.Forms.TextBox();
            this.kullaniciadigir = new System.Windows.Forms.TextBox();
            this.kayityapbutonu = new System.Windows.Forms.Button();
            this.kullaniciadialani = new System.Windows.Forms.Label();
            this.sifrealani = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifregir
            // 
            this.sifregir.Location = new System.Drawing.Point(182, 218);
            this.sifregir.Name = "sifregir";
            this.sifregir.Size = new System.Drawing.Size(160, 22);
            this.sifregir.TabIndex = 29;
            // 
            // kullaniciadigir
            // 
            this.kullaniciadigir.Location = new System.Drawing.Point(182, 162);
            this.kullaniciadigir.Name = "kullaniciadigir";
            this.kullaniciadigir.Size = new System.Drawing.Size(160, 22);
            this.kullaniciadigir.TabIndex = 28;
            // 
            // kayityapbutonu
            // 
            this.kayityapbutonu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayityapbutonu.Location = new System.Drawing.Point(109, 255);
            this.kayityapbutonu.Name = "kayityapbutonu";
            this.kayityapbutonu.Size = new System.Drawing.Size(141, 34);
            this.kayityapbutonu.TabIndex = 27;
            this.kayityapbutonu.Text = "KAYIT OL";
            this.kayityapbutonu.UseVisualStyleBackColor = true;
            this.kayityapbutonu.Click += new System.EventHandler(this.kayityapbutonu_Click);
            // 
            // kullaniciadialani
            // 
            this.kullaniciadialani.AutoSize = true;
            this.kullaniciadialani.Location = new System.Drawing.Point(178, 165);
            this.kullaniciadialani.Name = "kullaniciadialani";
            this.kullaniciadialani.Size = new System.Drawing.Size(0, 17);
            this.kullaniciadialani.TabIndex = 26;
            // 
            // sifrealani
            // 
            this.sifrealani.AutoSize = true;
            this.sifrealani.Location = new System.Drawing.Point(178, 218);
            this.sifrealani.Name = "sifrealani";
            this.sifrealani.Size = new System.Drawing.Size(0, 17);
            this.sifrealani.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kullanici adi:";
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(23, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 30;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.sifregir);
            this.Controls.Add(this.kullaniciadigir);
            this.Controls.Add(this.kayityapbutonu);
            this.Controls.Add(this.kullaniciadialani);
            this.Controls.Add(this.sifrealani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "kayitol";
            this.Text = "kayitol";
            this.Load += new System.EventHandler(this.kayitol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifregir;
        private System.Windows.Forms.TextBox kullaniciadigir;
        private System.Windows.Forms.Button kayityapbutonu;
        private System.Windows.Forms.Label kullaniciadialani;
        private System.Windows.Forms.Label sifrealani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button geributonu;
    }
}