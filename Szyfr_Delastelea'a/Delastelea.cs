using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polibiusz
{
    class Delastelea
    {
        public static char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static char[,] tablica = new char[5, 5] { { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ' } };
        public static void wyswietl_tablice()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    System.Console.Write(tablica[i, j] + " ");
                }
                System.Console.WriteLine();
            }

        }

        public static string szyfruj(string[] jawnyy, string klucz)
        {

            string tmp = "";
            string tmp2 = "";
            string tmp3 = "";
            //wyswietl_tablice();
            wypelnij_tablice(klucz);
            //wyswietl_tablice();
            int wielkosc = 0;
            
            foreach (var jawny in jawnyy)
            {
                for (int t = 0; t < jawny.Length; t++)
                {
                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            if ((Char.ToLower(jawny[t]) == tablica[i, j]) || (Char.ToLower(jawny[t]) == 'j' && tablica[i, j] == 'i'))
                            {
                                tmp += j.ToString();
                                tmp2 += i.ToString();
                                tmp3 += tablica[i ,j].ToString();
                            }
                        }
                }
            }


            wielkosc = tmp2.Length;

            char[,] tablica_pomocnicza = new char[3, wielkosc];

            for (int i = 0; i < wielkosc; i++)
            {
                tablica_pomocnicza[0, i] = tmp3[i];
                tablica_pomocnicza[1, i] = tmp[i];
                tablica_pomocnicza[2, i] = tmp2[i];
            }

            /*
            for (int i = 0; i < wielkosc; i++)
                Console.Write(tablica_pomocnicza[0,i]+" ");
            Console.WriteLine();
            for (int i = 0; i < wielkosc; i++)
                Console.Write(tablica_pomocnicza[1, i] + " ");
            Console.WriteLine();
            for (int i = 0; i < wielkosc; i++)
                Console.Write(tablica_pomocnicza[2, i] + " ");
            Console.WriteLine();
            wyswietl_tablice();
            */
            string sprzejsciowy = "";

            for (int i = 0; i < wielkosc; i++)
                sprzejsciowy += tablica_pomocnicza[1, i];

            for (int i = 0; i < wielkosc; i++)
                sprzejsciowy += tablica_pomocnicza[2, i];
            /*
            Console.WriteLine("szyfrowanie przejsicowy");
            Console.WriteLine(sprzejsciowy);
            Console.WriteLine();
            */

            return deszyfruj(new String[] { sprzejsciowy }, klucz); ;
        }

        private static void wypelnij_tablice(string klucz)
        {

            string tt;
            tt = Char.ToString(klucz[0]);
            int k = 1;
            int x;
            int n = klucz.Length;
            for (int l = 1; l < n; l++)
            {
                x = 0;
                for (int j = 0; j < k; j++)
                {
                    if (klucz[l] == tt[j])
                        x = 1;
                }
                if (x == 0)
                {
                    tt += klucz[l];
                    k++;
                }
            }

            klucz = tt;

            int dlugosc = klucz.Length;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablica[i, j] = klucz[i + j];
                    dlugosc--;
                    if (dlugosc == 0)
                        break;
                }
                if (dlugosc == 0)
                    break;
            }

            //wyswietl_tablice();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int t = 0; t < alfabet.Length; t++)
                    {
                        if (alfabet[t] == tablica[i, j])
                            alfabet[t] = ' ';

                    }
                }
            }

            //for (int i = 0; i < alfabet.Length; i++) { System.Console.WriteLine(alfabet[i]); }
            //wypelnienei reszta alfabetu tablicy 5x5


            int r = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (tablica[i, j] == ' ')
                        if (r < alfabet.Length)
                        {
                            if (alfabet[r] != ' ')
                            {

                                tablica[i, j] = alfabet[r];

                            }
                            else
                                j--;
                            r++;

                        }
                }
            }

            //wyswietl_tablice();

        }

        public static string deszyfruj(string[] szyfrogramm, string klucz)
        {
            string tmp = "";
            foreach (var szyfrogram in szyfrogramm)
            {
                for (int t = 0; t < szyfrogram.Length - 1; t += 2)
                {
                    tmp += tablica[Convert.ToInt32(szyfrogram.Substring(t + 1, 1)), Convert.ToInt32(szyfrogram.Substring(t, 1))];
                }
            }
            
            return tmp;
        }

        public static string deszyfruj2(string[] szyfrogramm, string klucz) {
            string tmp = "";
            string tmp2 = "";
            string tmp3 = "";

            foreach (var szyfrogram in szyfrogramm)
            {
                for (int t = 0; t < szyfrogram.Length; t++)
                {
                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            if ((Char.ToLower(szyfrogram[t]) == tablica[i, j]) || (Char.ToLower(szyfrogram[t]) == 'j' && tablica[i, j] == 'i'))
                            {
                                tmp += j.ToString();
                                tmp2 += i.ToString();
                                tmp3 += tablica[i, j].ToString();
                            }
                        }
                }
            }
            /*
            Console.WriteLine("deszyfruje");
            Console.WriteLine(tmp3);

            Console.WriteLine(tmp);
            Console.WriteLine(tmp2);
            */
            string tmp4 = "";

            for (int i = 0; i < tmp3.Length; i++)
            {
                tmp4 += tmp[i];
                tmp4 += tmp2[i];
            }
            /*
            Console.WriteLine("scalanie");
            Console.WriteLine(tmp4);
            */

            string tmp5 = tmp4.Substring(0, tmp4.Length / 2);
            string tmp6 = tmp4.Substring((tmp4.Length/2));
            /*
            Console.WriteLine("podzielenie");
            Console.WriteLine(tmp5);
            Console.WriteLine(tmp6);
            */
            string tmp7 = "";

            for (int i = 0; i < tmp5.Length; i++)
            {
                tmp7 += tmp5[i];
                tmp7 += tmp6[i];
            }
            /*
            Console.WriteLine("scalanie 2");
            Console.WriteLine(tmp7);
            */



            return (deszyfruj(new String[] { tmp7 }, klucz));
        }
        public static string[] wczytaj_plik(string sciezka)
        {
            string[] lines = System.IO.File.ReadAllLines(@sciezka);
            //foreach(var line in lines)
              //  System.Console.WriteLine(line);
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

            string sciezka_odczytu = @"C:/Users/Robin/do_szyfrowania.txt";
            string sciezka_zapisu = @"C:\Users\Robin\szyfry_kowalski_robert/szyfrogram_zaawansowany_szyfr.txt";
            //string wynikowa_sciezka =@"C:/Users/Robin/out.txt";
   
            string klucz = "sratatate";
            string napis = "jakiswiekszyproblemzdluzszymitekstami";
            System.Console.WriteLine( szyfruj(new String[] {napis},klucz));
            System.Console.WriteLine(deszyfruj2 (new String[] {szyfruj(new String[] { napis }, klucz)},klucz));
            //System.Console.WriteLine("Podaj ściezke do pliku jawnego:");
            //sciezka_odczytu = @System.Console.ReadLine();

            //System.Console.WriteLine("Podaj ściezke do pliku zaszyfrowanego:");
            //sciezka_zapisu = @System.Console.ReadLine();
            //string szyfr = "42256985";
            //Console.WriteLine(Convert.ToInt32(szyfr.Substring(0,1)));
            //try
            //{
             //   System.Console.WriteLine(szyfruj(wczytaj_plik(sciezka_odczytu), klucz));
                //zapisz_plik(sciezka_zapisu, szyfruj(wczytaj_plik(sciezka_odczytu), klucz));
                //Console.WriteLine();
               // System.Console.WriteLine(deszyfruj2(wczytaj_plik(sciezka_zapisu), klucz));
                //zapisz_plik(wynikowa_sciezka, deszyfruj2(wczytaj_plik(sciezka_zapisu), klucz));
                //int i = Convert.ToInt32("0");
                //int j = Convert.ToInt32("01".Substring(0,1));

                //Console.WriteLine( tablica[i,j]);
            //}
            //catch (Exception e)
            //{
             // Console.WriteLine(e.Message);
            //}
    //            wyswietl_tablice();
            System.Console.ReadKey();
        }
    