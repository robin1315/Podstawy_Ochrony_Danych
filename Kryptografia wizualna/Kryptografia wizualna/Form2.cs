using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kryptografia_wizualna
{
    public partial class Form2 : Form
    {
        public Form2(Bitmap Bmap)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            this.pictureBox1.Image = Bmap; 
        }
    }
}
