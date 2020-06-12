using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi.Interface
{
    class InAyah : IKeluarga , IMasyarakat
    {
        public void Kewajiban()
        {
            Console.WriteLine("Ayah bertanggungjawab untuk memimpin keluarga");
            Console.WriteLine("Ayah memiliki kewajiban untuk mencari nafkah bagi keluarga");
        }

        public void Kegiatan()
        {
            Console.WriteLine("Ayah wajib mengikuti kegiatan kerja bakti  \n");
        }

        
    }
}
