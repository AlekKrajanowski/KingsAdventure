namespace KingsAdventure
{
    partial class FormBattleElf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattleElf));
            this.pictureBoxBattleElf = new System.Windows.Forms.PictureBox();
            this.buttonStartBattleElf = new System.Windows.Forms.Button();
            this.progressBarBattleElf = new System.Windows.Forms.ProgressBar();
            this.timerBattleElf = new System.Windows.Forms.Timer(this.components);
            this.labelBattleElfProgress = new System.Windows.Forms.Label();
            this.labelElfBattleMissonName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleElf)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBattleElf
            // 
            this.pictureBoxBattleElf.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBattleElf.Image")));
            this.pictureBoxBattleElf.Location = new System.Drawing.Point(88, 50);
            this.pictureBoxBattleElf.Name = "pictureBoxBattleElf";
            this.pictureBoxBattleElf.Size = new System.Drawing.Size(601, 346);
            this.pictureBoxBattleElf.TabIndex = 3;
            this.pictureBoxBattleElf.TabStop = false;
            // 
            // buttonStartBattleElf
            // 
            this.buttonStartBattleElf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartBattleElf.BackgroundImage")));
            this.buttonStartBattleElf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartBattleElf.Location = new System.Drawing.Point(354, 373);
            this.buttonStartBattleElf.Name = "buttonStartBattleElf";
            this.buttonStartBattleElf.Size = new System.Drawing.Size(75, 23);
            this.buttonStartBattleElf.TabIndex = 4;
            this.buttonStartBattleElf.UseVisualStyleBackColor = true;
            this.buttonStartBattleElf.Click += new System.EventHandler(this.buttonStartBattleElf_Click);
            // 
            // progressBarBattleElf
            // 
            this.progressBarBattleElf.Location = new System.Drawing.Point(31, 402);
            this.progressBarBattleElf.Name = "progressBarBattleElf";
            this.progressBarBattleElf.Size = new System.Drawing.Size(741, 23);
            this.progressBarBattleElf.TabIndex = 5;
            // 
            // timerBattleElf
            // 
            this.timerBattleElf.Interval = 1;
            this.timerBattleElf.Tick += new System.EventHandler(this.timerBattleElf_Tick);
            // 
            // labelBattleElfProgress
            // 
            this.labelBattleElfProgress.AutoSize = true;
            this.labelBattleElfProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelBattleElfProgress.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBattleElfProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBattleElfProgress.Location = new System.Drawing.Point(375, 403);
            this.labelBattleElfProgress.Name = "labelBattleElfProgress";
            this.labelBattleElfProgress.Size = new System.Drawing.Size(33, 22);
            this.labelBattleElfProgress.TabIndex = 6;
            this.labelBattleElfProgress.Text = "0%";
            this.labelBattleElfProgress.Click += new System.EventHandler(this.labelBattleElfProgress_Click);
            // 
            // labelElfBattleMissonName
            // 
            this.labelElfBattleMissonName.AutoSize = true;
            this.labelElfBattleMissonName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelElfBattleMissonName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelElfBattleMissonName.Location = new System.Drawing.Point(293, 19);
            this.labelElfBattleMissonName.Name = "labelElfBattleMissonName";
            this.labelElfBattleMissonName.Size = new System.Drawing.Size(160, 28);
            this.labelElfBattleMissonName.TabIndex = 7;
            this.labelElfBattleMissonName.Text = "Polana Spokoju";
            // 
            // FormBattleElf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelElfBattleMissonName);
            this.Controls.Add(this.labelBattleElfProgress);
            this.Controls.Add(this.progressBarBattleElf);
            this.Controls.Add(this.buttonStartBattleElf);
            this.Controls.Add(this.pictureBoxBattleElf);
            this.Name = "FormBattleElf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "King Adventure";
            this.Load += new System.EventHandler(this.FormBattleElf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleElf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBattleElf;
        private System.Windows.Forms.Button buttonStartBattleElf;
        private System.Windows.Forms.ProgressBar progressBarBattleElf;
        private System.Windows.Forms.Timer timerBattleElf;
        private System.Windows.Forms.Label labelBattleElfProgress;
        private System.Windows.Forms.Label labelElfBattleMissonName;
    }
}