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

    
    public partial class kargoekleme : Form
    {
        KargolariGoruntule frm = new KargolariGoruntule();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public kargoekleme()
        {
            InitializeComponent();
        }

        private void kargoekleme_Load(object sender, EventArgs e)
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

        private void eklebutonu_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(kargoidgir.Text) &&
            string.IsNullOrWhiteSpace(musteriadigir.Text) &&
            string.IsNullOrWhiteSpace(adresgir.Text))
            {
                MessageBox.Show("Tum alanlari doldurun.");
                return;
            }
            #endregion
            kargolar kargo = new kargolar()
            {
                KargoId = kargoidgir.Text,
                MusteriAdi = musteriadigir.Text,
                MusteriLokasyonu = adresgir.Text
            };
            SetResponse set = client.Set(@"kargolar/" + kargoidgir.Text, kargo);
           
            MessageBox.Show("Kaydedildi.");
            Temizle();

            frm.KargolariGoruntule_Load(null, null);
        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teslimat_Durum_Ekrani gec = new Teslimat_Durum_Ekrani();
            gec.ShowDialog();
        }
        public void Temizle()
        {
                kargoidgir.Text = " ";
                musteriadigir.Text = " ";
                adresgir.Text = " ";
               
        }
    }
}
