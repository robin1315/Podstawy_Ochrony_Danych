using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace Gen_bbs
{
    class BBS
    {
        static int dolna_granica = 1000;
        static int gorna_granica = 9000;
        static Random r = new Random();
        public static bool Czy_Pierwsza(Int64 liczba)
        {
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
        public static int[] Gen_Pierwsze(int poczatek_przedzialu, int koniec_przedzialu, int ile_liczb)
        {

            int[] tablica_pierwszych = new int[(koniec_przedzialu - poczatek_przedzialu)];

            for (int i = poczatek_przedzialu; i - poczatek_przedzialu < koniec_przedzialu - poczatek_przedzialu; i++)
            {
                if (Czy_Pierwsza(i))
                    tablica_pierwszych[i - poczatek_przedzialu] = i;
            }


            int[] tab = new int[ile_liczb];

            int tmp = 0;
            for (int i = 0; i < ile_liczb; )
            {
                tmp = r.Next(0, koniec_przedzialu - poczatek_przedzialu);
                if (tablica_pierwszych[tmp] != 0)
                {
                    tab[i] = tablica_pierwszych[tmp];
                    i++;
                }
            }
            return tab;
        }
        public static Int64[] Ex_Euklides(Int64 liczba1, Int64 liczba2)
        {

            ///DOKOŃCZYC

            if (!(liczba1 > liczba2))
            {
                Int64 tmp = liczba1;
                liczba1 = liczba2;
                liczba2 = tmp;
            }

            Int64 x, y, q, r, nwd, x1, x2, y1, y2;
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
            Int64[] wynik = { nwd, x, y };


            return wynik;
        }
        public static Int64 Wzglednie_pierwsza(Int64 l)
        {

            Int64 liczba = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
            //Int64 liczba = 3;
            while (true)
            {


                if (Ex_Euklides(liczba, l)[0] == 1 && /*Czy_Pierwsza(liczba))*/    liczba < l)
                    break;

                //liczba = liczba +1;
                liczba = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
            }

            return liczba;       }
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
        public static string string_to_binary(string napis)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in napis.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public static string gen_bbs(Int64 ile)
        {
            string ciag = "";
            Int64 p = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
            Int64 q = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];

            while (true)
            {
                if (!(p % 4 == 3))
                {
                    p = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
                }
                else
                    break;

            }
            while (true)
            {
                if (!(q % 4 == 3) || p == q)
                {
                    q = Gen_Pierwsze(dolna_granica, gorna_granica, 1)[0];
                }
                else
                    break;

            }
            //p = 11; q = 11;

            Int64 n = p * q;
            Int64 x = Wzglednie_pierwsza(n);

            Int64 x0 = (Int64)Math.Pow(x, 2);//szybkie_potegowanie_modulo(x, 2, n);
            //x0 = x ^ 2;
            //Int64 tmp = 0;
            //System.Console.WriteLine(x0);

            for (Int64 i = 1; i < ile; i = i + 1)
            {
                x0 = (Int64)Math.Pow(x0, 2) % n;
                //System.Console.WriteLine("p= {0}, q= {1}, n= {2}, x= {3}, x0= {4}, tmp = {5} ", p, q, n, x, x0, tmp);

                ciag += (string_to_binary(x0.ToString()[x0.ToString().Length - 1].ToString()))[7].ToString();

            }
            //System.Console.WriteLine("p= {0}, q= {1}, n= {2}, x= {3}, x0= {4},  ", p, q, n, x, x0);
            //System.Console.WriteLine(ciag);

            return ciag;
        }
        public static bool test_pojedynczego_bitu(string ciag) {
            if (ciag.Length < 19999) {
                System.Console.WriteLine("Za krótki ciąg,");
            }

            int ile = 0;
            for (int i = 0; i < 20000-1; i++) {
                if (ciag[i] == '1')
                    ile++;
            }
            System.Console.WriteLine(ile);
            if (ile > 10275 || ile < 9725)
                return false;
            else
                return true;
        }
        public static void test_serii(string ciag)  {

            char Znak = ciag[0];
            int[] serie = new int[6];
            int dlugoscAktualnejSerii = 0;

            foreach (char c in ciag)
            {
                if (c == Znak)
                    ++dlugoscAktualnejSerii;
                else
                {
                    ++serie[dlugoscAktualnejSerii > 5 ? 5 : (dlugoscAktualnejSerii - 1)];
                    dlugoscAktualnejSerii = 1;
                    Znak = c;
                }
            }
            ++serie[dlugoscAktualnejSerii > 5 ? 5 : (dlugoscAktualnejSerii - 1)];

            System.Console.WriteLine("1: {0}, 2: {1}, 3: {2}, 4: {3}, 5: {4}, 6: {5}, ", serie[0],serie[1],serie[2],serie[3],serie[4],serie[5]);
        
        }
        public static bool test_dlugiej_serii(string ciag) {

            char Znak = ciag[0];
            int dlugoscAktualnejSerii = 0;

            foreach (char c in ciag)
            {
                if (c == Znak)
                    ++dlugoscAktualnejSerii;
                else
                {
                    if (dlugoscAktualnejSerii >= 26)
                        return false;
                    dlugoscAktualnejSerii = 1;
                    Znak = c;
                }
            }
            return true;
        }
        public static double test_pokerowy(string ciag) {

            int[] liczby = new int[16];
            string tmp = "";
            int tmp2=0;
            for (int i = 0; i < 19996; i += 4) {

                tmp = ciag[i].ToString() + ciag[i + 1].ToString() + ciag[i + 2].ToString() + ciag[i + 3].ToString();
                tmp2 = Convert.ToInt32(tmp , 2);
                liczby[tmp2]++;
            
            }
            int sum = 0;
            foreach (int i in liczby)
            {
                sum +=(int) Math.Pow(i,2);
                //System.Console.WriteLine(i);
            }
            //System.Console.WriteLine(sum);
            double wynik = Math.Round(((16 * sum) / 5000.0) - 5000.0,2);
            System.Console.WriteLine(wynik);

            return wynik;
        }

        static void Main(string[] args)
        {
            string ciag = "";

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            ciag = gen_bbs(20000);
            sw1.Stop();
            System.Console.WriteLine("cZAS GENERACJI {0}", sw1.Elapsed.TotalMilliseconds);

            System.Console.WriteLine("Test pojedynczego bitu:");
            if (test_pojedynczego_bitu(ciag))
                System.Console.WriteLine("Pomyślnie");
            else
                System.Console.WriteLine("Nie pomyślnie");
            System.Console.WriteLine("Test serii:");
            test_serii(gen_bbs(12000));
            System.Console.WriteLine("Test długiej serii:");
            if(test_dlugiej_serii(ciag))
                System.Console.WriteLine("Pomyślnie");
            else
                System.Console.WriteLine("Nie pomyślnie");

            System.Console.WriteLine("Test pokerowy:");

            if (test_pokerowy(ciag) > 2.16 && test_pokerowy(ciag) < 46.17)
                System.Console.WriteLine("Pomyślnie");
            else
                System.Console.WriteLine("Nie pomyślnie");



            System.Console.ReadKey();
        }
    }
}
