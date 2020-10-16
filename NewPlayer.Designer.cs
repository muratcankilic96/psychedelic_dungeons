namespace Psychedelic_Dungeons
{
    partial class NewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.MainFrame = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.drums = new System.Windows.Forms.RadioButton();
            this.keyboards = new System.Windows.Forms.RadioButton();
            this.bass = new System.Windows.Forms.RadioButton();
            this.guitar = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.Button();
            this.stats = new System.Windows.Forms.GroupBox();
            this.soRight = new System.Windows.Forms.Button();
            this.soLeft = new System.Windows.Forms.Button();
            this.peRight = new System.Windows.Forms.Button();
            this.peLeft = new System.Windows.Forms.Button();
            this.coRight = new System.Windows.Forms.Button();
            this.coLeft = new System.Windows.Forms.Button();
            this.jaRight = new System.Windows.Forms.Button();
            this.jaLeft = new System.Windows.Forms.Button();
            this.voRight = new System.Windows.Forms.Button();
            this.voLeft = new System.Windows.Forms.Button();
            this.so = new System.Windows.Forms.Label();
            this.pe = new System.Windows.Forms.Label();
            this.co = new System.Windows.Forms.Label();
            this.ja = new System.Windows.Forms.Label();
            this.vo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.sprite = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainFrame.SuspendLayout();
            this.stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFrame
            // 
            this.MainFrame.Controls.Add(this.button1);
            this.MainFrame.Controls.Add(this.drums);
            this.MainFrame.Controls.Add(this.keyboards);
            this.MainFrame.Controls.Add(this.bass);
            this.MainFrame.Controls.Add(this.guitar);
            this.MainFrame.Controls.Add(this.ok);
            this.MainFrame.Controls.Add(this.stats);
            this.MainFrame.Controls.Add(this.label5);
            this.MainFrame.Controls.Add(this.age);
            this.MainFrame.Controls.Add(this.label4);
            this.MainFrame.Controls.Add(this.label3);
            this.MainFrame.Controls.Add(this.surnameText);
            this.MainFrame.Controls.Add(this.nameText);
            this.MainFrame.Controls.Add(this.right);
            this.MainFrame.Controls.Add(this.left);
            this.MainFrame.Controls.Add(this.sprite);
            this.MainFrame.Controls.Add(this.label2);
            this.MainFrame.Controls.Add(this.label1);
            this.MainFrame.Location = new System.Drawing.Point(12, 2);
            this.MainFrame.Name = "MainFrame";
            this.MainFrame.Size = new System.Drawing.Size(376, 386);
            this.MainFrame.TabIndex = 2;
            this.MainFrame.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(338, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drums
            // 
            this.drums.AutoSize = true;
            this.drums.Location = new System.Drawing.Point(6, 276);
            this.drums.Name = "drums";
            this.drums.Size = new System.Drawing.Size(72, 30);
            this.drums.TabIndex = 17;
            this.drums.Text = "Drums";
            this.drums.UseVisualStyleBackColor = true;
            // 
            // keyboards
            // 
            this.keyboards.AutoSize = true;
            this.keyboards.Location = new System.Drawing.Point(6, 251);
            this.keyboards.Name = "keyboards";
            this.keyboards.Size = new System.Drawing.Size(93, 30);
            this.keyboards.TabIndex = 16;
            this.keyboards.Text = "Keyboards";
            this.keyboards.UseVisualStyleBackColor = true;
            // 
            // bass
            // 
            this.bass.AutoSize = true;
            this.bass.Location = new System.Drawing.Point(6, 229);
            this.bass.Name = "bass";
            this.bass.Size = new System.Drawing.Size(56, 30);
            this.bass.TabIndex = 15;
            this.bass.Text = "Bass";
            this.bass.UseVisualStyleBackColor = true;
            // 
            // guitar
            // 
            this.guitar.AutoSize = true;
            this.guitar.Checked = true;
            this.guitar.Location = new System.Drawing.Point(6, 206);
            this.guitar.Name = "guitar";
            this.guitar.Size = new System.Drawing.Size(70, 30);
            this.guitar.TabIndex = 14;
            this.guitar.TabStop = true;
            this.guitar.Text = "Guitar";
            this.guitar.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Coral;
            this.ok.Location = new System.Drawing.Point(6, 330);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(113, 50);
            this.ok.TabIndex = 13;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // stats
            // 
            this.stats.Controls.Add(this.soRight);
            this.stats.Controls.Add(this.soLeft);
            this.stats.Controls.Add(this.peRight);
            this.stats.Controls.Add(this.peLeft);
            this.stats.Controls.Add(this.coRight);
            this.stats.Controls.Add(this.coLeft);
            this.stats.Controls.Add(this.jaRight);
            this.stats.Controls.Add(this.jaLeft);
            this.stats.Controls.Add(this.voRight);
            this.stats.Controls.Add(this.voLeft);
            this.stats.Controls.Add(this.so);
            this.stats.Controls.Add(this.pe);
            this.stats.Controls.Add(this.co);
            this.stats.Controls.Add(this.ja);
            this.stats.Controls.Add(this.vo);
            this.stats.Controls.Add(this.label10);
            this.stats.Controls.Add(this.label9);
            this.stats.Controls.Add(this.label8);
            this.stats.Controls.Add(this.label7);
            this.stats.Controls.Add(this.label6);
            this.stats.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats.Location = new System.Drawing.Point(122, 191);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(248, 189);
            this.stats.TabIndex = 12;
            this.stats.TabStop = false;
            this.stats.Text = "STATS (8)";
            // 
            // soRight
            // 
            this.soRight.Location = new System.Drawing.Point(172, 134);
            this.soRight.Name = "soRight";
            this.soRight.Size = new System.Drawing.Size(28, 26);
            this.soRight.TabIndex = 32;
            this.soRight.Text = ">";
            this.soRight.UseVisualStyleBackColor = true;
            this.soRight.Click += new System.EventHandler(this.soRight_Click);
            // 
            // soLeft
            // 
            this.soLeft.Location = new System.Drawing.Point(138, 134);
            this.soLeft.Name = "soLeft";
            this.soLeft.Size = new System.Drawing.Size(28, 26);
            this.soLeft.TabIndex = 31;
            this.soLeft.Text = "<";
            this.soLeft.UseVisualStyleBackColor = true;
            this.soLeft.Click += new System.EventHandler(this.soLeft_Click);
            // 
            // peRight
            // 
            this.peRight.Location = new System.Drawing.Point(172, 102);
            this.peRight.Name = "peRight";
            this.peRight.Size = new System.Drawing.Size(28, 26);
            this.peRight.TabIndex = 30;
            this.peRight.Text = ">";
            this.peRight.UseVisualStyleBackColor = true;
            this.peRight.Click += new System.EventHandler(this.peRight_Click);
            // 
            // peLeft
            // 
            this.peLeft.Location = new System.Drawing.Point(138, 102);
            this.peLeft.Name = "peLeft";
            this.peLeft.Size = new System.Drawing.Size(28, 26);
            this.peLeft.TabIndex = 29;
            this.peLeft.Text = "<";
            this.peLeft.UseVisualStyleBackColor = true;
            this.peLeft.Click += new System.EventHandler(this.peLeft_Click);
            // 
            // coRight
            // 
            this.coRight.Location = new System.Drawing.Point(172, 72);
            this.coRight.Name = "coRight";
            this.coRight.Size = new System.Drawing.Size(28, 26);
            this.coRight.TabIndex = 28;
            this.coRight.Text = ">";
            this.coRight.UseVisualStyleBackColor = true;
            this.coRight.Click += new System.EventHandler(this.coRight_Click);
            // 
            // coLeft
            // 
            this.coLeft.Location = new System.Drawing.Point(138, 72);
            this.coLeft.Name = "coLeft";
            this.coLeft.Size = new System.Drawing.Size(28, 26);
            this.coLeft.TabIndex = 27;
            this.coLeft.Text = "<";
            this.coLeft.UseVisualStyleBackColor = true;
            this.coLeft.Click += new System.EventHandler(this.coLeft_Click);
            // 
            // jaRight
            // 
            this.jaRight.Location = new System.Drawing.Point(172, 42);
            this.jaRight.Name = "jaRight";
            this.jaRight.Size = new System.Drawing.Size(28, 26);
            this.jaRight.TabIndex = 26;
            this.jaRight.Text = ">";
            this.jaRight.UseVisualStyleBackColor = true;
            this.jaRight.Click += new System.EventHandler(this.jaRight_Click);
            // 
            // jaLeft
            // 
            this.jaLeft.Location = new System.Drawing.Point(138, 42);
            this.jaLeft.Name = "jaLeft";
            this.jaLeft.Size = new System.Drawing.Size(28, 26);
            this.jaLeft.TabIndex = 25;
            this.jaLeft.Text = "<";
            this.jaLeft.UseVisualStyleBackColor = true;
            this.jaLeft.Click += new System.EventHandler(this.jaLeft_Click);
            // 
            // voRight
            // 
            this.voRight.Location = new System.Drawing.Point(172, 15);
            this.voRight.Name = "voRight";
            this.voRight.Size = new System.Drawing.Size(28, 26);
            this.voRight.TabIndex = 24;
            this.voRight.Text = ">";
            this.voRight.UseVisualStyleBackColor = true;
            this.voRight.Click += new System.EventHandler(this.voRight_Click);
            // 
            // voLeft
            // 
            this.voLeft.Location = new System.Drawing.Point(138, 15);
            this.voLeft.Name = "voLeft";
            this.voLeft.Size = new System.Drawing.Size(28, 26);
            this.voLeft.TabIndex = 23;
            this.voLeft.Text = "<";
            this.voLeft.UseVisualStyleBackColor = true;
            this.voLeft.Click += new System.EventHandler(this.voLeft_Click);
            // 
            // so
            // 
            this.so.AutoSize = true;
            this.so.Location = new System.Drawing.Point(112, 139);
            this.so.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.so.Name = "so";
            this.so.Size = new System.Drawing.Size(17, 17);
            this.so.TabIndex = 22;
            this.so.Text = "5";
            this.so.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pe
            // 
            this.pe.AutoSize = true;
            this.pe.Location = new System.Drawing.Point(112, 107);
            this.pe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pe.Name = "pe";
            this.pe.Size = new System.Drawing.Size(17, 17);
            this.pe.TabIndex = 21;
            this.pe.Text = "5";
            this.pe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // co
            // 
            this.co.AutoSize = true;
            this.co.Location = new System.Drawing.Point(112, 77);
            this.co.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(17, 17);
            this.co.TabIndex = 20;
            this.co.Text = "5";
            this.co.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ja
            // 
            this.ja.AutoSize = true;
            this.ja.Location = new System.Drawing.Point(112, 47);
            this.ja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ja.Name = "ja";
            this.ja.Size = new System.Drawing.Size(17, 17);
            this.ja.TabIndex = 19;
            this.ja.Text = "5";
            this.ja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vo
            // 
            this.vo.AutoSize = true;
            this.vo.Location = new System.Drawing.Point(112, 20);
            this.vo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vo.Name = "vo";
            this.vo.Size = new System.Drawing.Size(17, 17);
            this.vo.TabIndex = 18;
            this.vo.Text = "5";
            this.vo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Social";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Performance";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Composition";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jamming";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vocals";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(160, 160);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(45, 25);
            this.age.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(160, 129);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(136, 25);
            this.surnameText.TabIndex = 7;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(160, 98);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(136, 25);
            this.nameText.TabIndex = 6;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(40, 156);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(28, 26);
            this.right.TabIndex = 5;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Enabled = false;
            this.left.Location = new System.Drawing.Point(6, 156);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(28, 26);
            this.left.TabIndex = 4;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // sprite
            // 
            this.sprite.Image = global::Psychedelic_Dungeons.Properties.Resources._1;
            this.sprite.Location = new System.Drawing.Point(6, 62);
            this.sprite.Name = "sprite";
            this.sprite.Size = new System.Drawing.Size(62, 88);
            this.sprite.TabIndex = 3;
            this.sprite.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prototype";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PSYCHEDELIC DUNGEONS";
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.MainFrame);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "NewPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPlayer";
            this.Load += new System.EventHandler(this.NewPlayer_Load);
            this.MainFrame.ResumeLayout(false);
            this.MainFrame.PerformLayout();
            this.stats.ResumeLayout(false);
            this.stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.PictureBox sprite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox stats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label so;
        private System.Windows.Forms.Label pe;
        private System.Windows.Forms.Label co;
        private System.Windows.Forms.Label ja;
        private System.Windows.Forms.Label vo;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button soRight;
        private System.Windows.Forms.Button soLeft;
        private System.Windows.Forms.Button peRight;
        private System.Windows.Forms.Button peLeft;
        private System.Windows.Forms.Button coRight;
        private System.Windows.Forms.Button coLeft;
        private System.Windows.Forms.Button jaRight;
        private System.Windows.Forms.Button jaLeft;
        private System.Windows.Forms.Button voRight;
        private System.Windows.Forms.Button voLeft;
        private System.Windows.Forms.RadioButton drums;
        private System.Windows.Forms.RadioButton keyboards;
        private System.Windows.Forms.RadioButton bass;
        private System.Windows.Forms.RadioButton guitar;
        private System.Windows.Forms.Button button1;
    }
}