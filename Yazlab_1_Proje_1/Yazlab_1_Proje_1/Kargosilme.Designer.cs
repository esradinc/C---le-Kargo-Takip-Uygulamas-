
namespace Yazlab_1_Proje_1
{
    partial class Kargosilme
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
            this.silbutonu = new System.Windows.Forms.Button();
            this.bulbutonu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kargo = new System.Windows.Forms.Label();
            this.geributonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kargoidgir
            // 
            this.kargoidgir.Location = new System.Drawing.Point(207, 83);
            this.kargoidgir.Name = "kargoidgir";
            this.kargoidgir.Size = new System.Drawing.Size(100, 22);
            this.kargoidgir.TabIndex = 15;
            // 
            // musteriadigir
            // 
            this.musteriadigir.Location = new System.Drawing.Point(207, 203);
            this.musteriadigir.Name = "musteriadigir";
            this.musteriadigir.Size = new System.Drawing.Size(100, 22);
            this.musteriadigir.TabIndex = 14;
            // 
            // adresgir
            // 
            this.adresgir.Location = new System.Drawing.Point(207, 251);
            this.adresgir.Name = "adresgir";
            this.adresgir.Size = new System.Drawing.Size(100, 22);
            this.adresgir.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Musteri Lokasyonu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Musteri Adi :";
            // 
            // silbutonu
            // 
            this.silbutonu.Location = new System.Drawing.Point(234, 334);
            this.silbutonu.Name = "silbutonu";
            this.silbutonu.Size = new System.Drawing.Size(128, 29);
            this.silbutonu.TabIndex = 9;
            this.silbutonu.Text = "SIL";
            this.silbutonu.UseVisualStyleBackColor = true;
            this.silbutonu.Click += new System.EventHandler(this.silbutonu_Click);
            // 
            // bulbutonu
            // 
            this.bulbutonu.Location = new System.Drawing.Point(67, 129);
            this.bulbutonu.Name = "bulbutonu";
            this.bulbutonu.Size = new System.Drawing.Size(240, 30);
            this.bulbutonu.TabIndex = 16;
            this.bulbutonu.Text = "BUL";
            this.bulbutonu.UseVisualStyleBackColor = true;
            this.bulbutonu.Click += new System.EventHandler(this.bulbutonu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kargoyu silmek ister misinz?";
            // 
            // kargo
            // 
            this.kargo.AutoSize = true;
            this.kargo.Location = new System.Drawing.Point(64, 86);
            this.kargo.Name = "kargo";
            this.kargo.Size = new System.Drawing.Size(65, 17);
            this.kargo.TabIndex = 18;
            this.kargo.Text = "Kargo Id:";
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
            // Kargosilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.geributonu);
            this.Controls.Add(this.kargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bulbutonu);
            this.Controls.Add(this.kargoidgir);
            this.Controls.Add(this.musteriadigir);
            this.Controls.Add(this.adresgir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.silbutonu);
            this.Name = "Kargosilme";
            this.Text = "Kargosilme";
            this.Load += new System.EventHandler(this.Kargosilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kargoidgir;
        private System.Windows.Forms.TextBox musteriadigir;
        private System.Windows.Forms.TextBox adresgir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button silbutonu;
        private System.Windows.Forms.Button bulbutonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kargo;
        private System.Windows.Forms.Button geributonu;
    }
}