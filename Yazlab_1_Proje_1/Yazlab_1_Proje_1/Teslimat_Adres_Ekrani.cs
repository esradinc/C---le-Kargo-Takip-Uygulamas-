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
using FireSharp.Response;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Yazlab_1_Proje_1
{
    public partial class Teslimat_Adres_Ekrani : Form
    {
        KargolariGoruntule frm = new KargolariGoruntule();

        IFirebaseClient client;


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
            BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
        };

       

 
        private List<PointLatLng> _points;
        public Teslimat_Adres_Ekrani()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void Teslimat_Adres_Ekrani_Load(object sender, EventArgs e)
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

            GMapProviders.GoogleMap.ApiKey = @"AIzaSyDrsgyyDOiqjl14g2WypnnK1iWehYFmtRM";
          
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.SetPositionByKeywords("Ankara");
            map.MinZoom = 1;
            map.MaxZoom = 1000;
            map.Zoom = 10;

        }
       
        private void geributonu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            kullanicisayfasi gec = new kullanicisayfasi();
            gec.ShowDialog();
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                enlemgir.Text = lat + "";
                boylamgir.Text = lng + "";

                LoadMap(point);


                //AddMarker(point);
                var addresses = GetAddress(point);
                if (addresses != null)
                    adresalani.Text =  addresses[0];
                else
                    adresalani.Text = "yok";

            }
        }
        private void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }
        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }
        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                List<String> addresses = new List<String>();
                foreach (var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;

        }

        private List<Placemark> temp()
        {
            List<Placemark> placemarks = new List<Placemark>();
            return placemarks;
        }

        private void eklebutonu_Click(object sender, EventArgs e)
        {
            kargolar kargo = new kargolar()
            {
                KargoId = kargoidgir.Text,
                MusteriAdi = musteriadigir.Text,
                MusteriLokasyonu = adresalani.Text
            };
            SetResponse set = client.Set(@"kargolar/" + kargoidgir.Text, kargo);
            MessageBox.Show("Kaydedildi.");
            frm.KargolariGoruntule_Load(null, null);


        }

        private async void bul_Click(object sender, EventArgs e)
        {
          
            FirebaseResponse response = await client.GetAsync("kargolar/");
            kargolar kargo = response.ResultAs<kargolar>();
            
            kargoidgir.Text = kargo.KargoId;
            musteriadigir.Text = kargo.MusteriAdi;
            adresalani.Text = kargo.MusteriLokasyonu;
        
        }

    }

}
