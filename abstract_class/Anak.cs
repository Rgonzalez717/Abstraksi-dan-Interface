using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraksi.abstract_class
{
    public class Anak : Keluarga
    {
        public override void Kewajiban()
        {
            Console.WriteLine("Seorang anak wajib berbakti kepada kedua orangtua");
            Console.WriteLine("Anak memiliki kewajiban untuk belajar dengan giat");
            Console.WriteLine("Anak memiliki kewajiban untuk menyelesaikan pendidikan \n");
        }
    }
}
