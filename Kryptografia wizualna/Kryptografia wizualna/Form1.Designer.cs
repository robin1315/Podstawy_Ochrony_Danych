namespace Kryptografia_wizualna
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadPicture = new System.Windows.Forms.Button();
            this.pathSrc = new System.Windows.Forms.Label();
            this.dwaUdziały = new System.Windows.Forms.RadioButton();
            this.groupRadioButton = new System.Windows.Forms.GroupBox();
            this.dostosuj = new System.Windows.Forms.RadioButton();
            this.genPart = new System.Windows.Forms.Button();
            this.SavePictures = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadPart = new System.Windows.Forms.Button();
            this.fixTogether = new System.Windows.Forms.Button();
            this.showPart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.pathOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.trzyUdzialy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupRadioButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadPicture
            // 
            this.loadPicture.Location = new System.Drawing.Point(54, 176);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(94, 23);
            this.loadPicture.TabIndex = 1;
            this.loadPicture.Text = "Wczytaj obraz";
            this.loadPicture.UseVisualStyleBackColor = true;
            this.loadPicture.Click += new System.EventHandler(this.loadPicture_Click);
            // 
            // pathSrc
            // 
            this.pathSrc.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pathSrc.Location = new System.Drawing.Point(12, 201);
            this.pathSrc.MaximumSize = new System.Drawing.Size(180, 30);
            this.pathSrc.Name = "pathSrc";
            this.pathSrc.Size = new System.Drawing.Size(180, 30);
            this.pathSrc.TabIndex = 2;
            // 
            // dwaUdziały
            // 
            this.dwaUdziały.AutoSize = true;
            this.dwaUdziały.Location = new System.Drawing.Point(6, 19);
            this.dwaUdziały.Name = "dwaUdziały";
            this.dwaUdziały.Size = new System.Drawing.Size(82, 17);
            this.dwaUdziały.TabIndex = 3;
            this.dwaUdziały.TabStop = true;
            this.dwaUdziały.Text = "dwa udziały";
            this.dwaUdziały.UseVisualStyleBackColor = true;
            this.dwaUdziały.CheckedChanged += new System.EventHandler(this.dwaUdziały_CheckedChanged);
            // 
            // groupRadioButton
            // 
            this.groupRadioButton.Controls.Add(this.trzyUdzialy);
            this.groupRadioButton.Controls.Add(this.checkedListBox3);
            this.groupRadioButton.Controls.Add(this.checkedListBox2);
            this.groupRadioButton.Controls.Add(this.checkedListBox1);
            this.groupRadioButton.Controls.Add(this.numericUpDown3);
            this.groupRadioButton.Controls.Add(this.numericUpDown2);
            this.groupRadioButton.Controls.Add(this.label5);
            this.groupRadioButton.Controls.Add(this.label4);
            this.groupRadioButton.Controls.Add(this.dostosuj);
            this.groupRadioButton.Controls.Add(this.dwaUdziały);
            this.groupRadioButton.Location = new System.Drawing.Point(23, 237);
            this.groupRadioButton.Name = "groupRadioButton";
            this.groupRadioButton.Size = new System.Drawing.Size(170, 238);
            this.groupRadioButton.TabIndex = 4;
            this.groupRadioButton.TabStop = false;
            this.groupRadioButton.Text = "Ilość udziałów";
            // 
            // dostosuj
            // 
            this.dostosuj.AutoSize = true;
            this.dostosuj.Location = new System.Drawing.Point(7, 43);
            this.dostosuj.Name = "dostosuj";
            this.dostosuj.Size = new System.Drawing.Size(64, 17);
            this.dostosuj.TabIndex = 4;
            this.dostosuj.TabStop = true;
            this.dostosuj.Text = "dostosuj";
            this.dostosuj.UseVisualStyleBackColor = true;
            this.dostosuj.CheckedChanged += new System.EventHandler(this.dostosuj_CheckedChanged);
            // 
            // genPart
            // 
            this.genPart.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.genPart.Location = new System.Drawing.Point(22, 481);
            this.genPart.Name = "genPart";
            this.genPart.Size = new System.Drawing.Size(89, 23);
            this.genPart.TabIndex = 5;
            this.genPart.Text = "Generuj";
            this.genPart.UseVisualStyleBackColor = true;
            this.genPart.Click += new System.EventHandler(this.genPart_Click);
            // 
            // SavePictures
            // 
            this.SavePictures.Location = new System.Drawing.Point(118, 481);
            this.SavePictures.Name = "SavePictures";
            this.SavePictures.Size = new System.Drawing.Size(75, 23);
            this.SavePictures.TabIndex = 6;
            this.SavePictures.Text = "Zapisz";
            this.SavePictures.UseVisualStyleBackColor = true;
            this.SavePictures.Click += new System.EventHandler(this.SavePictures_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(456, 533);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(221, 5);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(224, 516);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(5, 4);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(196, 518);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(49, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tworzenie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(274, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sklejanie";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(241, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ilość udziałów";
            // 
            // LoadPart
            // 
            this.LoadPart.Location = new System.Drawing.Point(241, 55);
            this.LoadPart.Name = "LoadPart";
            this.LoadPart.Size = new System.Drawing.Size(92, 23);
            this.LoadPart.TabIndex = 12;
            this.LoadPart.Text = "Wczytaj udziały";
            this.LoadPart.UseVisualStyleBackColor = true;
            this.LoadPart.Click += new System.EventHandler(this.LoadPart_Click);
            // 
            // fixTogether
            // 
            this.fixTogether.Location = new System.Drawing.Point(241, 93);
            this.fixTogether.Name = "fixTogether";
            this.fixTogether.Size = new System.Drawing.Size(92, 23);
            this.fixTogether.TabIndex = 13;
            this.fixTogether.Text = "Sklejanie";
            this.fixTogether.UseVisualStyleBackColor = true;
            this.fixTogether.Click += new System.EventHandler(this.fixTogether_Click);
            // 
            // showPart
            // 
            this.showPart.Location = new System.Drawing.Point(339, 55);
            this.showPart.Name = "showPart";
            this.showPart.Size = new System.Drawing.Size(93, 23);
            this.showPart.TabIndex = 14;
            this.showPart.Text = "Pokaż udziały";
            this.showPart.UseVisualStyleBackColor = true;
            this.showPart.Click += new System.EventHandler(this.showPart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.pictureBox2.Location = new System.Drawing.Point(241, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(340, 93);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 23);
            this.Save.TabIndex = 16;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // pathOut
            // 
            this.pathOut.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pathOut.Location = new System.Drawing.Point(238, 340);
            this.pathOut.MaximumSize = new System.Drawing.Size(185, 30);
            this.pathOut.Name = "pathOut";
            this.pathOut.Size = new System.Drawing.Size(185, 30);
            this.pathOut.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ilość udziałów";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wymagane";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(88, 65);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(88, 86);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(9, 112);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(36, 109);
            this.checkedListBox1.TabIndex = 9;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Enabled = false;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(65, 112);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(36, 109);
            this.checkedListBox2.TabIndex = 10;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Enabled = false;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(123, 112);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(41, 109);
            this.checkedListBox3.TabIndex = 11;
            // 
            // trzyUdzialy
            // 
            this.trzyUdzialy.AutoSize = true;
            this.trzyUdzialy.Location = new System.Drawing.Point(88, 19);
            this.trzyUdzialy.Name = "trzyUdzialy";
            this.trzyUdzialy.Size = new System.Drawing.Size(78, 17);
            this.trzyUdzialy.TabIndex = 12;
            this.trzyUdzialy.TabStop = true;
            this.trzyUdzialy.Text = "trzy udziały";
            this.trzyUdzialy.UseVisualStyleBackColor = true;
            this.trzyUdzialy.CheckedChanged += new System.EventHandler(this.trzyUdzialy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 533);
            this.Controls.Add(this.pathOut);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showPart);
            this.Controls.Add(this.fixTogether);
            this.Controls.Add(this.LoadPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SavePictures);
            this.Controls.Add(this.genPart);
            this.Controls.Add(this.groupRadioButton);
            this.Controls.Add(this.pathSrc);
            this.Controls.Add(this.loadPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupRadioButton.ResumeLayout(false);
            this.groupRadioButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadPicture;
        private System.Windows.Forms.Label pathSrc;
        private System.Windows.Forms.RadioButton dwaUdziały;
        private System.Windows.Forms.GroupBox groupRadioButton;
        private System.Windows.Forms.RadioButton dostosuj;
        private System.Windows.Forms.Button genPart;
        private System.Windows.Forms.Button SavePictures;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoadPart;
        private System.Windows.Forms.Button fixTogether;
        private System.Windows.Forms.Button showPart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label pathOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.RadioButton trzyUdzialy;
    }
}

