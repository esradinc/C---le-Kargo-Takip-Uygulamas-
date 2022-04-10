using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Yazlab_1_Proje_1
{
    public partial class Teslimatbilgisi : Form
    {
        List<string> adresler = new List<string>();
        public Teslimatbilgisi()
        {
            InitializeComponent();
        }

        private async void Teslimatbilgisi_Load(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
                BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FirebaseClient(config);
            var data = await client.GetAsync("kargolar");

            List<kargolar> data1 = data.ResultAs<List<kargolar>>();
            adresler = new List<string>();
     
            foreach (var data2 in data1)
            {
                if (data2 == null)
                    continue;
                dataGridView1.Rows.Add(data2.KargoId, data2.MusteriAdi, data2.MusteriLokasyonu);

            }
            
           
        }

        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teslimat_Durum_Ekrani gec = new Teslimat_Durum_Ekrani();
            gec.ShowDialog();
        }
    }
}
