namespace Psychedelic_Dungeons
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.inventoryBox = new System.Windows.Forms.GroupBox();
            this.use = new System.Windows.Forms.Button();
            this.listing = new System.Windows.Forms.ListBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.inventoryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryBox
            // 
            this.inventoryBox.Controls.Add(this.use);
            this.inventoryBox.Controls.Add(this.listing);
            this.inventoryBox.Controls.Add(this.returnButton);
            this.inventoryBox.Location = new System.Drawing.Point(12, 12);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(376, 376);
            this.inventoryBox.TabIndex = 0;
            this.inventoryBox.TabStop = false;
            this.inventoryBox.Enter += new System.EventHandler(this.inventoryBox_Enter);
            // 
            // use
            // 
            this.use.BackColor = System.Drawing.Color.Coral;
            this.use.Location = new System.Drawing.Point(220, 24);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(89, 34);
            this.use.TabIndex = 2;
            this.use.Text = "USE";
            this.use.UseVisualStyleBackColor = false;
            this.use.Click += new System.EventHandler(this.use_Click);
            // 
            // listing
            // 
            this.listing.FormattingEnabled = true;
            this.listing.ItemHeight = 26;
            this.listing.Location = new System.Drawing.Point(6, 24);
            this.listing.Name = "listing";
            this.listing.Size = new System.Drawing.Size(165, 290);
            this.listing.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Coral;
            this.returnButton.Location = new System.Drawing.Point(49, 320);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(89, 34);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "RETURN";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.inventoryBox);
            this.Font = new System.Drawing.Font("Adobe Caslon Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.inventoryBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inventoryBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button use;
        private System.Windows.Forms.ListBox listing;
    }
}