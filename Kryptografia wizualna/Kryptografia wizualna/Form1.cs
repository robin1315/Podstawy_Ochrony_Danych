using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kryptografia_wizualna
{
    public partial class Form1 : Form
    {
        const int rows = 6;
        const int columns = 4;
        const int rowsThree = 13;
        const int columnsThree = 9;
        private Bitmap[] desBmap;
        private Bitmap[] srcBmap;
        private Bitmap FinalBmap;
        int[,] matrixSubPixel = new int[rows, columns]{
                                    {1,1,0,0},
                                    {0,0,1,1},
                                    {1,0,1,0},
                                    {0,1,0,1},
                                    {1,0,0,1},
                                    {0,1,1,0}
                                    };

        int[,] matrixSubPixelThree = new int[rowsThree, columnsThree]{
                                    {1,1,1,1,0,0,0,0,0},
                                    {0,1,1,1,1,0,0,0,0},
                                    {0,0,1,1,1,1,0,0,0},
                                    {0,0,0,1,1,1,1,0,0},
                                    {0,0,0,0,1,1,1,1,0},
                                    {0,0,0,0,0,1,1,1,1},
                                    {1,0,0,0,0,0,1,1,1},
                                    {1,1,0,0,0,0,0,1,1},
                                    {1,1,1,0,0,0,0,0,1},
                                    {1,1,1,0,1,0,0,0,0},
                                    {1,1,0,0,1,0,1,0,0},
                                    {1,0,1,0,1,0,0,1,0},
                                    {1,1,0,0,1,1,0,0,0},
                                    };
   
        
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }
        private void loadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.png, *.jpg, *.bmp) | *.png; *.jpg; *.bmp";
            open.InitialDirectory = @"C:\";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName.ToString();
                pathSrc.Text = open.FileName.ToString();
            }
        }
        private void genPart_Click(object sender, EventArgs e)
        {
            if (dostosuj.Checked)
            {
                genParam((int)numericUpDown2.Value, (int)numericUpDown3.Value);
            }
            else if (dwaUdziały.Checked)
                genTwo();
            else if (trzyUdzialy.Checked)
                genThree();
        }

        private void genThree()
        {
            if (pathSrc.Text == "")
                return;
            Bitmap Bmap = new Bitmap(pathSrc.Text);
            desBmap = new Bitmap[3];
            desBmap[0] = new Bitmap(Bmap.Width * 2, Bmap.Height * 2);
            desBmap[1] = new Bitmap(Bmap.Width * 2, Bmap.Height * 2);
            desBmap[2] = new Bitmap(Bmap.Width * 2, Bmap.Height * 2);
            Random rand = new Random();
            int r = 0;

            for (int i = 0; i < Bmap.Width; i++)
                for (int j = 0; j < Bmap.Height; j++)
                {
                    r = rand.Next(0, 6);

                    if (Bmap.GetPixel(i, j).ToArgb() == Color.White.ToArgb())
                    {
                        for (int k = 0; k < desBmap.Length; k++)
                        {
                            if (matrixSubPixel[r, 0] == 1)
                                desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                            if (matrixSubPixel[r, 1] == 1)
                                desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                            if (matrixSubPixel[r, 2] == 1)
                                desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                            if (matrixSubPixel[r, 3] == 1)
                                desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                        }

                    }
                    else if (Bmap.GetPixel(i, j).ToArgb() == Color.Black.ToArgb()) // jezeli jest czarny
                    {
                        for (int k = 0; k < desBmap.Length; k++)
                        {
                            if (k  == 0)
                            {
                                if (matrixSubPixel[r, 0] == 1)
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                                if (matrixSubPixel[r, 1] == 1)
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                                if (matrixSubPixel[r, 2] == 1)
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                                if (matrixSubPixel[r, 3] == 1)
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                            }
                            else if( k==1)
                            {

                                if (!(matrixSubPixel[r, 0] == 1))
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                                if (!(matrixSubPixel[r, 1] == 1))
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                                if (!(matrixSubPixel[r, 2] == 1))
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                                if (!(matrixSubPixel[r, 3] == 1))
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                            }
                            else if (k == 2)
                            {

                                if (!(matrixSubPixel[r, 0] == 1))
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                                if (!(matrixSubPixel[r, 1] == 1))
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                                if (!(matrixSubPixel[r, 2] == 1))
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                                if (!(matrixSubPixel[r, 3] == 1))
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                            }
                        }
                    }
                }
        }
        private void genTwo()
        {
            if (pathSrc.Text == "")
                return;
            Bitmap Bmap = new Bitmap(pathSrc.Text);
            desBmap = new Bitmap[2];
            desBmap[0] = new Bitmap(Bmap.Width * 2, Bmap.Height * 2);
            desBmap[1] = new Bitmap(Bmap.Width * 2, Bmap.Height * 2);
            
            Random rand = new Random();
            int r=0;

            for(int i =0; i< Bmap.Width; i++)
                for (int j = 0; j < Bmap.Height; j++)
                {
                    r = rand.Next(0,6);

                    if (Bmap.GetPixel(i, j).ToArgb() == Color.White.ToArgb())
                    {
                        for (int k = 0; k < desBmap.Length; k++)
                        {
                            if (matrixSubPixel[r, 0] == 1)
                                desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                            if (matrixSubPixel[r, 1] == 1)
                                desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                            if (matrixSubPixel[r, 2] == 1)
                                desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                            if (matrixSubPixel[r, 3] == 1)
                                desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                            else
                                desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                        }

                    }
                    else if (Bmap.GetPixel(i, j).ToArgb() == Color.Black.ToArgb()) // jezeli jest czarny
                    {
                        for (int k = 0; k < desBmap.Length; k++)
                        {
                            if (k % 2 == 0)
                            {
                                if (matrixSubPixel[r, 0] == 1)
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                                if (matrixSubPixel[r, 1] == 1)
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                                if (matrixSubPixel[r, 2] == 1)
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                                if (matrixSubPixel[r, 3] == 1)
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                            }
                            else
                            {

                                if (!(matrixSubPixel[r, 0] == 1))
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                                if (!(matrixSubPixel[r, 1] == 1))
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                                if (!(matrixSubPixel[r, 2] == 1))
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                                if (!(matrixSubPixel[r, 3] == 1))
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                                else
                                    desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);
                            }
                        }
                    }
                }
        }
        private void genParam(int numberOfPart, int needAmountOfPart)
        {
            if (pathSrc.Text == "")
                return;
            Bitmap Bmap = new Bitmap(pathSrc.Text);
            desBmap = new Bitmap[numberOfPart];
            for(int i=0;i<numberOfPart;i++)
                desBmap[i] = new Bitmap(Bmap.Width * 2, Bmap.Height * 2);
                        
            Random rand = new Random();
            int r=0;




                    for (int i = 0; i < Bmap.Width; i++)
                        for (int j = 0; j < Bmap.Height; j++)
                        {
                            r = rand.Next(0, columnsThree);

                            if (Bmap.GetPixel(i, j).ToArgb() == Color.White.ToArgb())
                            {
                                for (int k = 0; k < desBmap.Length; k++)
                                {

                                    if (matrixSubPixelThree[r, 0] == 1)
                                        desBmap[k].SetPixel(i * 2, j * 2, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2, j * 2, Color.White);

                                    if (matrixSubPixelThree[r, 1] == 1)
                                        desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2 + 1, j * 2, Color.White);

                                    if (matrixSubPixelThree[r, 2] == 1)
                                        desBmap[k].SetPixel(i * 2 + 2, j * 2, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2 + 2, j * 2, Color.White);

                                    if (matrixSubPixelThree[r, 3] == 1)
                                        desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2, j * 2 + 1, Color.White);

                                    if (matrixSubPixelThree[r, 4] == 1)
                                        desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2 + 1, j * 2 + 1, Color.White);

                                    if (matrixSubPixelThree[r, 5] == 1)
                                        desBmap[k].SetPixel(i * 2 + 2, j * 2 + 1, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2 + 2, j * 2 + 1, Color.White);

                                    if (matrixSubPixelThree[r, 6] == 1)
                                        desBmap[k].SetPixel(i * 2, j * 2 + 2, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2, j * 2 + 2, Color.White);

                                    if (matrixSubPixelThree[r, 7] == 1)
                                        desBmap[k].SetPixel(i * 2 + 1, j * 2 + 2, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2 + 1, j * 2 + 2, Color.White);

                                    if (matrixSubPixelThree[r, 8] == 1)
                                        desBmap[k].SetPixel(i * 2 + 2, j * 2 + 2, Color.Black);
                                    else
                                        desBmap[k].SetPixel(i * 2 + 2, j * 2 + 2, Color.White);
                                }

                            }
                            else if (Bmap.GetPixel(i, j).ToArgb() == Color.Black.ToArgb())
                            {
                            }
                        }
            //throw new NotImplementedException();
        }
        private void SavePictures_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveD = new SaveFileDialog();
            SaveD.Filter = "Image Files (*.png, *.bmp) | *.png; *.bmp;";
            SaveD.InitialDirectory = @"c:\";

            for (int i=0; i < desBmap.Length; i++)
                if (SaveD.ShowDialog() == DialogResult.OK)
                    desBmap[i].Save(SaveD.FileName.ToString());
        }
        private void LoadPart_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDown1.Value;
            srcBmap = new Bitmap[amount];

            OpenFileDialog OpenD = new OpenFileDialog();
            OpenD.Filter = "Image Files (*.png, *.bmp) | *.png; *.bmp;";
            OpenD.InitialDirectory = @"c:\";

           
            for (int i = 0; i < srcBmap.Length; i++)
            {
                if (OpenD.ShowDialog() == DialogResult.OK)
                {
                    srcBmap[i] = new Bitmap(OpenD.FileName.ToString());
                   
                }
            }

        }
        private void fixTogether_Click(object sender, EventArgs e)
        {
            FinalBmap = new Bitmap(srcBmap[0].Width/2, srcBmap[0].Height/2);
            int[] SubPixel = new int[4]{0,0,0,0};
            Color[] pixel= new Color[4];
            int numberOfpartFil = 0;

            for(int i =0; i < FinalBmap.Width; i++)
                for (int j = 0; j < FinalBmap.Height; j++)
                {
                    numberOfpartFil = 0;
                    SubPixel = new int[4]{0,0,0,0};
                    for (int k = 0; k < srcBmap.Length; k++) {
                        pixel[0] = srcBmap[k].GetPixel(i * 2, j * 2);
                        pixel[1] = srcBmap[k].GetPixel(i * 2, j * 2 + 1);
                        pixel[2] = srcBmap[k].GetPixel(i * 2 + 1, j * 2);
                        pixel[3] = srcBmap[k].GetPixel(i * 2 + 1, j * 2 + 1);

                        for(int h=0;h<4;h++)
                            if (pixel[h].ToArgb() == Color.Black.ToArgb())
                                SubPixel[h] = 1;
                    }
                    foreach(int tmp in SubPixel)
                        numberOfpartFil += tmp;

                    if (numberOfpartFil == 4)
                        FinalBmap.SetPixel(i, j, Color.Black);
                    else
                        FinalBmap.SetPixel(i, j, Color.White);
                }
            pictureBox2.Image = FinalBmap;

        }
        private void showPart_Click(object sender, EventArgs e)
        {
            Form2 f1;
            for (int i = 0; i < srcBmap.Length; i++)
            {
                    f1 = new Form2(srcBmap[i]);
                    f1.Show();
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveD = new SaveFileDialog();
            SaveD.Filter = "Image Files (*.png, *.bmp) | *.png; *.bmp;";
            SaveD.InitialDirectory = @"c:\";

            if (SaveD.ShowDialog() == DialogResult.OK)
            {
                FinalBmap.Save(SaveD.FileName.ToString());
                pathOut.Text = SaveD.FileName.ToString();
            }
        }

        private void dostosuj_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            checkedListBox1.Enabled = true;
            checkedListBox2.Enabled = true;
            checkedListBox3.Enabled = true;

        }
        private void dwaUdziały_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            checkedListBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            checkedListBox3.Enabled = false;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown2.Value < (int)numericUpDown3.Value)
                numericUpDown2.Value = (int)numericUpDown3.Value;
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Clear();
            for (int i = 0; i < (int)numericUpDown3.Value; i++)
            {
                checkedListBox1.Items.Add(i);
                checkedListBox2.Items.Add(i);
                checkedListBox3.Items.Add(i);
            }
            if ((int)numericUpDown3.Value == (int)numericUpDown2.Value)
            {
                checkedListBox1.Enabled = false;
                checkedListBox2.Enabled = false;
                checkedListBox3.Enabled = false;
            }
            else
            {
                checkedListBox1.Enabled = true;
                checkedListBox2.Enabled = true;
                checkedListBox3.Enabled = true;
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown3.Value > (int)numericUpDown2.Value)
                numericUpDown3.Value = (int)numericUpDown2.Value;
            if ((int)numericUpDown3.Value == (int)numericUpDown2.Value)
            {
                checkedListBox1.Enabled = false;
                checkedListBox2.Enabled = false;
                checkedListBox3.Enabled = false;
            }
            else {
                checkedListBox1.Enabled = true;
                checkedListBox2.Enabled = true;
                checkedListBox3.Enabled = true;
            }
        }

        private void trzyUdzialy_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            checkedListBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            checkedListBox3.Enabled = false;
        }
    }
}
