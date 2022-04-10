
namespace Yazlab_1_Proje_1
{
    partial class girisyap
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
            this.girisyapbutonu = new System.Windows.Forms.Button();
            this.kullaniciadialani = new System.Windows.Forms.Label();
            this.sifrealani = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifrebutonu = new System.Windows.Forms.Button();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifregir
            // 
            this.sifregir.Location = new System.Drawing.Point(176, 124);
            this.sifregir.Name = "sifregir";
            this.sifregir.Size = new System.Drawing.Size(160, 22);
            this.sifregir.TabIndex = 15;
            // 
            // kullaniciadigir
            // 
            this.kullaniciadigir.Location = new System.Drawing.Point(176, 72);
            this.kullaniciadigir.Name = "kullaniciadigir";
            this.kullaniciadigir.Size = new System.Drawing.Size(160, 22);
            this.kullaniciadigir.TabIndex = 14;
            // 
            // girisyapbutonu
            // 
            this.girisyapbutonu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisyapbutonu.Location = new System.Drawing.Point(97, 175);
            this.girisyapbutonu.Name = "girisyapbutonu";
            this.girisyapbutonu.Size = new System.Drawing.Size(166, 37);
            this.girisyapbutonu.TabIndex = 13;
            this.girisyapbutonu.Text = "GİRİS ";
            this.girisyapbutonu.UseVisualStyleBackColor = true;
            this.girisyapbutonu.Click += new System.EventHandler(this.girisyapbutonu_Click);
            // 
            // kullaniciadialani
            // 
            this.kullaniciadialani.AutoSize = true;
            this.kullaniciadialani.Location = new System.Drawing.Point(173, 162);
            this.kullaniciadialani.Name = "kullaniciadialani";
            this.kullaniciadialani.Size = new System.Drawing.Size(0, 17);
            this.kullaniciadialani.TabIndex = 12;
            // 
            // sifrealani
            // 
            this.sifrealani.AutoSize = true;
            this.sifrealani.Location = new System.Drawing.Point(173, 215);
            this.sifrealani.Name = "sifrealani";
            this.sifrealani.Size = new System.Drawing.Size(0, 17);
            this.sifrealani.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanici adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sifrenizi mi  unuttunuz?";
            // 
            // sifrebutonu
            // 
            this.sifrebutonu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifrebutonu.Location = new System.Drawing.Point(235, 268);
            this.sifrebutonu.Name = "sifrebutonu";
            this.sifrebutonu.Size = new System.Drawing.Size(160, 32);
            this.sifrebutonu.TabIndex = 17;
            this.sifrebutonu.Text = "Sifre degistir";
            this.sifrebutonu.UseVisualStyleBackColor = true;
            this.sifrebutonu.Click += new System.EventHandler(this.sifrebutonu_Click);
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(12, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 18;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // girisyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.sifrebutonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifregir);
            this.Controls.Add(this.kullaniciadigir);
            this.Controls.Add(this.girisyapbutonu);
            this.Controls.Add(this.kullaniciadialani);
            this.Controls.Add(this.sifrealani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "girisyap";
            this.Text = "girisyap";
            this.Load += new System.EventHandler(this.girisyap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifregir;
        private System.Windows.Forms.TextBox kullaniciadigir;
        private System.Windows.Forms.Button girisyapbutonu;
        private System.Windows.Forms.Label kullaniciadialani;
        private System.Windows.Forms.Label sifrealani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sifrebutonu;
        private System.Windows.Forms.Button geributonu;
    }
}