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
    public partial class KargolariGoruntule : Form
    {
        int lastDataCount = 0;
        private List<PointLatLng> _points = new List<PointLatLng>();
        private List<noktalar> koordinatlar = new List<noktalar>();
        GMapOverlay routes = new GMapOverlay("routes");
        List<string> adresler = new List<string>();
        Timer tmr = new Timer();
        bool isFirstRun = true;
        

        public KargolariGoruntule()
        {
            InitializeComponent();
            tmr.Enabled = true;
            tmr.Tick += Tmr_Tick;
            tmr.Interval = 4000;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        public async void getData()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "mCpc4XHF4uI0HLAmaHhdtaFHnmYrvZ8NumVK7XQx ",
                BasePath = "https://kargotakip-8ab98-default-rtdb.firebaseio.com/"
            };


            IFirebaseClient client = new FirebaseClient(config);
            var data = await client.GetAsync("kargolar");


            List<kargolar> data1 = data.ResultAs<List<kargolar>>();
            init(data1);

        }

        public void init(List<kargolar> data1)
        {
            if (!isFirstRun)
            {
                if (lastDataCount >= data1.Count)
                    return;
            }
          
            adresler = new List<string>();

            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            
            map.Invoke(() => map.CacheLocation = "@cache");
            map.Invoke(() => map.MapProvider = GMapProviders.GoogleMap);
            map.Invoke(() => map.SetPositionByKeywords("Ankara"));
            map.Invoke(() => map.MinZoom = 1);
            map.Invoke(() => map.MaxZoom = 1000);
            map.Invoke(() => map.Zoom = 10);

         
            
       

            foreach (var data2 in data1)
            {

                if (data2 == null)
                    continue;

                adresler.Add(data2.MusteriLokasyonu);   

            }

            for (int k = 0; k < adresler.Count; k++)
            {
                Console.WriteLine("liste:" + adresler[k]);

            }
            List();
            EnkisaYolBul();
         
            lastDataCount = data1.Count;
            double lastZoom = 0;
          
                map.Invoke(() => map.Zoom = 11);
                lastZoom = map.Invoke(() => map.Zoom);
                map.Invoke(() => map.Zoom = lastZoom);
                map.Invoke(() => map.Refresh());
                
            
            isFirstRun = false;


        }
        public void KargolariGoruntule_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void List()
        {
            koordinatlar = new List<noktalar>();
            _points = new List<PointLatLng>();
            for (int i = 0; i < adresler.Count; i++)
            {
                noktalar nokta = new noktalar();

                if (!adresler[i].ToString().Trim().Equals(""))
                {

                    GeoCoderStatusCode statusCode;
                    var pointLatLng = GoogleMapProvider.Instance.GetPoint(adresler[i].ToString().Trim(), out statusCode);
                    if (statusCode == GeoCoderStatusCode.OK)
                    {
                        var pt = pointLatLng ?? default(PointLatLng);

                        _points.Add(pt);

                        nokta.XKoor = pt.Lat;
                        nokta.YKoor = pt.Lng;
                        nokta.Id = i;
                        koordinatlar.Add(nokta);

                        AddMarker(pt);
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong.  Returned Status: " + statusCode);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Data To Load");
                }
            }
        }

        private void EnkisaYolBul()
        {
            int currentId = 0;
            double enKisaUzaklik = double.MaxValue;
            int newId = 0;

            List<noktalar> List2 = new List<noktalar>();
            List<int> idList = new List<int>();
            noktalar currentKayit = new noktalar();
            PointLatLng currentNokta;



            idList.Add(0);
            while (koordinatlar.Count > 1)
            {
                currentKayit = koordinatlar.Where(k => k.Id == currentId).First();
                currentNokta = _points[currentId];
                enKisaUzaklik = double.MaxValue;

                List2 = koordinatlar.Where(k => k.Id != currentId).Select(k => k).ToList();


                for (int i = 0; i < List2.Count; i++)
                {

                    var route = GoogleMapProvider.Instance
                  .GetRoute(currentNokta, _points[List2[i].Id], false, false, 14);

                    if (route.Distance < enKisaUzaklik)
                    {
                        enKisaUzaklik = route.Distance;
                        newId = List2[i].Id;
                    }

                }

                noktalar itemToRemove = koordinatlar.SingleOrDefault(r => r.Id == currentId);
                if (itemToRemove != null)
                    koordinatlar.Remove(itemToRemove);

                currentId = newId;

                idList.Add(currentId);



            }


            for (int u = 0; u < idList.Count - 1; u++)
            {

                int renk;

                if (u == 0)
                    renk = 1;
                else if (u == 1)
                    renk = 2;
                else if (u == 2)
                    renk = 3;
                else if (u == 3)
                    renk = 4;
                else if (u == 4)
                    renk = 5;
                else
                    renk = 6;

                rotaciz(_points[u], _points[u + 1], renk);

            }
            for (int u = 0; u <_points.Count - 1; u++)
            {

                //Console.WriteLine("liste:" + List2[u]);
                Console.WriteLine("liste nokra:" + 
                    _points[u]);
            }
            map.Invoke(() => map.Overlays.Add(routes));

        }
  
        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
           
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Invoke(() => map.Overlays.Add(markers));
        }
            
        
        public void rotaciz(PointLatLng nokta1, PointLatLng nokta2, int renk)
        {
            var route = GoogleMapProvider.Instance
               .GetRoute(nokta1, nokta2, false, false, 14);
            var r = new GMapRoute(route.Points, "My Route");

            if (renk == 1)
            {
                r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Green, 5)

                };

            }

            else if (renk == 2)
            {

                r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Yellow, 5)
                };
            }

            else if (renk == 3)
            {

                r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Red, 5)
                };
            }

            else if (renk == 4)
            {

                r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Blue, 5)
                };
            }
            else if (renk == 5)
            {

                r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Pink, 5)
                };
            }
            else if (renk == 6)
            {

                r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Orange, 5)
                };
            }
                routes.Routes.Add(r);
                map.Invoke(() => map.Overlays.Add(routes));

            }
        public void enkisaYol()
        {
            var route = GoogleMapProvider.Instance
           .GetRoute(_points[0], _points[1], false, false, 14);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getData();
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
