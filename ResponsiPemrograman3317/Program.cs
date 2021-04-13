using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3317
{
    class Program
    {
       static void Main(string[] args)
       {
            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();

            karyawan1.Nik = "190302123";
            karyawan1.Nama = "Prim";
            karyawan1.Gaji = 3000000;

            karyawan2.Nik = "190302124";
            karyawan2.Nama = "Fiat";
            karyawan2.Gaji = 2000000;



            Console.WriteLine("No" + " " + "NIK/Nama" + "            " + "Gaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1." + " " + karyawan1.Nik + " " + karyawan1.Nama + "        " + karyawan1.Gaji);
            Console.WriteLine("2." + " " + karyawan2.Nik + " " + karyawan2.Nama + "        " + karyawan2.Gaji);

            Console.WriteLine();
            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%");
            Console.WriteLine();

            int gajinaik = karyawan1.Gaji * 10 / 100;
            karyawan1.Gaji += gajinaik;
            int gajinaikk = karyawan2.Gaji * 10 / 100;
            karyawan2.Gaji += gajinaikk;
            Console.WriteLine("No" + " " + "NIK/Nama" + "            " + "Gaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1." + " " + karyawan1.Nik + " " + karyawan1.Nama + "        " + karyawan1.Gaji);
            Console.WriteLine("2." + " " + karyawan2.Nik + " " + karyawan2.Nama + "        " + karyawan2.Gaji);

            Console.ReadKey();

        }
    }
}
