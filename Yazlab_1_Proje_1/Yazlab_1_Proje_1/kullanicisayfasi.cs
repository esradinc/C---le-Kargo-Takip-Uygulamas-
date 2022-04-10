using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Yazlab_1_Proje_1
{
    public partial class kullanicisayfasi : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

        public kullanicisayfasi()
        {
            InitializeComponent();
        }

        private async void kullanicisayfasi_Load(object sender, EventArgs e)
        {

        }

        private void adresbutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teslimat_Adres_Ekrani adresekrani = new Teslimat_Adres_Ekrani();
            adresekrani.ShowDialog();
        }

        private void durumbutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teslimat_Durum_Ekrani durumekrani = new Teslimat_Durum_Ekrani();
            durumekrani.ShowDialog();
        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            girisyap gec = new girisyap();
            gec.ShowDialog();
        }

    }
}
