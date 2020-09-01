using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinter
{
    abstract class Yazici
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KagitHazne { get; set; }
        public bool YaziciDurum { get; set; }


        public static void AcKapat(Yazici yazici)
        {
            //açtı kapadı falan filan
        }

        public abstract bool Yazdir(Kagit kagit);


        //Marka
        //Model
        //Kağıt haznesi
        //Yazıcı durumu(Açık/ Kapalı)
        //•	Yazdır()
        //•	Kağıt Ekle
        //•	Kağıt Çıkar


    }
}
