using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biodata
{
    class Progran
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Today;
            DateTime born = new DateTime(2009, 04, 17);

            int diffYear = now.Year - born.Year, diffMonth = now.Month - born.Month, diffDate = now.Day - born.Day;

            Console.WriteLine($"{diffYear} {diffMonth} {diffDate}");

            if (diffDate < 0)
            {

            }

            string fName = "Nizam", mName = "Rizki", lName = "Syahputra";
            string address = "Komplek Essence Park Blok A7 No 7 RT 001 RW 013 Jl. Masjid Raya Jati Cempaka Pondok Gede";
            string bornPlace = "Jakarta", bornMonth = "April";
            int bornYear = 2009, bornDate = 17;

            // Ts with $
            Console.WriteLine("Memakai $ atau \"String Interpolation\"\n");
            Console.WriteLine($"Nama:\n{fName} {mName} {lName}\n");
            Console.WriteLine($"Alamat:\n{address}\n");
            Console.WriteLine($"Tempat / Tanggal Lahir:\n{bornPlace}, {bornDate} {bornMonth} {bornYear}\n");
            //Console.WriteLine($"Umur:\n{tsYear - bornYear} Tahun\n");

            Console.WriteLine("===================");

            // Ts with +
            Console.WriteLine("\nMemakai + atau \"String Concatenation\"\n");
            Console.WriteLine("Nama:\n" + fName + " " + mName + " " + lName);
            Console.WriteLine();
            Console.WriteLine("Alamat:\n" + address);
            Console.WriteLine();
            Console.WriteLine("Tempat / Tanggal Lahir:\n" + bornPlace + ", " + bornDate + " " + bornMonth + " " + bornYear);
            Console.WriteLine();
            //Console.WriteLine("Umur:\n" + (tsYear - bornYear) + " tahun");

            Console.ReadKey();
        }
    }
}
