namespace Psychedelic_Dungeons
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MainScreenBox = new System.Windows.Forms.GroupBox();
            this.cash = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.Label();
            this.hung = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.band = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.leftMenu = new System.Windows.Forms.GroupBox();
            this.specialty = new System.Windows.Forms.Label();
            this.returnbutton = new System.Windows.Forms.Button();
            this.soVal = new System.Windows.Forms.Label();
            this.peVal = new System.Windows.Forms.Label();
            this.coVal = new System.Windows.Forms.Label();
            this.jaVal = new System.Windows.Forms.Label();
            this.voVal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namesurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.characterImage = new System.Windows.Forms.Button();
            this.dateTimeCounter = new System.Windows.Forms.Timer(this.components);
            this.menuToggle = new System.Windows.Forms.Timer(this.components);
            this.mapButton = new System.Windows.Forms.Button();
            this.MainScreenBox.SuspendLayout();
            this.leftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainScreenBox
            // 
            this.MainScreenBox.Controls.Add(this.mapButton);
            this.MainScreenBox.Controls.Add(this.cash);
            this.MainScreenBox.Controls.Add(this.label15);
            this.MainScreenBox.Controls.Add(this.button2);
            this.MainScreenBox.Controls.Add(this.day);
            this.MainScreenBox.Controls.Add(this.hung);
            this.MainScreenBox.Controls.Add(this.label14);
            this.MainScreenBox.Controls.Add(this.date);
            this.MainScreenBox.Controls.Add(this.label12);
            this.MainScreenBox.Controls.Add(this.min);
            this.MainScreenBox.Controls.Add(this.label13);
            this.MainScreenBox.Controls.Add(this.hour);
            this.MainScreenBox.Controls.Add(this.label11);
            this.MainScreenBox.Controls.Add(this.band);
            this.MainScreenBox.Controls.Add(this.label10);
            this.MainScreenBox.Controls.Add(this.button1);
            this.MainScreenBox.Controls.Add(this.label9);
            this.MainScreenBox.Controls.Add(this.label8);
            this.MainScreenBox.Controls.Add(this.leftMenu);
            this.MainScreenBox.Controls.Add(this.characterImage);
            this.MainScreenBox.Location = new System.Drawing.Point(3, 5);
            this.MainScreenBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainScreenBox.Name = "MainScreenBox";
            this.MainScreenBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainScreenBox.Size = new System.Drawing.Size(493, 490);
            this.MainScreenBox.TabIndex = 0;
            this.MainScreenBox.TabStop = false;
            this.MainScreenBox.EnabledChanged += new System.EventHandler(this.MainScreenBox_EnabledChanged);
            this.MainScreenBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(222, 123);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(41, 26);
            this.cash.TabIndex = 92;
            this.cash.Text = "none";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 26);
            this.label15.TabIndex = 91;
            this.label15.Text = "CASH";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(362, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 40);
            this.button2.TabIndex = 90;
            this.button2.Text = "INVENTORY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(380, 21);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(54, 26);
            this.day.TabIndex = 89;
            this.day.Text = "DAY x";
            // 
            // hung
            // 
            this.hung.AutoSize = true;
            this.hung.Location = new System.Drawing.Point(246, 97);
            this.hung.Name = "hung";
            this.hung.Size = new System.Drawing.Size(41, 26);
            this.hung.TabIndex = 29;
            this.hung.Text = "none";
            this.hung.Click += new System.EventHandler(this.hung_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 26);
            this.label14.TabIndex = 28;
            this.label14.Text = "HUNGER";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(66, 433);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(37, 26);
            this.date.TabIndex = 27;
            this.date.Text = "date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "DATE";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(100, 459);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(32, 26);
            this.min.TabIndex = 25;
            this.min.Text = "mn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 26);
            this.label13.TabIndex = 24;
            this.label13.Text = ":";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(67, 459);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(25, 26);
            this.hour.TabIndex = 23;
            this.hour.Text = "hr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "TIME";
            // 
            // band
            // 
            this.band.AutoSize = true;
            this.band.Location = new System.Drawing.Point(222, 71);
            this.band.Name = "band";
            this.band.Size = new System.Drawing.Size(41, 26);
            this.band.TabIndex = 88;
            this.band.Text = "none";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "BAND";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(453, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Prototype";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "PSYCHEDELIC DUNGEONS";
            // 
            // leftMenu
            // 
            this.leftMenu.Controls.Add(this.specialty);
            this.leftMenu.Controls.Add(this.returnbutton);
            this.leftMenu.Controls.Add(this.soVal);
            this.leftMenu.Controls.Add(this.peVal);
            this.leftMenu.Controls.Add(this.coVal);
            this.leftMenu.Controls.Add(this.jaVal);
            this.leftMenu.Controls.Add(this.voVal);
            this.leftMenu.Controls.Add(this.label7);
            this.leftMenu.Controls.Add(this.label6);
            this.leftMenu.Controls.Add(this.label5);
            this.leftMenu.Controls.Add(this.label4);
            this.leftMenu.Controls.Add(this.label3);
            this.leftMenu.Controls.Add(this.age);
            this.leftMenu.Controls.Add(this.label2);
            this.leftMenu.Controls.Add(this.namesurname);
            this.leftMenu.Controls.Add(this.label1);
            this.leftMenu.Location = new System.Drawing.Point(-344, 49);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(258, 367);
            this.leftMenu.TabIndex = 56;
            this.leftMenu.TabStop = false;
            this.leftMenu.Text = "CHARACTER INFO";
            // 
            // specialty
            // 
            this.specialty.AutoSize = true;
            this.specialty.Location = new System.Drawing.Point(8, 94);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(71, 26);
            this.specialty.TabIndex = 46;
            this.specialty.Text = "specialty_";
            // 
            // returnbutton
            // 
            this.returnbutton.BackColor = System.Drawing.Color.Coral;
            this.returnbutton.Location = new System.Drawing.Point(147, 329);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(105, 32);
            this.returnbutton.TabIndex = 45;
            this.returnbutton.Text = "RETURN";
            this.returnbutton.UseVisualStyleBackColor = false;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // soVal
            // 
            this.soVal.AutoSize = true;
            this.soVal.Location = new System.Drawing.Point(141, 237);
            this.soVal.Name = "soVal";
            this.soVal.Size = new System.Drawing.Size(32, 26);
            this.soVal.TabIndex = 44;
            this.soVal.Text = "so_";
            // 
            // peVal
            // 
            this.peVal.AutoSize = true;
            this.peVal.Location = new System.Drawing.Point(142, 207);
            this.peVal.Name = "peVal";
            this.peVal.Size = new System.Drawing.Size(34, 26);
            this.peVal.TabIndex = 43;
            this.peVal.Text = "pe_";
            // 
            // coVal
            // 
            this.coVal.AutoSize = true;
            this.coVal.Location = new System.Drawing.Point(142, 181);
            this.coVal.Name = "coVal";
            this.coVal.Size = new System.Drawing.Size(33, 26);
            this.coVal.TabIndex = 42;
            this.coVal.Text = "co_";
            // 
            // jaVal
            // 
            this.jaVal.AutoSize = true;
            this.jaVal.Location = new System.Drawing.Point(142, 155);
            this.jaVal.Name = "jaVal";
            this.jaVal.Size = new System.Drawing.Size(30, 26);
            this.jaVal.TabIndex = 41;
            this.jaVal.Text = "ja_";
            // 
            // voVal
            // 
            this.voVal.AutoSize = true;
            this.voVal.Location = new System.Drawing.Point(142, 133);
            this.voVal.Name = "voVal";
            this.voVal.Size = new System.Drawing.Size(33, 26);
            this.voVal.TabIndex = 40;
            this.voVal.Text = "vo_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "SOCIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "PERFORMANCE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "COMPOSITION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "JAMMING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "VOCALS";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(72, 62);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(39, 26);
            this.age.TabIndex = 34;
            this.age.Text = "age_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "AGE";
            // 
            // namesurname
            // 
            this.namesurname.AutoSize = true;
            this.namesurname.Location = new System.Drawing.Point(72, 36);
            this.namesurname.Name = "namesurname";
            this.namesurname.Size = new System.Drawing.Size(52, 26);
            this.namesurname.TabIndex = 32;
            this.namesurname.Text = "name_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // characterImage
            // 
            this.characterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.characterImage.Location = new System.Drawing.Point(60, 71);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(62, 88);
            this.characterImage.TabIndex = 0;
            this.characterImage.UseVisualStyleBackColor = true;
            this.characterImage.Click += new System.EventHandler(this.characterImage_Click);
            // 
            // dateTimeCounter
            // 
            this.dateTimeCounter.Enabled = true;
            this.dateTimeCounter.Interval = 333;
            this.dateTimeCounter.Tick += new System.EventHandler(this.dateTimeCounter_Tick);
            // 
            // menuToggle
            // 
            this.menuToggle.Interval = 10;
            this.menuToggle.Tick += new System.EventHandler(this.menuToggle_Tick);
            // 
            // mapButton
            // 
            this.mapButton.BackColor = System.Drawing.Color.Coral;
            this.mapButton.Location = new System.Drawing.Point(362, 71);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(123, 40);
            this.mapButton.TabIndex = 93;
            this.mapButton.Text = "MAP";
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.MainScreenBox);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.MainScreenBox.ResumeLayout(false);
            this.MainScreenBox.PerformLayout();
            this.leftMenu.ResumeLayout(false);
            this.leftMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainScreenBox;
        private System.Windows.Forms.Button characterImage;
        private System.Windows.Forms.GroupBox leftMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namesurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Label soVal;
        private System.Windows.Forms.Label peVal;
        private System.Windows.Forms.Label coVal;
        private System.Windows.Forms.Label jaVal;
        private System.Windows.Forms.Label voVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label band;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer dateTimeCounter;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label hung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label specialty;
        private System.Windows.Forms.Timer menuToggle;
        private System.Windows.Forms.Button mapButton;
    }
}