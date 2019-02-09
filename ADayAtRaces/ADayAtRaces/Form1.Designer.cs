namespace ADayAtRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Joelabel = new System.Windows.Forms.Label();
            this.Boblabel = new System.Windows.Forms.Label();
            this.Allabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.MinimunBetLabel = new System.Windows.Forms.Label();
            this.JoeradioButton = new System.Windows.Forms.RadioButton();
            this.BobradioButton = new System.Windows.Forms.RadioButton();
            this.AlradioButton = new System.Windows.Forms.RadioButton();
            this.StartTheGameButton = new System.Windows.Forms.Button();
            this.RaceTrackpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            this.Dog1Location = new System.Windows.Forms.Label();
            this.Dog2Location = new System.Windows.Forms.Label();
            this.Dog3Location = new System.Windows.Forms.Label();
            this.Dog4Location = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.Joelabel);
            this.groupBox1.Controls.Add(this.Boblabel);
            this.groupBox1.Controls.Add(this.Allabel);
            this.groupBox1.Controls.Add(this.BetLabel);
            this.groupBox1.Controls.Add(this.MinimunBetLabel);
            this.groupBox1.Controls.Add(this.JoeradioButton);
            this.groupBox1.Controls.Add(this.BobradioButton);
            this.groupBox1.Controls.Add(this.AlradioButton);
            this.groupBox1.Controls.Add(this.StartTheGameButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(362, 118);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "on dog";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(192, 118);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Bets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 118);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 9;
            // 
            // Joelabel
            // 
            this.Joelabel.AutoSize = true;
            this.Joelabel.Location = new System.Drawing.Point(310, 83);
            this.Joelabel.Name = "Joelabel";
            this.Joelabel.Size = new System.Drawing.Size(39, 13);
            this.Joelabel.TabIndex = 8;
            this.Joelabel.Text = "No bet";
            // 
            // Boblabel
            // 
            this.Boblabel.AutoSize = true;
            this.Boblabel.Location = new System.Drawing.Point(310, 59);
            this.Boblabel.Name = "Boblabel";
            this.Boblabel.Size = new System.Drawing.Size(39, 13);
            this.Boblabel.TabIndex = 7;
            this.Boblabel.Text = "No bet";
            // 
            // Allabel
            // 
            this.Allabel.AutoSize = true;
            this.Allabel.Location = new System.Drawing.Point(310, 35);
            this.Allabel.Name = "Allabel";
            this.Allabel.Size = new System.Drawing.Size(39, 13);
            this.Allabel.TabIndex = 6;
            this.Allabel.Text = "No bet";
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.Location = new System.Drawing.Point(309, 13);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(46, 20);
            this.BetLabel.TabIndex = 5;
            this.BetLabel.Text = "Bets";
            // 
            // MinimunBetLabel
            // 
            this.MinimunBetLabel.AutoSize = true;
            this.MinimunBetLabel.Location = new System.Drawing.Point(3, 18);
            this.MinimunBetLabel.Name = "MinimunBetLabel";
            this.MinimunBetLabel.Size = new System.Drawing.Size(89, 13);
            this.MinimunBetLabel.TabIndex = 4;
            this.MinimunBetLabel.Text = "Minimun bet is 5$";
            // 
            // JoeradioButton
            // 
            this.JoeradioButton.AutoSize = true;
            this.JoeradioButton.Location = new System.Drawing.Point(6, 83);
            this.JoeradioButton.Name = "JoeradioButton";
            this.JoeradioButton.Size = new System.Drawing.Size(85, 17);
            this.JoeradioButton.TabIndex = 3;
            this.JoeradioButton.TabStop = true;
            this.JoeradioButton.Text = "radioButton3";
            this.JoeradioButton.UseVisualStyleBackColor = true;
            this.JoeradioButton.CheckedChanged += new System.EventHandler(this.JoeradioButton_CheckedChanged);
            // 
            // BobradioButton
            // 
            this.BobradioButton.AutoSize = true;
            this.BobradioButton.Location = new System.Drawing.Point(6, 59);
            this.BobradioButton.Name = "BobradioButton";
            this.BobradioButton.Size = new System.Drawing.Size(85, 17);
            this.BobradioButton.TabIndex = 2;
            this.BobradioButton.TabStop = true;
            this.BobradioButton.Text = "radioButton2";
            this.BobradioButton.UseVisualStyleBackColor = true;
            this.BobradioButton.CheckedChanged += new System.EventHandler(this.BobradioButton_CheckedChanged);
            // 
            // AlradioButton
            // 
            this.AlradioButton.AutoSize = true;
            this.AlradioButton.Location = new System.Drawing.Point(6, 35);
            this.AlradioButton.Name = "AlradioButton";
            this.AlradioButton.Size = new System.Drawing.Size(85, 17);
            this.AlradioButton.TabIndex = 1;
            this.AlradioButton.TabStop = true;
            this.AlradioButton.Text = "radioButton1";
            this.AlradioButton.UseVisualStyleBackColor = true;
            this.AlradioButton.CheckedChanged += new System.EventHandler(this.AlradioButton_CheckedChanged);
            // 
            // StartTheGameButton
            // 
            this.StartTheGameButton.Location = new System.Drawing.Point(703, 35);
            this.StartTheGameButton.Name = "StartTheGameButton";
            this.StartTheGameButton.Size = new System.Drawing.Size(173, 78);
            this.StartTheGameButton.TabIndex = 0;
            this.StartTheGameButton.Text = "Start the race";
            this.StartTheGameButton.UseVisualStyleBackColor = true;
            this.StartTheGameButton.Click += new System.EventHandler(this.StartTheGameButton_Click);
            // 
            // RaceTrackpictureBox
            // 
            this.RaceTrackpictureBox.Location = new System.Drawing.Point(12, 13);
            this.RaceTrackpictureBox.Name = "RaceTrackpictureBox";
            this.RaceTrackpictureBox.Size = new System.Drawing.Size(900, 190);
            this.RaceTrackpictureBox.TabIndex = 1;
            this.RaceTrackpictureBox.TabStop = false;
            // 
            // pictureBoxDog1
            // 
            this.pictureBoxDog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog1.Image")));
            this.pictureBoxDog1.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxDog1.Name = "pictureBoxDog1";
            this.pictureBoxDog1.Size = new System.Drawing.Size(100, 30);
            this.pictureBoxDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDog1.TabIndex = 2;
            this.pictureBoxDog1.TabStop = false;
            // 
            // pictureBoxDog3
            // 
            this.pictureBoxDog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog3.Image")));
            this.pictureBoxDog3.Location = new System.Drawing.Point(12, 112);
            this.pictureBoxDog3.Name = "pictureBoxDog3";
            this.pictureBoxDog3.Size = new System.Drawing.Size(100, 30);
            this.pictureBoxDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDog3.TabIndex = 3;
            this.pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this.pictureBoxDog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog2.Image")));
            this.pictureBoxDog2.Location = new System.Drawing.Point(12, 67);
            this.pictureBoxDog2.Name = "pictureBoxDog2";
            this.pictureBoxDog2.Size = new System.Drawing.Size(100, 30);
            this.pictureBoxDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDog2.TabIndex = 4;
            this.pictureBoxDog2.TabStop = false;
            // 
            // pictureBoxDog4
            // 
            this.pictureBoxDog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog4.Image")));
            this.pictureBoxDog4.Location = new System.Drawing.Point(12, 157);
            this.pictureBoxDog4.Name = "pictureBoxDog4";
            this.pictureBoxDog4.Size = new System.Drawing.Size(100, 30);
            this.pictureBoxDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDog4.TabIndex = 5;
            this.pictureBoxDog4.TabStop = false;
            // 
            // Dog1Location
            // 
            this.Dog1Location.AutoSize = true;
            this.Dog1Location.Location = new System.Drawing.Point(12, 371);
            this.Dog1Location.Name = "Dog1Location";
            this.Dog1Location.Size = new System.Drawing.Size(35, 13);
            this.Dog1Location.TabIndex = 6;
            this.Dog1Location.Text = "label1";
            // 
            // Dog2Location
            // 
            this.Dog2Location.AutoSize = true;
            this.Dog2Location.Location = new System.Drawing.Point(172, 371);
            this.Dog2Location.Name = "Dog2Location";
            this.Dog2Location.Size = new System.Drawing.Size(35, 13);
            this.Dog2Location.TabIndex = 7;
            this.Dog2Location.Text = "label2";
            // 
            // Dog3Location
            // 
            this.Dog3Location.AutoSize = true;
            this.Dog3Location.Location = new System.Drawing.Point(332, 371);
            this.Dog3Location.Name = "Dog3Location";
            this.Dog3Location.Size = new System.Drawing.Size(35, 13);
            this.Dog3Location.TabIndex = 8;
            this.Dog3Location.Text = "label3";
            // 
            // Dog4Location
            // 
            this.Dog4Location.AutoSize = true;
            this.Dog4Location.Location = new System.Drawing.Point(492, 371);
            this.Dog4Location.Name = "Dog4Location";
            this.Dog4Location.Size = new System.Drawing.Size(35, 13);
            this.Dog4Location.TabIndex = 9;
            this.Dog4Location.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 397);
            this.Controls.Add(this.Dog4Location);
            this.Controls.Add(this.Dog3Location);
            this.Controls.Add(this.Dog2Location);
            this.Controls.Add(this.Dog1Location);
            this.Controls.Add(this.pictureBoxDog4);
            this.Controls.Add(this.pictureBoxDog2);
            this.Controls.Add(this.pictureBoxDog3);
            this.Controls.Add(this.pictureBoxDog1);
            this.Controls.Add(this.RaceTrackpictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Joelabel;
        private System.Windows.Forms.Label Boblabel;
        private System.Windows.Forms.Label Allabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label MinimunBetLabel;
        private System.Windows.Forms.RadioButton JoeradioButton;
        private System.Windows.Forms.RadioButton BobradioButton;
        private System.Windows.Forms.RadioButton AlradioButton;
        private System.Windows.Forms.Button StartTheGameButton;
        private System.Windows.Forms.PictureBox RaceTrackpictureBox;
        private System.Windows.Forms.PictureBox pictureBoxDog1;
        private System.Windows.Forms.PictureBox pictureBoxDog3;
        private System.Windows.Forms.PictureBox pictureBoxDog2;
        private System.Windows.Forms.PictureBox pictureBoxDog4;
        private System.Windows.Forms.Label Dog1Location;
        private System.Windows.Forms.Label Dog2Location;
        private System.Windows.Forms.Label Dog3Location;
        private System.Windows.Forms.Label Dog4Location;
    }
}

