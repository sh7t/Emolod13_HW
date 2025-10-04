namespace ByNumb.Forms
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.MainMenuImage = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
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
            this.MainMenuImage.TabIndex = 0;
            this.MainMenuImage.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Impact", 8.25F);
            this.playButton.Location = new System.Drawing.Point(245, 269);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(250, 50);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 384);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.MainMenuImage);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(740, 423);
            this.MinimumSize = new System.Drawing.Size(740, 423);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG: Reign of Pure Glory";
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainMenuImage;
        private System.Windows.Forms.Button playButton;
    }
}