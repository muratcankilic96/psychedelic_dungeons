namespace Psychedelic_Dungeons
{
    partial class MarketScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketScreen));
            this.MarketBox = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.marketList = new System.Windows.Forms.ListBox();
            this.cash = new System.Windows.Forms.Label();
            this.MarketBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarketBox
            // 
            this.MarketBox.Controls.Add(this.cash);
            this.MarketBox.Controls.Add(this.marketList);
            this.MarketBox.Controls.Add(this.date);
            this.MarketBox.Controls.Add(this.label12);
            this.MarketBox.Controls.Add(this.min);
            this.MarketBox.Controls.Add(this.label13);
            this.MarketBox.Controls.Add(this.hour);
            this.MarketBox.Controls.Add(this.label11);
            this.MarketBox.Controls.Add(this.buyButton);
            this.MarketBox.Controls.Add(this.label9);
            this.MarketBox.Controls.Add(this.label8);
            this.MarketBox.Controls.Add(this.button1);
            this.MarketBox.Controls.Add(this.mapButton);
            this.MarketBox.Location = new System.Drawing.Point(3, 12);
            this.MarketBox.Name = "MarketBox";
            this.MarketBox.Size = new System.Drawing.Size(378, 337);
            this.MarketBox.TabIndex = 0;
            this.MarketBox.TabStop = false;
            this.MarketBox.Enter += new System.EventHandler(this.MarketBox_Enter);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(285, 270);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(37, 26);
            this.date.TabIndex = 104;
            this.date.Text = "date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 26);
            this.label12.TabIndex = 103;
            this.label12.Text = "DATE";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(319, 296);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(32, 26);
            this.min.TabIndex = 102;
            this.min.Text = "mn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 26);
            this.label13.TabIndex = 101;
            this.label13.Text = ":";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(286, 296);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(25, 26);
            this.hour.TabIndex = 100;
            this.hour.Text = "hr";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 26);
            this.label11.TabIndex = 99;
            this.label11.Text = "TIME";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.Coral;
            this.buyButton.Location = new System.Drawing.Point(23, 281);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(123, 40);
            this.buyButton.TabIndex = 98;
            this.buyButton.Text = "BUY";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(230, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 97;
            this.label9.Text = "Prototype";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 26);
            this.label8.TabIndex = 96;
            this.label8.Text = "PSYCHEDELIC DUNGEONS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(337, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 95;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mapButton
            // 
            this.mapButton.BackColor = System.Drawing.Color.Coral;
            this.mapButton.Location = new System.Drawing.Point(246, 60);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(123, 40);
            this.mapButton.TabIndex = 94;
            this.mapButton.Text = "MAP";
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // marketList
            // 
            this.marketList.FormattingEnabled = true;
            this.marketList.ItemHeight = 26;
            this.marketList.Location = new System.Drawing.Point(26, 43);
            this.marketList.Name = "marketList";
            this.marketList.Size = new System.Drawing.Size(120, 212);
            this.marketList.TabIndex = 105;
            this.marketList.SelectedIndexChanged += new System.EventHandler(this.marketList_SelectedIndexChanged);
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(152, 43);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(58, 28);
            this.cash.TabIndex = 106;
            // 
            // MarketScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.MarketBox);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MarketScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarketScreen";
            this.Load += new System.EventHandler(this.MarketScreen_Load);
            this.MarketBox.ResumeLayout(false);
            this.MarketBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MarketBox;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox marketList;
        private System.Windows.Forms.Label cash;
    }
}