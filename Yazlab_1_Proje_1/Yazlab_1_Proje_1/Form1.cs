using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;



namespace Yazlab_1_Proje_1
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
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

    
        private void kayitolbutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            kayitol kayit = new kayitol();
            kayit.ShowDialog();

        }

        private void girisyapbutonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            girisyap giris = new girisyap();
            giris.ShowDialog();
        }
        private void ThreadStart()
        {  
            Application.Run(new KargolariGoruntule());
        }

    }
}