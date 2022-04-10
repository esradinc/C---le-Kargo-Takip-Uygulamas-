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
    public partial class girisyap : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        }; 

        IFirebaseClient client;
        
        public girisyap()
        {
            InitializeComponent();
        }

        private void girisyap_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                //MessageBox.Show("Baglanti basarili");
            }
            else
            {
                MessageBox.Show("Baglanti basarili degil.");
            }

        }

        private void girisyapbutonu_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(kullaniciadigir.Text) &&
            string.IsNullOrWhiteSpace(sifregir.Text))
            {
                MessageBox.Show("Tum alanlari doldurun.");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"kullanici/" + kullaniciadigir.Text);
            kullanicilar kullanici = res.ResultAs<kullanicilar>(); // veritabanı sonucu
            
            kullanicilar girilenkullanici = new kullanicilar()
            {

                kullaniciadi = kullaniciadigir.Text,
                sifre = sifregir.Text
            };
            if (kullanicilar.IsEqual(kullanici, girilenkullanici))
            {
                this.Visible = false;
                kullanicisayfasi anasayfa = new kullanicisayfasi();
                anasayfa.ShowDialog();
            }
            else
            {
                kullanicilar.ShowError();
            }
        }

        private void sifrebutonu_Click(object sender, EventArgs e)
        {
            Sifredegistirme yenisifre = new Sifredegistirme();
            yenisifre.ShowDialog();
        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 gec = new Form1();
            gec.ShowDialog();
        }
    }
}
