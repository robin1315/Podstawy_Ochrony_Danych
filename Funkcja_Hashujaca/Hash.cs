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
    class Hash
    {
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
        /*
         * 
         *      Funkcja skrótu |
         *                    \/
         * 
         */

        public static string string_to_binary(string napis)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in napis.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        static List<byte> dane = new List<byte>();
        public static void do_binarnej(string[] lines)
        {
            //foreach(var line in lines)
              //  System.Console.WriteLine(line);
            string tmp= "";
            for (int i=0; i < lines.Length; i++) {
                tmp = lines[i];
                for (int j = 0; j < tmp.Length; j++)
                    dane.Add((byte)tmp[j]);
            }

            //foreach (var i in dane)
              //  System.Console.WriteLine(i);

        }
        public static string funkcja_skrótu(string nameoffile) {
            dane.Clear();
            do_binarnej(wczytaj_plik(nameoffile));

            UInt64 ilosc_bitow = (UInt64)dane.Count * 8;
            UInt64 koncówka = ilosc_bitow % 512;


            dane.Add(128);
//WYPELNIENIE ZERAMI
            int tmpp = 0;
            while ((dane.Count % 64)  !=56)
            {
                dane.Add((byte)0);
                tmpp++;
            }

            ilosc_bitow = (UInt64)dane.Count * 8;
            
            byte[] byteArray = BitConverter.GetBytes( dane.Count * 8 );
            //System.Console.WriteLine(byteArray.Length);
            for (int i = 8; i - byteArray.Length > 0; i--)
                dane.Add(0);


                for (int i = byteArray.Length - 1; i > -1; i--)
                {
                    dane.Add(byteArray[i]);
                    //System.Console.WriteLine(byteArray[i].ToString());
                }
            
            ilosc_bitow = (UInt64)dane.Count * 8;
            koncówka = ilosc_bitow % 512; 
            UInt64 ibloki = (ilosc_bitow / 512) > 0 ? (ilosc_bitow / 512)  : 1;
            //System.Console.WriteLine(dane[dane.Count-1].ToString());
//inicjalizacja zmiennych 
            
            byte[] A = new byte[4], B = new byte[4], C = new byte[4], D = new byte[4];

            A[0]=(byte)60;
            A[1]=(byte)20;
            A[2]=(byte)19;
            A[3]=(byte)93;


            B[0] = (byte)25;
            B[1] = (byte)48;
            B[2] = (byte)187;
            B[3] = (byte)228;

            C[0] = (byte)195;
            C[1] = (byte)220;
            C[2] = (byte)139;
            C[3] = (byte)83;

            D[0] = (byte)14;
            D[1] = (byte)80;
            D[2] = (byte)54;
            D[3] = (byte)49;



            uint aa = BitConverter.ToUInt32(A, 0);
            uint bb = BitConverter.ToUInt32(B, 0);
            uint cc = BitConverter.ToUInt32(C, 0);
            uint dd = BitConverter.ToUInt32(D, 0);
            int j = 0;

            //System.Console.WriteLine(dane.Count + "tutaj");
            //System.Console.WriteLine(dane[]);
            //UInt64 iterator = 0;

               for(int iterator = 0 ; iterator < (int)ibloki ; iterator++){
                    //for (int j = 0 + ((int)iterator * 16) ; j < 16+ (16* (int)iterator) ; j++) {

                          
                          aa += fh_A(dane[((int)iterator * 64) + j +2], aa, bb, cc, dd, 8);
                          bb += fh_A(dane[((int)iterator * 64) + j + 55], bb, cc, dd, aa, 5);
                          cc += fh_A(dane[((int)iterator * 64) + j + 29], cc, dd, aa, bb, 12);
                          dd += fh_A(dane[((int)iterator * 64) + j + 44], dd, aa, bb, cc, 2);

                          aa += fh_A(dane[((int)iterator * 64) + j + 11], aa, bb, cc, dd, 8);
                          bb += fh_A(dane[((int)iterator * 64) + j + 10], bb, cc, dd, aa, 5);
                          cc += fh_A(dane[((int)iterator * 64) + j + 37], cc, dd, aa, bb, 12);
                          dd += fh_A(dane[((int)iterator * 64) + j + 11], dd, aa, bb, cc, 2);

                          aa += fh_A(dane[((int)iterator * 64) + j + 44], aa, bb, cc, dd, 8);
                          bb += fh_A(dane[((int)iterator * 64) + j + 13], bb, cc, dd, aa, 5);
                          cc += fh_A(dane[((int)iterator * 64) + j + 6], cc, dd, aa, bb, 12);
                          dd += fh_A(dane[((int)iterator * 64) + j + 15], dd, aa, bb, cc, 2);
                          //if (dane[(].ToString() == "192")
                            //  System.Console.WriteLine("tutaj");
                          aa += fh_A(dane[((int)iterator * 64) + j + 2], aa, bb, cc, dd, 8);
                          bb += fh_A(dane[((int)iterator * 64) + j + 59], bb, cc, dd, aa, 5);
                          cc += fh_A(dane[((int)iterator * 64) + j + 38], cc, dd, aa, bb, 12);
                          dd += fh_A(dane[((int)iterator * 64) + j + 51], dd, aa, bb, cc, 2);


                          aa += fh_B(dane[((int)iterator * 64) + j + 2], aa, bb, cc, dd, 8);
                          bb += fh_B(dane[((int)iterator * 64) + j + 45], bb, cc, dd, aa, 5);
                          cc += fh_B(dane[((int)iterator * 64) + j + 49], cc, dd, aa, bb, 12);
                          dd += fh_B(dane[((int)iterator * 64) + j + 40], dd, aa, bb, cc, 2);

                          aa += fh_B(dane[((int)iterator * 64) + j + 11], aa, bb, cc, dd, 8);
                          bb += fh_B(dane[((int)iterator * 64) + j + 16], bb, cc, dd, aa, 5);
                          cc += fh_B(dane[((int)iterator * 64) + j + 63], cc, dd, aa, bb, 12);
                          dd += fh_B(dane[((int)iterator * 64) + j + 22], dd, aa, bb, cc, 2);

                          aa += fh_B(dane[((int)iterator * 64) + j + 4], aa, bb, cc, dd, 8);
                          bb += fh_B(dane[((int)iterator * 64) + j + 13], bb, cc, dd, aa, 5);
                          cc += fh_B(dane[((int)iterator * 64) + j + 6], cc, dd, aa, bb, 12);
                          dd += fh_B(dane[((int)iterator * 64) + j + 15], dd, aa, bb, cc, 2);

                          aa += fh_B(dane[((int)iterator * 64) + j + 2], aa, bb, cc, dd, 8);
                          bb += fh_B(dane[((int)iterator * 64) + j + 9], bb, cc, dd, aa, 5);
                          cc += fh_B(dane[((int)iterator * 64) + j + 25], cc, dd, aa, bb, 12);
                          dd += fh_B(dane[((int)iterator * 64) + j + 5], dd, aa, bb, cc, 2);



                          aa += fh_C(dane[((int)iterator * 64) + j + 24], aa, bb, cc, dd, 8);
                          bb += fh_C(dane[((int)iterator * 64) + j + 5], bb, cc, dd, aa, 5);
                          cc += fh_C(dane[((int)iterator * 64) + j + 46], cc, dd, aa, bb, 12);
                          dd += fh_C(dane[((int)iterator * 64) + j + 37], dd, aa, bb, cc, 2);

                          aa += fh_C(dane[((int)iterator * 64) + j + 1], aa, bb, cc, dd, 8);
                          bb += fh_C(dane[((int)iterator * 64) + j + 58], bb, cc, dd, aa, 5);
                          cc += fh_C(dane[((int)iterator * 64) + j + 62], cc, dd, aa, bb, 12);
                          dd += fh_C(dane[((int)iterator * 64) + j + 18], dd, aa, bb, cc, 2);

                          aa += fh_C(dane[((int)iterator * 64) + j + 60], aa, bb, cc, dd, 8);
                          bb += fh_C(dane[((int)iterator * 64) + j + 50], bb, cc, dd, aa, 5);
                          cc += fh_C(dane[((int)iterator * 64) + j + 40], cc, dd, aa, bb, 12);
                          dd += fh_C(dane[((int)iterator * 64) + j + 20], dd, aa, bb, cc, 2);

                          aa += fh_C(dane[((int)iterator * 64) + j + 2], aa, bb, cc, dd, 8);
                          bb += fh_C(dane[((int)iterator * 64) + j + 9], bb, cc, dd, aa, 5);
                          cc += fh_C(dane[((int)iterator * 64) + j + 3], cc, dd, aa, bb, 12);
                          dd += fh_C(dane[((int)iterator * 64) + j + 5], dd, aa, bb, cc, 2);




                          aa += fh_D(dane[((int)iterator * 64) + j + 52], aa, bb, cc, dd, 8);
                          bb += fh_D(dane[((int)iterator * 64) + j + 32], bb, cc, dd, aa, 5);
                          cc += fh_D(dane[((int)iterator * 64) + j + 33], cc, dd, aa, bb, 12);
                          dd += fh_D(dane[((int)iterator * 64) + j + 44], dd, aa, bb, cc, 2);

                          aa += fh_D(dane[((int)iterator * 64) + j + 27], aa, bb, cc, dd, 8);
                          bb += fh_D(dane[((int)iterator * 64) + j + 63], bb, cc, dd, aa, 5);
                          cc += fh_D(dane[((int)iterator * 64) + j + 54], cc, dd, aa, bb, 12);
                          dd += fh_D(dane[((int)iterator * 64) + j + 21], dd, aa, bb, cc, 2);

                          aa += fh_D(dane[((int)iterator * 64) + j + 13], aa, bb, cc, dd, 8);
                          bb += fh_D(dane[((int)iterator * 64) + j + 27], bb, cc, dd, aa, 5);
                          cc += fh_D(dane[((int)iterator * 64) + j + 52], cc, dd, aa, bb, 12);
                          dd += fh_D(dane[((int)iterator * 64) + j + 63], dd, aa, bb, cc, 2);

                          aa += fh_D(dane[((int)iterator * 64) + j + 24], aa, bb, cc, dd, 8);
                          bb += fh_D(dane[((int)iterator * 64) + j + 23], bb, cc, dd, aa, 5);
                          cc += fh_D(dane[((int)iterator * 64) + j + 3], cc, dd, aa, bb, 12);
                          dd += fh_D(dane[((int)iterator * 64) + j + 5], dd, aa, bb, cc, 2);

                          //System.Console.WriteLine(j);
                      //  }

                    A = BitConverter.GetBytes(BitConverter.ToUInt32(A,0) + aa);
                    B = BitConverter.GetBytes(BitConverter.ToUInt32(B, 0) + bb);
                    C = BitConverter.GetBytes(BitConverter.ToUInt32(C, 0) + cc);
                    D = BitConverter.GetBytes(BitConverter.ToUInt32(D, 0) + dd);

                    //System.Console.WriteLine(iterator);

                }
                //System.Console.WriteLine(ilosc_bitow + " " + ibloki + " " + koncówka + " " + dane.Count);
                //System.Console.WriteLine(A[0].ToString());
                return  Byte_To_String(A) + Byte_To_String(B) + Byte_To_String(C) + Byte_To_String(D);
                

        }
        public static string Byte_To_String(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public static UInt32 fh_A(byte podblok, UInt32 A, UInt32 B, UInt32 C, UInt32 D, int przesuniecie)
        {

            int tmp = Convert.ToInt32(podblok);

            return ((podblok & A) | (B & C & ~D ) << przesuniecie);
        }
        public static UInt32 fh_B(byte podblok, UInt32 A, UInt32 B, UInt32 C, UInt32 D, int przesuniecie)
        {


            return ((podblok | (A & C) | B & ~D) << przesuniecie); 
        }
        public static UInt32 fh_C(byte podblok, UInt32 A, UInt32 B, UInt32 C, UInt32 D, int przesuniecie)
        {


            return ((podblok | A) & ((~B | C) & D) << przesuniecie);
        }
        public static UInt32 fh_D(byte podblok, UInt32 A, UInt32 B, UInt32 C, UInt32 D, int przesuniecie)
        {


            return ((podblok & D) | ((A & B) & ~C) << przesuniecie);
        }
        public static void wyswietl_liste() {
            foreach (var i in dane) {
                System.Console.Write(i);
            }
        }
        public static bool get_bit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
        public static string MD5_fun(string filename) {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return Convert.ToBase64String(md5.ComputeHash(stream));
                }
            }
        }
        public static string SHA256_fun(string filename)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return Convert.ToBase64String(sha256.ComputeHash(stream));
                }
            }
        }
        public static string SHA512_fun(string filename)
        {
            using (var sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return Convert.ToBase64String(sha512.ComputeHash(stream));
                }
            }
        }
        public static string SHA384_fun(string filename)
        {
            using (var sha384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return Convert.ToBase64String(sha384.ComputeHash(stream));
                }
            }
        }
        public static float proc_zmieniony(string hash1, string hash2){
            float proc = 0;

            hash1 = string_to_binary(hash1);
            hash2 = string_to_binary(hash2);

            int ile01 = 0;

            for (int i = 0; i < hash1.Length;i++ )
            {
                if (hash1[i] != hash2[i])
                    ile01++;
            }

            proc = ((float)ile01/ hash1.Length) *100;
            


            return proc;
        }

        static void Main(string[] args) {

            string filename = "text.txt";
            string filename2 = "text2.txt";
            string filename3 = "text3.txt";
            string filename4 = "text4.txt";
            string filenametocom = "text1tocom.txt";
            string filenametocom2 = "text2tocom.txt";

            Stopwatch sw1= new Stopwatch();



            System.Console.WriteLine("Czasy dla moje algorytmu:");
            sw1.Reset();
            sw1.Start();
            //System.Console.WriteLine(funkcja_skrótu((filename)));
            sw1.Stop();
            System.Console.WriteLine("Plik 1mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            funkcja_skrótu((filename2));
            sw1.Stop();
            System.Console.WriteLine("Plik 5mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            funkcja_skrótu((filename3));
            sw1.Stop();
            System.Console.WriteLine("Plik 10mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            funkcja_skrótu((filename4));
            sw1.Stop();
            System.Console.WriteLine("Plik 20mb : {0}", sw1.Elapsed.TotalMilliseconds);
//            System.Console.WriteLine(funkcja_skrótu(filename));
            System.Console.WriteLine("Procent zmienionych bitów:");
            System.Console.WriteLine(proc_zmieniony(funkcja_skrótu(filenametocom), funkcja_skrótu(filenametocom2)));
            



            System.Console.WriteLine();
            System.Console.WriteLine("Czasy dla MD5 Cryptography:");
            sw1.Reset();
            sw1.Start();
            //System.Console.WriteLine((filename));
            sw1.Stop();
            System.Console.WriteLine("Plik 1mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            MD5_fun(filename2);
            sw1.Stop();
            System.Console.WriteLine("Plik 5mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            MD5_fun(filename3);
            sw1.Stop();
            System.Console.WriteLine("Plik 10mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            MD5_fun(filename4);
            sw1.Stop();
            System.Console.WriteLine("Plik 20mb : {0}", sw1.Elapsed.TotalMilliseconds);
            
            System.Console.WriteLine("Procent zmienionych bitów:");
            System.Console.WriteLine(proc_zmieniony(MD5_fun(filenametocom), MD5_fun(filenametocom2)));
            
            
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Czasy dla SHA256 Cryptography:");
            sw1.Reset();
            sw1.Start();
            SHA256_fun(filename);
            sw1.Stop();
            System.Console.WriteLine("Plik 1mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA256_fun(filename2);
            sw1.Stop();
            System.Console.WriteLine("Plik 5mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA256_fun(filename3);
            sw1.Stop();
            System.Console.WriteLine("Plik 10mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA256_fun(filename4);
            sw1.Stop();
            System.Console.WriteLine("Plik 20mb : {0}", sw1.Elapsed.TotalMilliseconds);
            System.Console.WriteLine();

            System.Console.WriteLine("Procent zmienionych bitów:");
            System.Console.WriteLine(proc_zmieniony(SHA256_fun(filenametocom), SHA256_fun(filenametocom2)));
            

            System.Console.WriteLine();
            System.Console.WriteLine("Czasy dla SHA512 Cryptography:");
            sw1.Reset();
            sw1.Start();
            SHA512_fun(filename);
            sw1.Stop();
            System.Console.WriteLine("Plik 1mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA512_fun(filename2);
            sw1.Stop();
            System.Console.WriteLine("Plik 5mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA512_fun(filename3);
            sw1.Stop();
            System.Console.WriteLine("Plik 10mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA512_fun(filename4);
            sw1.Stop();
            System.Console.WriteLine("Plik 20mb : {0}", sw1.Elapsed.TotalMilliseconds);

            System.Console.WriteLine("Procent zmienionych bitów:");
            System.Console.WriteLine(proc_zmieniony(SHA512_fun(filenametocom), SHA512_fun(filenametocom2)));
            


            System.Console.WriteLine();
            System.Console.WriteLine("Czasy dla SHA384 Cryptography:");
            sw1.Reset();
            sw1.Start();
            SHA384_fun(filename);
            sw1.Stop();
            System.Console.WriteLine("Plik 1mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA384_fun(filename2);
            sw1.Stop();
            System.Console.WriteLine("Plik 5mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA384_fun(filename3);
            sw1.Stop();
            System.Console.WriteLine("Plik 10mb : {0}", sw1.Elapsed.TotalMilliseconds);

            sw1.Reset();
            sw1.Start();
            SHA384_fun(filename4);
            sw1.Stop();
            System.Console.WriteLine("Plik 20mb : {0}", sw1.Elapsed.TotalMilliseconds);

            System.Console.WriteLine("Procent zmienionych bitów:");
            System.Console.WriteLine(proc_zmieniony(SHA384_fun(filenametocom), SHA384_fun(filenametocom2)));
            






            
            System.Console.ReadKey();
        }
    }
}
