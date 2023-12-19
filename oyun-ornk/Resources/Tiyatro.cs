using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun_ornk.Resources
{


    internal class Tiyatro
    {
        int id;
        string oyunAd;
        string sahne;
        double fiyat;
        decimal sure;
        DateTime tarih;
        bool muzikal;



        public int Id { get => id; set => id = value; }
        public string OyunAd { get => oyunAd; set => oyunAd = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public decimal Sure { get => sure; set => sure = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }

        public Tiyatro(int id, string oyunAd, string sahne, double fiyat, decimal sure, DateTime tarih, bool muzikal)
        {
            this.Id = id;
            this.OyunAd = oyunAd;
            this.Sahne = sahne;
            this.Fiyat = fiyat;
            this.Sure = sure;
            this.Tarih = tarih;
            this.Muzikal = muzikal;
        }


    }
}
    
   