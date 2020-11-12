using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace titanic
{
    struct olvas
    {
        public string kategoria;
        public int tulelo;
        public int eltunt;
    }
    
    class Program
    {
        
        static List<olvas> hajo;
        static void Main(string[] args)
        {
            elsofeladat();
            masodikfeladat();
            harmadikfeladat();
            negyedik();
            otodik();
            hatodik();
            hetedik();

            Console.ReadKey();
        }

        private static void hetedik()
        {
            throw new NotImplementedException();
            //idk
        }

        private static void hatodik()
        {
            int alma = 0;
            foreach (var e in hajo)
            {
                alma = e.eltunt;
            }
            int b = alma / sump * 100;
            foreach (var i in hajo)
                if (b > 60)
                {
                    Console.WriteLine("\t{0}", i.kategoria);
                }
        }

        static int sump = 0;
        private static void otodik()
        {
            Console.WriteLine("Add meg a keresni kívánt szöveget:");
            string beker = Console.ReadLine();
            foreach (var e in hajo)
            {
                if (e.kategoria == beker)
                {
                    Console.WriteLine("\t{0} {1} fő", e.kategoria, sump);
                }
            }
        }

        private static void negyedik()
        {
            bool a= false;
            Console.WriteLine("Add meg a keresni kívánt szöveget:");
            string beker = Console.ReadLine();
            foreach (var e in hajo)
            {
                    if(e.kategoria==beker)
                    {
                    a = true;
                    }             
           }
            if (a==true)
            {
                Console.WriteLine("Van találat!");
            }
            else
            {
                Console.WriteLine("Nincs Találat");
            }
        }

        private static void harmadikfeladat()
        {
            int sum = 0;
            foreach (var e in hajo)
            {
               sum  = e.tulelo + e.eltunt;
            }
            Console.WriteLine($"3. feladat: {sum} fő");
            sump = sum;
        }

        private static void masodikfeladat()
        {
            Console.WriteLine($"2. feladat: {hajo.Count} db");
        }

        private static void elsofeladat()
        {
            hajo = new List<olvas>();

            var sr = new StreamReader(@"..\..\Res\titanic.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                var t = sr.ReadLine().Split(';');

                hajo.Add(new olvas()
                {
                    kategoria = t[0],
                    tulelo = int.Parse(t[1]),
                    eltunt= int.Parse(t[2]),
                }) ;
            }

            sr.Close();
        }
    }
}
