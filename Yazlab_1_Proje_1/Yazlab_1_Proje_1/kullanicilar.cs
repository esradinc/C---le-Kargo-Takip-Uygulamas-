using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazlab_1_Proje_1
{
    class kullanicilar
    {
       
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }

        private static string error = "hata var.";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(kullanicilar kullanici1 , kullanicilar kullanici2)
        {
            if(kullanici1==null || kullanici2 == null)
            {
                return false;
            }
            if (kullanici1.kullaniciadi != kullanici2.kullaniciadi)
            {
                error = "kullanici adi yok";
                return false;
            }
            else if (kullanici1.sifre != kullanici2.sifre)
            {
                error = "kullanici adi ve sifre eslesmiyor.";
                return false;
            }
            return true;  
        }
    }
}
