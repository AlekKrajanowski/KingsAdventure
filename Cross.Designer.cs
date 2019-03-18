namespace KingsAdventure
{
    partial class Cross
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cross));
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.progressBarClose = new System.Windows.Forms.ProgressBar();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(-5, -1);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(616, 330);
            this.pictureBoxCross.TabIndex = 0;
            this.pictureBoxCross.TabStop = false;
            // 
            // progressBarClose
            // 
            this.progressBarClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarClose.Location = new System.Drawing.Point(-5, 218);
            this.progressBarClose.Name = "progressBarClose";
            this.progressBarClose.Size = new System.Drawing.Size(538, 23);
            this.progressBarClose.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(223, 247);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(89, 30);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Cross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 287);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.progressBarClose);
            this.Controls.Add(this.pictureBoxCross);
            this.Name = "Cross";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KingAdventure";
            this.Load += new System.EventHandler(this.Cross_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.ProgressBar progressBarClose;
        private System.Windows.Forms.Button buttonClose;
    }
}