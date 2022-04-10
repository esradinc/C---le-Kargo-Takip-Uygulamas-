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
    public partial class Kargosilme : Form
    {
        KargolariGoruntule frm = new KargolariGoruntule();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Kargosilme()
        {
            InitializeComponent();
        }
        private void Kargosilme_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
               // MessageBox.Show("Baglanti basarili");
            }
            else
            {
                MessageBox.Show("Baglanti basarili degil.");
            }
        }
        private async void silbutonu_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteAsync("kargolar/"+kargoidgir.Text);
            MessageBox.Show("silindi");


            frm.KargolariGoruntule_Load(null, null);
        }

        private async void bulbutonu_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("kargolar/" + kargoidgir.Text);
            kargolar kargo = response.ResultAs<kargolar>();
            kargoidgir.Text = kargo.KargoId;
            musteriadigir.Text = kargo.MusteriAdi;
            adresgir.Text = kargo.MusteriLokasyonu;
            MessageBox.Show("bulundu.");
        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teslimat_Durum_Ekrani gec = new Teslimat_Durum_Ekrani();
            gec.ShowDialog();
        }
    }
}
