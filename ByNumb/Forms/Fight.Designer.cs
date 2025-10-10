namespace ByNumb.Forms
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.playerHealthPoinntsProgressBar = new System.Windows.Forms.ProgressBar();
            this.enemyHealthPoinntsProgressBar = new System.Windows.Forms.ProgressBar();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playerManaProgressBar = new System.Windows.Forms.ProgressBar();
            this.playerHealthPointsLabel = new System.Windows.Forms.Label();
            this.enemyHealthPointsLabel = new System.Windows.Forms.Label();
            this.playerManaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPictureBox.Image = global::ByNumb.Properties.Resources.Player;
            this.playerPictureBox.Location = new System.Drawing.Point(12, 11);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(318, 361);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyPictureBox.Image = global::ByNumb.Properties.Resources.Enemy;
            this.enemyPictureBox.Location = new System.Drawing.Point(417, 11);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(329, 394);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyPictureBox.TabIndex = 1;
            this.enemyPictureBox.TabStop = false;
            // 
            // playerHealthPoinntsProgressBar
            // 
            this.playerHealthPoinntsProgressBar.Location = new System.Drawing.Point(48, 340);
            this.playerHealthPoinntsProgressBar.Name = "playerHealthPoinntsProgressBar";
            this.playerHealthPoinntsProgressBar.Size = new System.Drawing.Size(251, 23);
            this.playerHealthPoinntsProgressBar.TabIndex = 2;
            // 
            // enemyHealthPoinntsProgressBar
            // 
            this.enemyHealthPoinntsProgressBar.Location = new System.Drawing.Point(444, 340);
            this.enemyHealthPoinntsProgressBar.Name = "enemyHealthPoinntsProgressBar";
            this.enemyHealthPoinntsProgressBar.Size = new System.Drawing.Size(251, 23);
            this.enemyHealthPoinntsProgressBar.TabIndex = 3;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameLabel.Location = new System.Drawing.Point(126, 11);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(91, 36);
            this.playerNameLabel.TabIndex = 4;
            this.playerNameLabel.Text = "player";
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.AutoSize = true;
            this.enemyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyNameLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enemyNameLabel.Location = new System.Drawing.Point(508, 26);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(95, 36);
            this.enemyNameLabel.TabIndex = 5;
            this.enemyNameLabel.Text = "enemy";
            this.enemyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // playerManaProgressBar
            // 
            this.playerManaProgressBar.Location = new System.Drawing.Point(79, 363);
            this.playerManaProgressBar.Name = "playerManaProgressBar";
            this.playerManaProgressBar.Size = new System.Drawing.Size(189, 13);
            this.playerManaProgressBar.TabIndex = 6;
            // 
            // playerHealthPointsLabel
            // 
            this.playerHealthPointsLabel.AutoSize = true;
            this.playerHealthPointsLabel.Location = new System.Drawing.Point(162, 345);
            this.playerHealthPointsLabel.Name = "playerHealthPointsLabel";
            this.playerHealthPointsLabel.Size = new System.Drawing.Size(24, 13);
            this.playerHealthPointsLabel.TabIndex = 7;
            this.playerHealthPointsLabel.Text = "0/0";
            // 
            // enemyHealthPointsLabel
            // 
            this.enemyHealthPointsLabel.AutoSize = true;
            this.enemyHealthPointsLabel.Location = new System.Drawing.Point(558, 345);
            this.enemyHealthPointsLabel.Name = "enemyHealthPointsLabel";
            this.enemyHealthPointsLabel.Size = new System.Drawing.Size(24, 13);
            this.enemyHealthPointsLabel.TabIndex = 8;
            this.enemyHealthPointsLabel.Text = "0/0";
            // 
            // playerManaLabel
            // 
            this.playerManaLabel.AutoSize = true;
            this.playerManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerManaLabel.Location = new System.Drawing.Point(166, 365);
            this.playerManaLabel.Name = "playerManaLabel";
            this.playerManaLabel.Size = new System.Drawing.Size(15, 9);
            this.playerManaLabel.TabIndex = 9;
            this.playerManaLabel.Text = "0/0";
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ByNumb.Properties.Resources.FightingScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(724, 384);
            this.Controls.Add(this.playerManaLabel);
            this.Controls.Add(this.enemyHealthPointsLabel);
            this.Controls.Add(this.playerHealthPointsLabel);
            this.Controls.Add(this.playerManaProgressBar);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.enemyHealthPoinntsProgressBar);
            this.Controls.Add(this.playerHealthPoinntsProgressBar);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(740, 423);
            this.MinimumSize = new System.Drawing.Size(740, 423);
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG: Reign of Pure Glory";
            this.Load += new System.EventHandler(this.Fight_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fight_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.ProgressBar playerHealthPoinntsProgressBar;
        private System.Windows.Forms.ProgressBar enemyHealthPoinntsProgressBar;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar playerManaProgressBar;
        private System.Windows.Forms.Label playerHealthPointsLabel;
        private System.Windows.Forms.Label enemyHealthPointsLabel;
        private System.Windows.Forms.Label playerManaLabel;
    }
}