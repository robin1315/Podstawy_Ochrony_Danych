using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;

namespace RSA
{

    class RSA
    {
        static int gorna_granica = 9999;
        static int dolna_granica = 1000;
        static Random r = new Random();
        public static bool Czy_Pierwsza(Int64 liczba) {
            if (liczba == 1 || liczba == 2)
                return false;
            Int64 p = 1;
            for (int i = 1; i < liczba; i++)
            {
                if (liczba % i == 0)
                {
                    p++;
                    if (p > 2)
                        return false;
                }
            }
            return true;
        }
        public static int[] Gen_Pierwsze(int poczatek_przedzialu, int koniec_przedzialu , int ile_liczb) {

            int[] tablica_pierwszych = new int[(koniec_przedzialu - poczatek_przedzialu) ];

            for (int i = poczatek_przedzialu; i - poczatek_przedzialu < koniec_przedzialu - poczatek_przedzialu ; i++)
            {
                if(Czy_Pierwsza(i))
                    tablica_pierwszych[i - poczatek_przedzialu] = i; 
            }

            
            int[] tab = new int[ile_liczb];

            int tmp = 0;
            for (int i = 0; i < ile_liczb;) {
                tmp =r.Next(0, koniec_przedzialu - poczatek_przedzialu);
                if (tablica_pierwszych[tmp] != 0)
                {
                    tab[i] = tablica_pierwszych[tmp];   
                    i++;
                }
            }
            return tab;
        }
        public static Int64[] Ex_Euklides(Int64 liczba1 , Int64 liczba2) {
            
            ///DOKOŃCZYC

            if (!(liczba1 > liczba2))
            {
                Int64 tmp = liczba1;
                liczba1 = liczba2;
                liczba2 = tmp;
            }

            Int64 x, y, q, r, nwd, x1,x2,y1,y2 ;
            q = liczba1 / liczba2;
            r = liczba1 - (q * liczba2);
            nwd = liczba2;

            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;
            x = 1;
            y = y2 - (q - 1) * y1;

            while (r != 0)
            {
                liczba1 = liczba2;
                liczba2 = r;

                x = x2 - q * x1;
                x2 = x1;
                x1 = x;

                y = y2 - q * y1;
                y2 = y1;
                y1 = y;

                nwd = r;
                q = liczba1 / liczba2;
                r = liczba1 - q * liczba2;
            }
            Int64[] wynik = {nwd, x , y};


            return wynik;
        }
        public static Int64 Gen_E(Int64 phi) {

            Int64 liczba = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
            //Int64 liczba = 3;
            while (true)
            {


                if (Ex_Euklides(liczba, phi)[0] == 1 && /*Czy_Pierwsza(liczba))*/    liczba < phi)
                    break;

                //liczba = liczba +1;
                liczba = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
            }

            return liczba;
        }
        public static Int64 Gen_D(Int64 phi, Int64 e) {
            int d = 0;

            for (d = 2; d < phi; d++)
                if (Convert.ToBoolean(((e * d) - 1) % phi == 0))
                    break;

            return d;
        }
        public static Int64 szybkie_potegowanie_modulo(Int64 podstawa, Int64 potega, Int64 modulo)
        {
            Int64 i;
            Int64 result = 1;
            Int64 x = podstawa % modulo;

            for (i = 1; i <= potega; i <<= 1)
            {
                x %= modulo;
                if ((potega & i) != 0)
                {
                    result *= x;
                    result %= modulo;
                }
                x *= x;
            }

            return result;
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
                Console.WriteLine(line + " ");
            }

        }
        public static List<Int64> szyfrowanie(Int64[] klucz_publiczny, string sciezka) {
            string[] wiersze = wczytaj_plik(sciezka);
            Int64 c,m;
            List<Int64> wynik = new List<Int64>();

            //System.Console.WriteLine("szyfr");
            //System.Console.WriteLine(klucz_publiczny[0] + " " + klucz_publiczny[1]);
            
            foreach(string wiersz in wiersze){

                char[] tab_znak = wiersz.ToCharArray();

                foreach(char znak in tab_znak){
                    //System.Console.WriteLine((Int64)znak);
                    m = ((Int64)znak);
                    //System.Console.WriteLine(m);
                    c = szybkie_potegowanie_modulo(m,klucz_publiczny[0], klucz_publiczny[1]);
                    wynik.Add(c);
                    //System.Console.WriteLine(c);
                }
            }

            return wynik;
        }
        public static List<char> deszyfrowanie(Int64[] klucz_prywatny, List<Int64> szyfrogram) {
            List<char> wynik = new List<char>();
            char m;

            //System.Console.WriteLine("desz");
            //System.Console.WriteLine(klucz_prywatny[0] + " " + klucz_prywatny[1]);



            foreach (Int64 c in szyfrogram) {
                //System.Console.WriteLine( szybkie_potegowanie_modulo(c, klucz_prywatny[0], klucz_prywatny[1]));
                //System.Console.WriteLine(c);

                //System.Console.WriteLine(szybkie_potegowanie_modulo(c, klucz_prywatny[0], klucz_prywatny[1]));
                m = (char)szybkie_potegowanie_modulo(c, klucz_prywatny[0], klucz_prywatny[1]);
                wynik.Add(m);
            }


            return wynik;
        }
        public static Int64[][] Gen_klucze() {
            /*
            Int64 p = 31;
            Int64 q = 19;
            */
            Int64 p = Gen_Pierwsze(dolna_granica, gorna_granica, 2)[0];
            Int64 q = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
            
            

            Int64 n = p * q;
            Int64 phi = (p - 1) * (q - 1);
            Int64 e = Gen_E(phi);
            //e = 7;
            Int64 d = Gen_D(phi, e);

            
            //DOKONCZYC

            /*
            System.Console.WriteLine("9688563^458926 mod 71 = {0}", szybkie_potegowanie_modulo(9688563,458926,71));
            System.Console.WriteLine("phi{0} e{1} d {2}",phi,e,d);
            /*
            Int64[] wynik = Ex_Euklides(phi, e);
            System.Console.WriteLine("nwd(" + phi + ", " + e + ") = ");
            System.Console.WriteLine("{0} * {1} + {2}* {3} = ", phi, wynik[1], e, wynik[2]);
            System.Console.WriteLine(wynik[0]);
            
             
             */
            System.Console.WriteLine();
            System.Console.WriteLine("phi {0} e {1} d {2} n {3} p {4} q {5}", phi, e, d, n, p, q);
            System.Console.WriteLine("Klucz publiczny: {0} {1}", e,n);
            System.Console.WriteLine("Klucz prywatny: {0} {1}", d, n);
            Int64[] klucz_publiczny = { e, n };
            Int64[] klucz_prywatny = { d, n };

            //System.Console.WriteLine(klucz_publiczny[0] + " " + klucz_publiczny[1]);
            //System.Console.WriteLine("RSA");
            //System.Console.WriteLine(klucz_publiczny[0] + " " + klucz_publiczny[1]);
            //System.Console.WriteLine(klucz_prywatny[0] + " " + klucz_prywatny[1]);

            return new Int64[][] { klucz_publiczny, klucz_prywatny };

            //System.Console.WriteLine(szyfrowanie(klucz_prywatny,"tekst.txt"));

        }
        static void Main(string[] args)
        {
            // Używanei Euklidesa
            /*
            Int64 a = 26, b = 15;
            Int64[] wynik = Ex_Euklides(a, b);
            System.Console.WriteLine("nwd(" + a + ", " + b + ") = ");
            System.Console.WriteLine("{0} * {1} + {2}* {3} = ",a,wynik[1],b,wynik[2]);
            System.Console.WriteLine(wynik[0]);

            */

            //Generowanie liczb pierwszych przyklad
            /*
            int[] licz = Gen_Pierwsze(1000, 9999, 2
            foreach (var i in licz)
                System.Console.WriteLine(i);
            */
            
            /*
            List<int> lis = new List<int>();
            lis.Add(1);
            lis.Add(2);
            string s = "";
            foreach (int i in lis)
            {
                s += i.ToString();
            }


            */


            
            string sciezka="tekst.txt";
            wyswietl_plik(wczytaj_plik(sciezka));

            Int64[][] klucze = Gen_klucze();
            List<Int64> szyfrogram = szyfrowanie(klucze[0], sciezka);

            string s = "";
            foreach (Int64 v in szyfrogram)
            {
                s += v.ToString();
            }
            
            System.Console.WriteLine(s);
            System.Console.WriteLine();


            List<char> zdeszyfrowany = deszyfrowanie(klucze[1], szyfrogram);

            string ss = "";
            foreach (char z in zdeszyfrowany) {
                ss += z.ToString();
            }
            System.Console.WriteLine(ss);

            

           // Gen_Pierwsze(0, 100, 1);
            System.Console.ReadKey();
        }
    }
}
