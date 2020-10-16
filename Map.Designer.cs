namespace Psychedelic_Dungeons
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.ReturnFrame = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MapFrame = new System.Windows.Forms.GroupBox();
            this.marketLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.ReturnFrame.SuspendLayout();
            this.MapFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnFrame
            // 
            this.ReturnFrame.BackColor = System.Drawing.Color.Transparent;
            this.ReturnFrame.Controls.Add(this.button1);
            this.ReturnFrame.Location = new System.Drawing.Point(12, 318);
            this.ReturnFrame.Name = "ReturnFrame";
            this.ReturnFrame.Size = new System.Drawing.Size(360, 43);
            this.ReturnFrame.TabIndex = 1;
            this.ReturnFrame.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(140, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "RETURN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapFrame
            // 
            this.MapFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MapFrame.BackgroundImage = global::Psychedelic_Dungeons.Properties.Resources.OnlyMap;
            this.MapFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MapFrame.Controls.Add(this.marketLabel);
            this.MapFrame.Controls.Add(this.homeLabel);
            this.MapFrame.Location = new System.Drawing.Point(12, -6);
            this.MapFrame.Name = "MapFrame";
            this.MapFrame.Size = new System.Drawing.Size(360, 318);
            this.MapFrame.TabIndex = 0;
            this.MapFrame.TabStop = false;
            // 
            // marketLabel
            // 
            this.marketLabel.BackColor = System.Drawing.Color.Transparent;
            this.marketLabel.Location = new System.Drawing.Point(297, 15);
            this.marketLabel.Name = "marketLabel";
            this.marketLabel.Size = new System.Drawing.Size(63, 123);
            this.marketLabel.TabIndex = 1;
            this.marketLabel.Click += new System.EventHandler(this.marketLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeLabel.Location = new System.Drawing.Point(255, 203);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(99, 93);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ReturnFrame);
            this.Controls.Add(this.MapFrame);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ReturnFrame.ResumeLayout(false);
            this.MapFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MapFrame;
        private System.Windows.Forms.GroupBox ReturnFrame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label marketLabel;
    }
}