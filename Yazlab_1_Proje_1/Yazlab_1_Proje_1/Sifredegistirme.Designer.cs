
namespace Yazlab_1_Proje_1
{
    partial class Sifredegistirme
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
            this.degistirbutonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciadialani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yenisifrealani = new System.Windows.Forms.TextBox();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // degistirbutonu
            // 
            this.degistirbutonu.Location = new System.Drawing.Point(118, 228);
            this.degistirbutonu.Name = "degistirbutonu";
            this.degistirbutonu.Size = new System.Drawing.Size(139, 30);
            this.degistirbutonu.TabIndex = 0;
            this.degistirbutonu.Text = "SİFRE DEGISTIR";
            this.degistirbutonu.UseVisualStyleBackColor = true;
            this.degistirbutonu.Click += new System.EventHandler(this.degistirbutonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanici Adi:";
            // 
            // kullaniciadialani
            // 
            this.kullaniciadialani.Location = new System.Drawing.Point(190, 111);
            this.kullaniciadialani.Name = "kullaniciadialani";
            this.kullaniciadialani.Size = new System.Drawing.Size(129, 22);
            this.kullaniciadialani.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Sifre:";
            // 
            // yenisifrealani
            // 
            this.yenisifrealani.Location = new System.Drawing.Point(190, 173);
            this.yenisifrealani.Name = "yenisifrealani";
            this.yenisifrealani.Size = new System.Drawing.Size(129, 22);
            this.yenisifrealani.TabIndex = 4;
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(30, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 20;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // Sifredegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.yenisifrealani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullaniciadialani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degistirbutonu);
            this.Name = "Sifredegistirme";
            this.Text = "Sifredegistirme";
            this.Load += new System.EventHandler(this.Sifredegistirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button degistirbutonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciadialani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yenisifrealani;
        private System.Windows.Forms.Button geributonu;
    }
}