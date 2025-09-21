namespace ByNumb
{
    partial class Form1
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
            this.gateInFate_Title = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // gateInFate_Title
            // 
            this.gateInFate_Title.AutoSize = true;
            this.gateInFate_Title.Font = new System.Drawing.Font("Segoe Print", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gateInFate_Title.LinkColor = System.Drawing.Color.Black;
            this.gateInFate_Title.Location = new System.Drawing.Point(141, 100);
            this.gateInFate_Title.Name = "gateInFate_Title";
            this.gateInFate_Title.Size = new System.Drawing.Size(672, 170);
            this.gateInFate_Title.TabIndex = 1;
            this.gateInFate_Title.TabStop = true;
            this.gateInFate_Title.Text = "Gate in Fate";
            this.gateInFate_Title.VisitedLinkColor = System.Drawing.Color.Black;
            this.gateInFate_Title.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gateInFate_Title_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.gateInFate_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Gate in Fate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel gateInFate_Title;
    }
}

