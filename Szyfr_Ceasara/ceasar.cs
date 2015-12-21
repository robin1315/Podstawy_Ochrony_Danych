using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cear
{
    class Ceasar
    {
        public static char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        
        public static string szyfruj(string[] jawnyy, int przesuniecie)
        {

            string tmp = "";
            foreach (var jawny in jawnyy)
            {
                for (int j = 0; j < jawny.Length; j++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (Char.ToLower(jawny[j]) == alfabet[i])
                        {
                            tmp += alfabet[(i+przesuniecie) % alfabet.Length];
                        }
                    }

                }
            }
            return tmp;
        }

        public static string deszyfruj(string[] szyfrogramm, int przesuniecie)
        {
            string tmp = "";
            foreach (var szyfrogram in szyfrogramm)
            {
                for (int j = 0; j < szyfrogram.Length; j++)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (Char.ToLower(szyfrogram[j]) == alfabet[i])
                        {
                            if (!(i - przesuniecie < 0))
                                tmp += alfabet[Math.Abs((i - przesuniecie) % alfabet.Length)];
                            else
                                tmp += alfabet[alfabet.Length - (Math.Abs(i - przesuniecie) % alfabet.Length)];
                            break;
                        }
                    }

                }                
            }

            return tmp;
        }

        public static string[] wczytaj_plik(string sciezka)
        {
            string[] lines = System.IO.File.ReadAllLines(@sciezka);
            return lines;
        }
        public static void wyswietl_plik(string[] text)
        {
            foreach (string line in text)
            {
                Console.WriteLine("\t" + line);
            }

        }
        public static void zapisz_plik(string sciezka, string text)
        {

            System.IO.File.WriteAllText(@sciezka, text);

        }

        static void Main(string[] args)
        {
            string sciezka_odczytu = @"C:\Users\Robin\Documents\Visual Studio 2012\Projects\AtBash\AtBash\do_szyfrowania.txt";
            string sciezka_zapisu = @"C:\Users\Robin\Documents\Visual Studio 2012\Projects\AtBash\AtBash\do_odszyfrowania.txt";
            //string[] napis = {"pjakis" ,"napis"};
            int przesuniecie = 11;

            //System.Console.WriteLine("Podaj ściezke do pliku jawnego:");
            //sciezka_odczytu = @System.Console.ReadLine();

            System.Console.WriteLine("Podaj ściezke do pliku zaszyfrowanego:");
            sciezka_zapisu = @System.Console.ReadLine();

            try
            {
                System.Console.WriteLine(szyfruj(wczytaj_plik(sciezka_odczytu), przesuniecie));
                //zapisz_plik(sciezka_zapisu, szyfruj(wczytaj_plik(sciezka_odczytu), przesuniecie));
                System.Console.WriteLine(deszyfruj(wczytaj_plik(sciezka_zapisu), przesuniecie));
                //int i = Convert.ToInt32("0");
                //int j = Convert.ToInt32("01".Substring(0,1));

                //Console.WriteLine( tablica[i,j]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }//System.Console.WriteLine( deszyfruj(wczytaj_plik( sciezka_zapisu), przesuniecie));
            System.Console.ReadKey();
        }
    }
}
