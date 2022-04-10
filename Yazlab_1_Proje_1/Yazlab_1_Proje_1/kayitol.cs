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
    public partial class kayitol : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public kayitol()
        {
            InitializeComponent();
        }

        private void kayitol_Load(object sender, EventArgs e)
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

        private void kayityapbutonu_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(kullaniciadigir.Text) &&
            string.IsNullOrWhiteSpace(sifregir.Text))
            {
                MessageBox.Show("Tum alanlari doldurun.");
                return;
            }
            #endregion
            kullanicilar kullanicilar = new kullanicilar()
            {
                kullaniciadi = kullaniciadigir.Text,
                sifre = sifregir.Text
        };
            SetResponse set = client.Set(@"kullanici/"+ kullaniciadigir.Text, kullanicilar);
            MessageBox.Show("Kaydedildi.");
            this.Visible = false;
            Form1 gec = new Form1();
            gec.ShowDialog();

        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 gec = new Form1();
            gec.ShowDialog();
        }
    }
}
