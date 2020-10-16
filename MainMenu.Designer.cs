namespace Psychedelic_Dungeons
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.MainFrame = new System.Windows.Forms.GroupBox();
            this.credits = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.MainFrame.SuspendLayout();
            this.SuspendLayout();
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
            // MainFrame
            // 
            this.MainFrame.Controls.Add(this.credits);
            this.MainFrame.Controls.Add(this.newGame);
            this.MainFrame.Controls.Add(this.label2);
            this.MainFrame.Controls.Add(this.exit);
            this.MainFrame.Controls.Add(this.label1);
            this.MainFrame.Location = new System.Drawing.Point(12, 2);
            this.MainFrame.Name = "MainFrame";
            this.MainFrame.Size = new System.Drawing.Size(376, 386);
            this.MainFrame.TabIndex = 1;
            this.MainFrame.TabStop = false;
            this.MainFrame.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.Coral;
            this.credits.Location = new System.Drawing.Point(141, 195);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(113, 50);
            this.credits.TabIndex = 4;
            this.credits.Text = "CREDITS";
            this.credits.UseVisualStyleBackColor = false;
            this.credits.Click += new System.EventHandler(this.credits_Click);
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.Coral;
            this.newGame.Location = new System.Drawing.Point(141, 143);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(113, 50);
            this.newGame.TabIndex = 3;
            this.newGame.Text = "NEW GAME";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
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
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Coral;
            this.exit.Location = new System.Drawing.Point(141, 247);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 50);
            this.exit.TabIndex = 1;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.MainFrame);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psychedelic Dungeons";
            this.EnabledChanged += new System.EventHandler(this.MainMenu_EnabledChanged);
            this.MainFrame.ResumeLayout(false);
            this.MainFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox MainFrame;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button credits;
    }
}

