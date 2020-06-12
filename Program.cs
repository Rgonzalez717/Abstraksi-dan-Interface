using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using abstraksi.abstract_class;
using abstraksi.Interface;
namespace abstraksi

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class");
            Console.WriteLine("==========================\n");

            Keluarga keluarga;
            keluarga = new Ayah();
            keluarga.Kewajiban();

           
            keluarga = new Ibu();
            keluarga.Kewajiban();

          
            keluarga = new Anak();
            keluarga.Kewajiban();

            Console.WriteLine("\nInterface");
            Console.WriteLine("==========================\n");

            IKeluarga ikeluarga;
            IMasyarakat imasyarakat;

            ikeluarga = new InAyah();
            ikeluarga.Kewajiban();

            imasyarakat= new InAyah();
            imasyarakat.Kegiatan();


           ikeluarga = new InIbu();
           ikeluarga.Kewajiban();

            imasyarakat = new InIbu();
            imasyarakat.Kegiatan();


            ikeluarga = new InAnak();
            ikeluarga.Kewajiban();

            imasyarakat = new InAnak();
            imasyarakat.Kegiatan();

            Console.ReadKey();
        }
    }
}
