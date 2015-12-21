namespace Steganografia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wczytaj = new System.Windows.Forms.Button();
            this.Ukryj = new System.Windows.Forms.Button();
            this.Czaruj = new System.Windows.Forms.Button();
            this.TB_wiadomosc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TB_sciezka = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Zapisz = new System.Windows.Forms.Button();
            this.TB_sciezka_out = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Wczytaj_2 = new System.Windows.Forms.Button();
            this.TB_sciezka_czar = new System.Windows.Forms.TextBox();
            this.Czarowanie = new System.Windows.Forms.Label();
            this.TB_wiadomosc_out = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(65, 255);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(75, 23);
            this.wczytaj.TabIndex = 0;
            this.wczytaj.Text = "Wczytaj";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // Ukryj
            // 
            this.Ukryj.Location = new System.Drawing.Point(193, 378);
            this.Ukryj.Name = "Ukryj";
            this.Ukryj.Size = new System.Drawing.Size(75, 23);
            this.Ukryj.TabIndex = 1;
            this.Ukryj.Text = "Ukryj";
            this.Ukryj.UseVisualStyleBackColor = true;
            this.Ukryj.Click += new System.EventHandler(this.Ukryj_Click);
            // 
            // Czaruj
            // 
            this.Czaruj.Location = new System.Drawing.Point(578, 378);
            this.Czaruj.Name = "Czaruj";
            this.Czaruj.Size = new System.Drawing.Size(75, 23);
            this.Czaruj.TabIndex = 2;
            this.Czaruj.Text = "Czaruj";
            this.Czaruj.UseVisualStyleBackColor = true;
            this.Czaruj.Click += new System.EventHandler(this.Czaruj_Click);
            // 
            // TB_wiadomosc
            // 
            this.TB_wiadomosc.Location = new System.Drawing.Point(21, 419);
            this.TB_wiadomosc.Multiline = true;
            this.TB_wiadomosc.Name = "TB_wiadomosc";
            this.TB_wiadomosc.Size = new System.Drawing.Size(446, 120);
            this.TB_wiadomosc.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(21, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TB_sciezka
            // 
            this.TB_sciezka.Enabled = false;
            this.TB_sciezka.Location = new System.Drawing.Point(21, 284);
            this.TB_sciezka.Multiline = true;
            this.TB_sciezka.Name = "TB_sciezka";
            this.TB_sciezka.Size = new System.Drawing.Size(174, 55);
            this.TB_sciezka.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(276, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(325, 255);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 7;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // TB_sciezka_out
            // 
            this.TB_sciezka_out.Enabled = false;
            this.TB_sciezka_out.Location = new System.Drawing.Point(276, 284);
            this.TB_sciezka_out.Multiline = true;
            this.TB_sciezka_out.Name = "TB_sciezka_out";
            this.TB_sciezka_out.Size = new System.Drawing.Size(174, 55);
            this.TB_sciezka_out.TabIndex = 8;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(754, 551);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(500, 10);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(240, 340);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(12, 9);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(454, 340);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(167, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ukrywanie";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(532, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(174, 181);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Wczytaj_2
            // 
            this.Wczytaj_2.Location = new System.Drawing.Point(578, 255);
            this.Wczytaj_2.Name = "Wczytaj_2";
            this.Wczytaj_2.Size = new System.Drawing.Size(75, 23);
            this.Wczytaj_2.TabIndex = 12;
            this.Wczytaj_2.Text = "Wczytaj";
            this.Wczytaj_2.UseVisualStyleBackColor = true;
            this.Wczytaj_2.Click += new System.EventHandler(this.Wczytaj_2_Click);
            // 
            // TB_sciezka_czar
            // 
            this.TB_sciezka_czar.Enabled = false;
            this.TB_sciezka_czar.Location = new System.Drawing.Point(532, 284);
            this.TB_sciezka_czar.Multiline = true;
            this.TB_sciezka_czar.Name = "TB_sciezka_czar";
            this.TB_sciezka_czar.Size = new System.Drawing.Size(174, 55);
            this.TB_sciezka_czar.TabIndex = 13;
            // 
            // Czarowanie
            // 
            this.Czarowanie.AutoSize = true;
            this.Czarowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Czarowanie.Location = new System.Drawing.Point(539, 19);
            this.Czarowanie.Name = "Czarowanie";
            this.Czarowanie.Size = new System.Drawing.Size(158, 31);
            this.Czarowanie.TabIndex = 14;
            this.Czarowanie.Text = "Czarowanie";
            // 
            // TB_wiadomosc_out
            // 
            this.TB_wiadomosc_out.Location = new System.Drawing.Point(473, 419);
            this.TB_wiadomosc_out.Multiline = true;
            this.TB_wiadomosc_out.Name = "TB_wiadomosc_out";
            this.TB_wiadomosc_out.Size = new System.Drawing.Size(268, 120);
            this.TB_wiadomosc_out.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(300, 378);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 551);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TB_wiadomosc_out);
            this.Controls.Add(this.Czarowanie);
            this.Controls.Add(this.TB_sciezka_czar);
            this.Controls.Add(this.Wczytaj_2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_sciezka_out);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TB_sciezka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TB_wiadomosc);
            this.Controls.Add(this.Czaruj);
            this.Controls.Add(this.Ukryj);
            this.Controls.Add(this.wczytaj);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wczytaj;
        private System.Windows.Forms.Button Ukryj;
        private System.Windows.Forms.Button Czaruj;
        private System.Windows.Forms.TextBox TB_wiadomosc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TB_sciezka;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.TextBox TB_sciezka_out;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Wczytaj_2;
        private System.Windows.Forms.TextBox TB_sciezka_czar;
        private System.Windows.Forms.Label Czarowanie;
        private System.Windows.Forms.TextBox TB_wiadomosc_out;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

