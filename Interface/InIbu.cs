using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi.Interface
{
    class InIbu : IKeluarga, IMasyarakat
    {

        public void Kewajiban()
        {
            Console.WriteLine("Ibu bertanggungjawab untuk mengurus rumah tangga");
            Console.WriteLine("Ibu memiliki kewajiban untuk mengelola keuangan keluarga");
        }
        public void Kegiatan()
        {
            Console.WriteLine("Ibu wajib mengikuti kegiatan arisan di hari minggu  \n");
        }


    }
}
