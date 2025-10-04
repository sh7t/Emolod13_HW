namespace ByNumb.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MainMenuImage = new System.Windows.Forms.PictureBox();
            this.playerCharacteristics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuImage
            // 
            this.MainMenuImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuImage.Image = global::ByNumb.Properties.Resources.MainMenu;
            this.MainMenuImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuImage.Location = new System.Drawing.Point(0, 0);
            this.MainMenuImage.Name = "MainMenuImage";
            this.MainMenuImage.Size = new System.Drawing.Size(724, 384);
            this.MainMenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenuImage.TabIndex = 1;
            this.MainMenuImage.TabStop = false;
            // 
            // playerCharacteristics
            // 
            this.playerCharacteristics.AutoSize = true;
            this.playerCharacteristics.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerCharacteristics.Location = new System.Drawing.Point(12, 9);
            this.playerCharacteristics.Name = "playerCharacteristics";
            this.playerCharacteristics.Size = new System.Drawing.Size(75, 14);
            this.playerCharacteristics.TabIndex = 2;
            this.playerCharacteristics.Text = "Characteristics";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 384);
            this.Controls.Add(this.playerCharacteristics);
            this.Controls.Add(this.MainMenuImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(740, 423);
            this.MinimumSize = new System.Drawing.Size(740, 423);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG: Reign of Pure Glory";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainMenuImage;
        private System.Windows.Forms.Label playerCharacteristics;
    }
}