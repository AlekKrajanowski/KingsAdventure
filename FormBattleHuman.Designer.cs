namespace KingsAdventure
{
    partial class FormBattleHuman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattleHuman));
            this.progressBarBattleHuman = new System.Windows.Forms.ProgressBar();
            this.timerBattleHuman = new System.Windows.Forms.Timer(this.components);
            this.buttonStartBattleHuman = new System.Windows.Forms.Button();
            this.pictureBoxBattleHuman = new System.Windows.Forms.PictureBox();
            this.labelBattleHumanProgress = new System.Windows.Forms.Label();
            this.labelHumanBattleMissonName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleHuman)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarBattleHuman
            // 
            this.progressBarBattleHuman.Location = new System.Drawing.Point(51, 405);
            this.progressBarBattleHuman.Name = "progressBarBattleHuman";
            this.progressBarBattleHuman.Size = new System.Drawing.Size(696, 23);
            this.progressBarBattleHuman.TabIndex = 0;
            // 
            // timerBattleHuman
            // 
            this.timerBattleHuman.Tick += new System.EventHandler(this.timerBattleHuman_Tick);
            // 
            // buttonStartBattleHuman
            // 
            this.buttonStartBattleHuman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartBattleHuman.BackgroundImage")));
            this.buttonStartBattleHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartBattleHuman.Location = new System.Drawing.Point(372, 379);
            this.buttonStartBattleHuman.Name = "buttonStartBattleHuman";
            this.buttonStartBattleHuman.Size = new System.Drawing.Size(75, 23);
            this.buttonStartBattleHuman.TabIndex = 1;
            this.buttonStartBattleHuman.UseVisualStyleBackColor = true;
            this.buttonStartBattleHuman.Click += new System.EventHandler(this.buttonStartBattleHuman_Click);
            // 
            // pictureBoxBattleHuman
            // 
            this.pictureBoxBattleHuman.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBattleHuman.Image")));
            this.pictureBoxBattleHuman.Location = new System.Drawing.Point(169, 118);
            this.pictureBoxBattleHuman.Name = "pictureBoxBattleHuman";
            this.pictureBoxBattleHuman.Size = new System.Drawing.Size(476, 202);
            this.pictureBoxBattleHuman.TabIndex = 4;
            this.pictureBoxBattleHuman.TabStop = false;
            // 
            // labelBattleHumanProgress
            // 
            this.labelBattleHumanProgress.AutoSize = true;
            this.labelBattleHumanProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelBattleHumanProgress.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBattleHumanProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBattleHumanProgress.Location = new System.Drawing.Point(393, 406);
            this.labelBattleHumanProgress.Name = "labelBattleHumanProgress";
            this.labelBattleHumanProgress.Size = new System.Drawing.Size(33, 22);
            this.labelBattleHumanProgress.TabIndex = 5;
            this.labelBattleHumanProgress.Text = "0%";
            // 
            // labelHumanBattleMissonName
            // 
            this.labelHumanBattleMissonName.AutoSize = true;
            this.labelHumanBattleMissonName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHumanBattleMissonName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHumanBattleMissonName.Location = new System.Drawing.Point(316, 60);
            this.labelHumanBattleMissonName.Name = "labelHumanBattleMissonName";
            this.labelHumanBattleMissonName.Size = new System.Drawing.Size(170, 28);
            this.labelHumanBattleMissonName.TabIndex = 6;
            this.labelHumanBattleMissonName.Text = "Królewski Szlak";
            // 
            // FormBattleHuman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHumanBattleMissonName);
            this.Controls.Add(this.labelBattleHumanProgress);
            this.Controls.Add(this.pictureBoxBattleHuman);
            this.Controls.Add(this.buttonStartBattleHuman);
            this.Controls.Add(this.progressBarBattleHuman);
            this.DoubleBuffered = true;
            this.Name = "FormBattleHuman";
            this.Text = "King Adventure";
            this.Load += new System.EventHandler(this.FormBattleHuman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleHuman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarBattleHuman;
        private System.Windows.Forms.Timer timerBattleHuman;
        private System.Windows.Forms.Button buttonStartBattleHuman;
        private System.Windows.Forms.PictureBox pictureBoxBattleHuman;
        private System.Windows.Forms.Label labelBattleHumanProgress;
        private System.Windows.Forms.Label labelHumanBattleMissonName;
    }
}