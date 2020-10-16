namespace Psychedelic_Dungeons
{
    partial class Dealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dealer));
            this.DealerBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.talkingScript = new System.Windows.Forms.Timer(this.components);
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.choice3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DealerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DealerBox
            // 
            this.DealerBox.Controls.Add(this.choice3);
            this.DealerBox.Controls.Add(this.choice2);
            this.DealerBox.Controls.Add(this.choice1);
            this.DealerBox.Controls.Add(this.label1);
            this.DealerBox.Controls.Add(this.pictureBox1);
            this.DealerBox.Location = new System.Drawing.Point(12, 12);
            this.DealerBox.Name = "DealerBox";
            this.DealerBox.Size = new System.Drawing.Size(360, 337);
            this.DealerBox.TabIndex = 0;
            this.DealerBox.TabStop = false;
            this.DealerBox.Enter += new System.EventHandler(this.DealerBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "I HAVE VERY FINE GOODS\r\nFOR YOU, MAN!\r\nDON\'T YOU WANT\r\nIT?";
            // 
            // talkingScript
            // 
            this.talkingScript.Interval = 50;
            this.talkingScript.Tick += new System.EventHandler(this.talkingScript_Tick);
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.Color.Orange;
            this.choice1.Location = new System.Drawing.Point(37, 182);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(277, 38);
            this.choice1.TabIndex = 2;
            this.choice1.Text = "KINDLY REFUSE HIM";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.Color.Orange;
            this.choice2.Location = new System.Drawing.Point(37, 226);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(277, 38);
            this.choice2.TabIndex = 3;
            this.choice2.Text = "BUY LSD";
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // choice3
            // 
            this.choice3.BackColor = System.Drawing.Color.Orange;
            this.choice3.Location = new System.Drawing.Point(37, 270);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(277, 38);
            this.choice3.TabIndex = 4;
            this.choice3.Text = "RUN FOR YOUR LIFE";
            this.choice3.UseVisualStyleBackColor = false;
            this.choice3.Click += new System.EventHandler(this.choice3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Psychedelic_Dungeons.Properties.Resources.Dealer;
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.DealerBox);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Dealer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dealer";
            this.Load += new System.EventHandler(this.Dealer_Load);
            this.Shown += new System.EventHandler(this.Dealer_Shown);
            this.DealerBox.ResumeLayout(false);
            this.DealerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DealerBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer talkingScript;
        private System.Windows.Forms.Button choice3;
        private System.Windows.Forms.Button choice2;
        private System.Windows.Forms.Button choice1;
    }
}