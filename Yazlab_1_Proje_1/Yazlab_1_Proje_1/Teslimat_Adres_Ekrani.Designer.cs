
namespace Yazlab_1_Proje_1
{
    partial class Teslimat_Adres_Ekrani
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.adresalani = new System.Windows.Forms.RichTextBox();
            this.eklebutonu = new System.Windows.Forms.Button();
            this.boylamgir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadbutonu = new System.Windows.Forms.Button();
            this.enlemgir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kargoidgir = new System.Windows.Forms.TextBox();
            this.musteriadigir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geributonu
            // 
            this.geributonu.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geributonu.Location = new System.Drawing.Point(1171, 12);
            this.geributonu.Name = "geributonu";
            this.geributonu.Size = new System.Drawing.Size(62, 31);
            this.geributonu.TabIndex = 19;
            this.geributonu.Text = "<";
            this.geributonu.UseVisualStyleBackColor = true;
            this.geributonu.Click += new System.EventHandler(this.geributonu_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(593, 602);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(593, 590);
            this.map.TabIndex = 21;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // adresalani
            // 
            this.adresalani.Location = new System.Drawing.Point(699, 355);
            this.adresalani.Name = "adresalani";
            this.adresalani.Size = new System.Drawing.Size(249, 175);
            this.adresalani.TabIndex = 29;
            this.adresalani.Text = "";
            // 
            // eklebutonu
            // 
            this.eklebutonu.Location = new System.Drawing.Point(850, 538);
            this.eklebutonu.Name = "eklebutonu";
            this.eklebutonu.Size = new System.Drawing.Size(98, 30);
            this.eklebutonu.TabIndex = 27;
            this.eklebutonu.Text = "ekle";
            this.eklebutonu.UseVisualStyleBackColor = true;
            this.eklebutonu.Click += new System.EventHandler(this.eklebutonu_Click);
            // 
            // boylamgir
            // 
            this.boylamgir.Location = new System.Drawing.Point(807, 107);
            this.boylamgir.Name = "boylamgir";
            this.boylamgir.Size = new System.Drawing.Size(141, 22);
            this.boylamgir.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Boylam:";
            // 
            // loadbutonu
            // 
            this.loadbutonu.Location = new System.Drawing.Point(699, 147);
            this.loadbutonu.Name = "loadbutonu";
            this.loadbutonu.Size = new System.Drawing.Size(103, 30);
            this.loadbutonu.TabIndex = 24;
            this.loadbutonu.Text = "load";
            this.loadbutonu.UseVisualStyleBackColor = true;
            // 
            // enlemgir
            // 
            this.enlemgir.Location = new System.Drawing.Point(807, 55);
            this.enlemgir.Name = "enlemgir";
            this.enlemgir.Size = new System.Drawing.Size(141, 22);
            this.enlemgir.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Enlem:";
            // 
            // kargoidgir
            // 
            this.kargoidgir.Location = new System.Drawing.Point(839, 205);
            this.kargoidgir.Name = "kargoidgir";
            this.kargoidgir.Size = new System.Drawing.Size(100, 22);
            this.kargoidgir.TabIndex = 36;
            // 
            // musteriadigir
            // 
            this.musteriadigir.Location = new System.Drawing.Point(839, 264);
            this.musteriadigir.Name = "musteriadigir";
            this.musteriadigir.Size = new System.Drawing.Size(100, 22);
            this.musteriadigir.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Musteri Lokasyonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Musteri Adi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kargo Id";
            // 
            // bul
            // 
            this.bul.Location = new System.Drawing.Point(676, 538);
            this.bul.Name = "bul";
            this.bul.Size = new System.Drawing.Size(98, 30);
            this.bul.TabIndex = 37;
            this.bul.Text = "bul";
            this.bul.UseVisualStyleBackColor = true;
            this.bul.Click += new System.EventHandler(this.bul_Click);
            // 
            // Teslimat_Adres_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 602);
            this.Controls.Add(this.bul);
            this.Controls.Add(this.kargoidgir);
            this.Controls.Add(this.musteriadigir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adresalani);
            this.Controls.Add(this.eklebutonu);
            this.Controls.Add(this.boylamgir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadbutonu);
            this.Controls.Add(this.enlemgir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.geributonu);
            this.Name = "Teslimat_Adres_Ekrani";
            this.Text = "Teslimat_Adres_Ekrani";
            this.Load += new System.EventHandler(this.Teslimat_Adres_Ekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button geributonu;
        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.RichTextBox adresalani;
        private System.Windows.Forms.Button eklebutonu;
        private System.Windows.Forms.TextBox boylamgir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadbutonu;
        private System.Windows.Forms.TextBox enlemgir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kargoidgir;
        private System.Windows.Forms.TextBox musteriadigir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bul;
    }
}