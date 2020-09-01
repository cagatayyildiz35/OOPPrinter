using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinter
{
    class EvTipiYazici : Yazici
    {

        public override bool Yazdir(Kagit kagit)
        {
            Type type = kagit.GetType();
            if (type.Name == "A4Kagit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
