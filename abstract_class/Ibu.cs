using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi.abstract_class
{
    public class Ibu : Keluarga
    {
        public override void Kewajiban()
        {
            {
                Console.WriteLine("Ibu bertanggungjawab untuk mengurus rumah tangga");
                Console.WriteLine("Ibu memiliki kewajiban untuk mengelola keuangan keluarga \n");
            }
        }
    }
}
