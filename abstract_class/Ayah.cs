using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi.abstract_class
{
    public class Ayah : Keluarga
    {
        public override void Kewajiban()
        {
            Console.WriteLine("Ayah bertanggungjawab untuk memimpin keluarga");
            Console.WriteLine("Ayah memiliki kewajiban untuk mencari nafkah bagi keluarga \n");
        }
    }
}
