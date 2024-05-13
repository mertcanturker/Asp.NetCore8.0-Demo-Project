using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //}

        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selam hi hello bonjour";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kısa = 10;
            int uzun = 20;
            int sonuc = 2 * ( kısa + uzun );
            return sonuc;
        }

        string cumle()
        {
            string c = "Küçük Hanımlar Küçük Beyler Sizler Hepiniz Geleceğin Birer Gülü,Parlayan, Işık Saçan Yıldızı Olacaksınız...";
            return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void Kullanıcı(string kullaniciadi)
        {
            ViewBag.v = kullaniciadi;
        }

        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Faktoriyel(int p)
        {
            // 6! --> 1*2*3*4
            //1*1=1
            //1*2=2
            //2*3=6
            //6*4=24
            int f = 1;
            for(int i = 1;i<=p;i++)
            {
                f = f * i;
            }
            return f;
        }

        public IActionResult Index()
        {
            mesajlar();
            MesajListesi("Parametre ismi");
            Kullanıcı("mertcan123");
            ViewBag.tp = Topla(20,35);
            return View();
        }

        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            Kullanıcı("Mertcan000");
            ViewBag.faktor = Faktoriyel(6);
            return View();
        }

        public IActionResult Musteriler()
        {
            ViewBag.d=cumle();
            Kullanıcı("admin004");
            return View();
        }

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();

            sehirler.Ad = "Kiev";
            sehirler.ID = 1;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";


            ViewBag.v1 = sehirler.ID;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;

            sehirler.ID = 2;
            sehirler.Ad = "Üsküp";
            sehirler.Ulke = "Makedonya";
            sehirler.Nufus = 500000;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Sarı";

            ViewBag.z1 = sehirler.ID;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;

            return View();
        }

    }
}
