using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazlab_1_Proje_1
{
    class noktalar
    {
         private double xKoor;
        public double XKoor { get => xKoor; set => xKoor = value; }

        private double yKoor;
        public double YKoor { get => yKoor; set => yKoor = value; }

        private int id;
        public int Id { get => id; set => id = value; }

        private string durum;
        public string Durum { get => durum; set => durum = value; }
    }
}
