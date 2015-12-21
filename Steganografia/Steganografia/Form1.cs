using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        public static Bitmap Bmapa_src;
        private Bitmap Bmapa_des;
        private Bitmap Bmapa_out;
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            InitializeComponent();
            
        }

        /*
         * 
         *      UKRYWANIE
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
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static string IntToBin(int value, int len)
        {
            return (len > 1 ? IntToBin(value >> 1, len - 1) : null) + "01"[value & 1];
        }
        private void wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\metech\Desktop";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                TB_sciezka.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = TB_sciezka.Text;
            }

        }
        private void Ukryj_Click(object sender, EventArgs e)
        {
      
         Bmapa_src = new Bitmap(TB_sciezka.Text);
         Bmapa_des = Bmapa_src;
            /// przygotowanie ilosci bitow do zapisywania
            int[] ilosc_bitów = new int[3];
            string tmp = IntToBin((int)numericUpDown1.Value, 3);
            ilosc_bitów[0] =  Int32.Parse( tmp[0].ToString());
            ilosc_bitów[1] = Int32.Parse(tmp[1].ToString());
            ilosc_bitów[2] = Int32.Parse(tmp[2].ToString());

            int nailubitach = (int)numericUpDown1.Value;

            //przygotowanie stringa
            
            string wiadomosc = string_to_binary(TB_wiadomosc.Text);
            
            while ((wiadomosc.Length % (nailubitach*3)) > 0)
                wiadomosc =wiadomosc + "0";
                
            int ilepixeli = (wiadomosc.Length / nailubitach) / 3;
            

            int tmp_R = 0;
            int tmp_G = 0;
            int tmp_B = 0;
            
            //
            int ilosc_bitow_mod = 2;
            switch (nailubitach)
            {
                case 1:
                    ilosc_bitow_mod = 2;
                    break;
                    
                case 2:
                    ilosc_bitow_mod = 4;
                    break;
                case 3:
                    ilosc_bitow_mod = 8;
                    break;
                case 4:
                    ilosc_bitow_mod = 16;
                    break;
                case 5:
                    ilosc_bitow_mod = 32;
                    break;
                    
                case 6:
                    ilosc_bitow_mod = 64;
                    break;
                case 7:
                    ilosc_bitow_mod = 128;
                    break;

                default:
                    ilosc_bitow_mod = 2;
                    break;
            }

           // głowna petla

            for (int i = 0; i < Bmapa_src.Width; i++){
                for (int j = 0; j < Bmapa_src.Height; j++)
                {
                    Color piksel = Bmapa_src.GetPixel(i,j);

                    
                    if (i == Bmapa_src.Width-1 && j == Bmapa_src.Height-1)
                    {
                        // czyszczenie ostatniego bitu na kazdej składowej
                        tmp_R = piksel.R - piksel.R % 2;
                        tmp_G = piksel.G - piksel.G % 2;
                        tmp_B = piksel.B - piksel.B % 2;
                        
                        tmp_R = tmp_R | (tmp_R + ilosc_bitów[0]);
                        tmp_G = tmp_G | (tmp_G + ilosc_bitów[1]);
                        tmp_B = tmp_B | (tmp_B + ilosc_bitów[2]);
                        
                        Bmapa_des.SetPixel(i, j, Color.FromArgb(tmp_R, tmp_G, tmp_B));
                    }
                    else if (i == Bmapa_src.Width-1 && j == Bmapa_src.Height-2)
                    {
                        tmp_R = 0;
                        tmp_G = 0;
                        tmp_B = 0;

                        if (TB_wiadomosc.TextLength < 255)
                        {
                            tmp_R = 0;
                            tmp_G = TB_wiadomosc.TextLength;
                        }
                        else if (TB_wiadomosc.TextLength > 255)
                        {
                            tmp_R = TB_wiadomosc.TextLength / 256;
                            tmp_G = TB_wiadomosc.TextLength % 256;
                        }

                        Bmapa_des.SetPixel(i, j, Color.FromArgb(tmp_R, tmp_G, tmp_B));
                    }
                    else
                    { 
                        if (ilepixeli > 0) {
                            tmp_R = piksel.R - piksel.R % ilosc_bitow_mod;
                            tmp_G = piksel.G - piksel.G % ilosc_bitow_mod;
                            tmp_B = piksel.B - piksel.B % ilosc_bitow_mod;

                            tmp_R = tmp_R + Convert.ToInt32( wiadomosc.Substring(0, nailubitach),2);
                            wiadomosc = wiadomosc.Substring(nailubitach);

                            tmp_G = tmp_G + Convert.ToInt32(wiadomosc.Substring(0, nailubitach),2);
                            wiadomosc = wiadomosc.Substring(nailubitach);

                            tmp_B = tmp_B + Convert.ToInt32(wiadomosc.Substring(0, nailubitach),2);
                            wiadomosc = wiadomosc.Substring(nailubitach);
                            ilepixeli--;
                            Bmapa_des.SetPixel(i, j, Color.FromArgb(piksel.A,tmp_R, tmp_G, tmp_B));
                        }                    
                    }                    
                }
            }
            pictureBox2.Image = Bmapa_des;
            
        }    
        private void Zapisz_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog SaveD = new SaveFileDialog();
            SaveD.Filter = "Image Files (*.png, *.bmp) | *.png; *.bmp;";
            SaveD.InitialDirectory = @"c:\";
            TB_sciezka_out.Text = "";
            pictureBox2.ImageLocation = ""; 
            if (SaveD.ShowDialog() == DialogResult.OK)
            {
                TB_sciezka_out.Text = SaveD.FileName.ToString();
                pictureBox2.ImageLocation = TB_sciezka_out.Text;

                Bmapa_des.Save(SaveD.FileName.ToString());
            }
        
        }
        


        /*
         * 
         *      CZAROWANIE
         * 
         */ 


        private void Wczytaj_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenD = new OpenFileDialog();
            OpenD.Filter = "Image Files (*.png, *.bmp) | *.png; *.bmp;";
            OpenD.InitialDirectory = @"c:\";

            if (OpenD.ShowDialog() == DialogResult.OK)
            {
                TB_sciezka_czar.Text = OpenD.FileName.ToString();
                pictureBox3.ImageLocation = TB_sciezka_czar.Text;
            }
        }
        private void Czaruj_Click(object sender, EventArgs e)
        {
            Bmapa_out = new Bitmap(TB_sciezka_czar.Text);
            Color piksel;
            string wiadomosc_out = "";

            int tmp_R = 0;
            int tmp_G = 0;
            int tmp_B = 0;
            
                piksel = Bmapa_out.GetPixel(Bmapa_out.Width-1, Bmapa_out.Height-1);
                        tmp_R = piksel.R % 2;
                        tmp_G = piksel.G % 2;
                        tmp_B = piksel.B % 2;

            int ile_bitów_czytac = Convert.ToInt32((tmp_R.ToString() + tmp_G.ToString() + tmp_B.ToString()), 2);
            piksel = Bmapa_out.GetPixel(Bmapa_out.Width-1,Bmapa_out.Height-2);

            int wiadomosc_dl= 0;
            tmp_R = piksel.R;
            tmp_G = piksel.G;
            if(tmp_R == 0)
                   wiadomosc_dl = tmp_G;
            else
            {
                   wiadomosc_dl = tmp_R*256 + tmp_G;
            }

            // głowna petla

            int dl_st = wiadomosc_dl * 8;

            for (int i = 0; i < Bmapa_out.Width; i++)
                for (int j = 0; j < Bmapa_out.Height; j++)
                {
                    piksel = Bmapa_out.GetPixel(i, j);

                    if (wiadomosc_out.Length < dl_st)
                    {
                        tmp_R = piksel.R;
                        tmp_G = piksel.G;
                        tmp_B = piksel.B;

                        wiadomosc_out += IntToBin(tmp_R, ile_bitów_czytac).ToString() + IntToBin(tmp_G, ile_bitów_czytac).ToString() + IntToBin(tmp_B, ile_bitów_czytac).ToString();
                    }
                       
                 }


            TB_wiadomosc_out.Text = BinaryToString(wiadomosc_out.Substring(0,wiadomosc_dl*8));
        
        }
        }
    }

