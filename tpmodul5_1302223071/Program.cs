using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302223071
{
    class Program
    {
        class HaloGeneric {
            
            public void SapaUser(String nama)
            {
                Console.WriteLine("Halo User " + nama);
            }
        }

        static void Main(string[] args)
        {
            String nama;
            Console.WriteLine("Masukkan Nama User : ");
            nama = Console.ReadLine();
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser(nama);
            Console.Read();
        }

    }
}
