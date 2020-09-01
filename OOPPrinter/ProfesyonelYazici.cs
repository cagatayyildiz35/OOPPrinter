using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinter
{
    class ProfesyonelYazici : Yazici
    {
        public override bool Yazdir(Kagit kagit)
        {
            return true;
        }
    }
}
// Ev tipi yazıcı yalnızca A4 tipindeki kağıtlarla çalışırken Profesyonel yazıcı birden fazla kağıt tipine baskı alabilecektir.

