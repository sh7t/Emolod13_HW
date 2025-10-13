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
            this.turnButton = new System.Windows.Forms.Button();
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.FakeButtonImage = new System.Windows.Forms.PictureBox();
            this.playerCharacteristics = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakeButtonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // turnButton
            // 
            this.turnButton.Location = new System.Drawing.Point(556, 322);
            this.turnButton.Name = "turnButton";
            this.turnButton.Size = new System.Drawing.Size(156, 50);
            this.turnButton.TabIndex = 3;
            this.turnButton.Text = "Go further!";
            this.turnButton.UseVisualStyleBackColor = true;
            this.turnButton.Click += new System.EventHandler(this.turnButton_Click);
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.Image = global::ByNumb.Properties.Resources.Player;
            this.playerImage.Location = new System.Drawing.Point(164, 2);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(365, 378);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 4;
            this.playerImage.TabStop = false;
            // 
            // FakeButtonImage
            // 
            this.FakeButtonImage.Image = global::ByNumb.Properties.Resources.FakeButton;
            this.FakeButtonImage.Location = new System.Drawing.Point(556, 322);
            this.FakeButtonImage.Name = "FakeButtonImage";
            this.FakeButtonImage.Size = new System.Drawing.Size(156, 50);
            this.FakeButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FakeButtonImage.TabIndex = 5;
            this.FakeButtonImage.TabStop = false;
            this.FakeButtonImage.Visible = false;
            // 
            // playerCharacteristics
            // 
            this.playerCharacteristics.AutoSize = true;
            this.playerCharacteristics.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerCharacteristics.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerCharacteristics.Location = new System.Drawing.Point(12, 9);
            this.playerCharacteristics.Name = "playerCharacteristics";
            this.playerCharacteristics.Size = new System.Drawing.Size(152, 14);
            this.playerCharacteristics.TabIndex = 2;
            this.playerCharacteristics.Text = "playerCharacteristics________";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(602, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 37);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ByNumb.Properties.Resources.MainMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(724, 384);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.playerCharacteristics);
            this.Controls.Add(this.turnButton);
            this.Controls.Add(this.FakeButtonImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(740, 423);
            this.MinimumSize = new System.Drawing.Size(740, 423);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG: Reign of Pure Glory";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FakeButtonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button turnButton;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox FakeButtonImage;
        private System.Windows.Forms.Label playerCharacteristics;
        private System.Windows.Forms.Button saveButton;
    }
}