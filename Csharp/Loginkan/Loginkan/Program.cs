using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginkan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("Siapa namamu tuan? ");
                string log = Console.ReadLine();
                Console.Write("Kata kuncinya tuan? ");
                string pw = Console.ReadLine();
                if (log == "wiwokdetok" && pw == "admin#123") 
                {
                    Console.WriteLine("Hidoep Jokowi");
                    break;
                }
                Console.WriteLine("Salah Njir\n");
            }
            Console.ReadKey();
        }
    }
}
