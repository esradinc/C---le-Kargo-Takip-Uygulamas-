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
    public partial class Sifredegistirme : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Sifredegistirme()
        {
            InitializeComponent();
        }

        private void Sifredegistirme_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Baglanti basarili");
            }
            else
            {
                MessageBox.Show("Baglanti basarili degil.");
            }
        }

        private async void degistirbutonu_Click(object sender, EventArgs e)
        {
            var kullanici = new kullanicilar()
            {
                kullaniciadi = kullaniciadialani.Text,
                sifre = yenisifrealani.Text,
                
            };
            FirebaseResponse response = await client.UpdateAsync("kullanici/" + kullaniciadialani.Text, kullanici);
            kullanicilar sonuc = response.ResultAs<kullanicilar>();
            this.Visible = false;
            girisyap gec = new girisyap();
            gec.ShowDialog();

        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            girisyap gec = new girisyap();
            gec.ShowDialog();
        }
    }
}
