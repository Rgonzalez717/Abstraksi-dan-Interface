using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi.Interface
{
    class InAnak : IKeluarga, IMasyarakat
    {

        public void Kewajiban()
        {
            Console.WriteLine("Seorang anak wajib berbakti kepada kedua orangtua");
            Console.WriteLine("Anak memiliki kewajiban untuk belajar dengan giat");
            Console.WriteLine("Anak memiliki kewajiban untuk menyelesaikan pendidikan");
        }
        public void Kegiatan()
        {
            Console.WriteLine("Anak wajib mengikuti kegiatan bersama karang taruna\n");
        }


    }
}
