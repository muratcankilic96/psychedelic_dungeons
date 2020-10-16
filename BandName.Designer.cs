namespace Psychedelic_Dungeons
{
    partial class BandName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandName));
            this.BandBox = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.BandNameText = new System.Windows.Forms.TextBox();
            this.bandnamelabel = new System.Windows.Forms.Label();
            this.BandBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BandBox
            // 
            this.BandBox.Controls.Add(this.bandnamelabel);
            this.BandBox.Controls.Add(this.BandNameText);
            this.BandBox.Controls.Add(this.OKButton);
            this.BandBox.Location = new System.Drawing.Point(12, 12);
            this.BandBox.Name = "BandBox";
            this.BandBox.Size = new System.Drawing.Size(360, 137);
            this.BandBox.TabIndex = 0;
            this.BandBox.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.Coral;
            this.OKButton.Location = new System.Drawing.Point(129, 103);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 28);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BandNameText
            // 
            this.BandNameText.Location = new System.Drawing.Point(61, 72);
            this.BandNameText.Name = "BandNameText";
            this.BandNameText.Size = new System.Drawing.Size(206, 25);
            this.BandNameText.TabIndex = 1;
            // 
            // bandnamelabel
            // 
            this.bandnamelabel.AutoSize = true;
            this.bandnamelabel.Location = new System.Drawing.Point(69, 43);
            this.bandnamelabel.Name = "bandnamelabel";
            this.bandnamelabel.Size = new System.Drawing.Size(198, 26);
            this.bandnamelabel.TabIndex = 2;
            this.bandnamelabel.Text = "Please input your band\'s name:";
            // 
            // BandName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.BandBox);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "BandName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandName";
            this.BandBox.ResumeLayout(false);
            this.BandBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BandBox;
        private System.Windows.Forms.Label bandnamelabel;
        private System.Windows.Forms.TextBox BandNameText;
        private System.Windows.Forms.Button OKButton;
    }
}