using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtBash
{
    class AtBash
    {
        static char[,] alfabet = new char[2,26]{{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'},
                                                {'z','y','x','w','v','u','t','s','r','q','p','o','n','m','l','k','j','i','h','g','f','e','d','c','b','a'}};

        public static string szyfruj(string[] jawnyy) {

            string tmp = "";
            foreach (var jawny in jawnyy)
            {
                for (int j = 0; j < jawny.Length; j++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (Char.ToLower( jawny[j]) == alfabet[0, i])
                        {
                            tmp += alfabet[1, i];
                        }
                    }

                }
            }
            return tmp;
        }

        public static string deszyfruj(string[] szyfrogramm) {
            string tmp = "";
            foreach (var szyfrogram in szyfrogramm)
            {
                for (int j = 0; j < szyfrogram.Length; j++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (Char.ToLower(szyfrogram[j]) == alfabet[0, i])
                        {
                            tmp += alfabet[1, i];
                        }
                    }

                }
            }

            return tmp;
        }
        public static string[] wczytaj_plik(string sciezka) {
            string[] lines = System.IO.File.ReadAllLines(@sciezka);
            return lines;
        }
        public static void wyswietl_plik(string[] text) { 
            foreach (string line in text)
            {
                Console.WriteLine("\t" + line);
            }
        
        }
        public static void zapisz_plik(string sciezka, string text) {

            System.IO.File.WriteAllText(@sciezka, text);

        }

        static void Main(string[] args)
        {
            string sciezka_odczytu = @"C:\do_szyfrowania.txt";
            string sciezka_zapisu = @"C:\do_odszyfrowania.txt";
            //string napis = "jakis napis";

            System.Console.WriteLine("Podaj ściezke do pliku jawnego:");
            sciezka_odczytu = @System.Console.ReadLine();

            System.Console.WriteLine("Podaj ściezke do pliku zaszyfrowanego:");
            sciezka_zapisu = @System.Console.ReadLine();
            try
            {
                System.Console.WriteLine(szyfruj(wczytaj_plik(sciezka_odczytu)));
                zapisz_plik(sciezka_zapisu, szyfruj(wczytaj_plik(sciezka_odczytu)));
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            //System.Console.WriteLine(deszyfruj( wczytaj_plik(sciezka_zapisu)));
            System.Console.WriteLine();
            System.Console.ReadKey();
        }
    }
}
