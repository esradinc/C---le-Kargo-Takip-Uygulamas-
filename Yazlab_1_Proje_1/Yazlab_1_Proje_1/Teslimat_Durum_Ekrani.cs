using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab_1_Proje_1
{
    public partial class Teslimat_Durum_Ekrani : Form
    {
        public Teslimat_Durum_Ekrani()
        {
            InitializeComponent();
        }

        private void Teslimat_Durum_Ekrani_Load(object sender, EventArgs e)
        {

        }

        private void eklemebutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            kargoekleme ekle = new kargoekleme();
            ekle.ShowDialog();
        }

        private void guncellemebutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            kargoguncelleme guncelle = new kargoguncelleme();
            guncelle.ShowDialog();
        }

        private void silmebutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Kargosilme sil = new Kargosilme();
            sil.ShowDialog();
        }

        private void teslimatbilgisibutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teslimatbilgisi bilgi = new Teslimatbilgisi();
            bilgi.ShowDialog();
        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            kullanicisayfasi gec = new kullanicisayfasi();
            gec.ShowDialog();
        }
    }
}
