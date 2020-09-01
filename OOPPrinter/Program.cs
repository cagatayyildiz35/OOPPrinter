using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            EvTipiYazici evtipi = new EvTipiYazici();

            A3Kagit kg = new A3Kagit();

            bool sonuc =  evtipi.Yazdir(kg);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
