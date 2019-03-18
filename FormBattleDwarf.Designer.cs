namespace KingsAdventure
{
    partial class FormBattleDwarf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBattleDwarf));
            this.timerBattleDwarf = new System.Windows.Forms.Timer(this.components);
            this.progressBarBattleDwarf = new System.Windows.Forms.ProgressBar();
            this.buttonStartBattleDwarf = new System.Windows.Forms.Button();
            this.pictureBoxBattleDwarf = new System.Windows.Forms.PictureBox();
            this.labelBattleDwarfProgress = new System.Windows.Forms.Label();
            this.labelDwarfBattleMissonName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleDwarf)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBattleDwarf
            // 
            this.timerBattleDwarf.Interval = 1000;
            this.timerBattleDwarf.Tick += new System.EventHandler(this.timerBattleDwarf_Tick);
            // 
            // progressBarBattleDwarf
            // 
            this.progressBarBattleDwarf.Location = new System.Drawing.Point(51, 408);
            this.progressBarBattleDwarf.Name = "progressBarBattleDwarf";
            this.progressBarBattleDwarf.Size = new System.Drawing.Size(709, 23);
            this.progressBarBattleDwarf.TabIndex = 0;
            // 
            // buttonStartBattleDwarf
            // 
            this.buttonStartBattleDwarf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartBattleDwarf.BackgroundImage")));
            this.buttonStartBattleDwarf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartBattleDwarf.Location = new System.Drawing.Point(371, 380);
            this.buttonStartBattleDwarf.Name = "buttonStartBattleDwarf";
            this.buttonStartBattleDwarf.Size = new System.Drawing.Size(75, 23);
            this.buttonStartBattleDwarf.TabIndex = 1;
            this.buttonStartBattleDwarf.UseVisualStyleBackColor = true;
            this.buttonStartBattleDwarf.Click += new System.EventHandler(this.buttonStartBattleDwarf_Click);
            // 
            // pictureBoxBattleDwarf
            // 
            this.pictureBoxBattleDwarf.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBattleDwarf.Image")));
            this.pictureBoxBattleDwarf.Location = new System.Drawing.Point(102, 50);
            this.pictureBoxBattleDwarf.Name = "pictureBoxBattleDwarf";
            this.pictureBoxBattleDwarf.Size = new System.Drawing.Size(601, 324);
            this.pictureBoxBattleDwarf.TabIndex = 2;
            this.pictureBoxBattleDwarf.TabStop = false;
            // 
            // labelBattleDwarfProgress
            // 
            this.labelBattleDwarfProgress.AutoSize = true;
            this.labelBattleDwarfProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelBattleDwarfProgress.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBattleDwarfProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBattleDwarfProgress.Location = new System.Drawing.Point(392, 409);
            this.labelBattleDwarfProgress.Name = "labelBattleDwarfProgress";
            this.labelBattleDwarfProgress.Size = new System.Drawing.Size(33, 22);
            this.labelBattleDwarfProgress.TabIndex = 3;
            this.labelBattleDwarfProgress.Text = "0%";
            // 
            // labelDwarfBattleMissonName
            // 
            this.labelDwarfBattleMissonName.AutoSize = true;
            this.labelDwarfBattleMissonName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDwarfBattleMissonName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDwarfBattleMissonName.Location = new System.Drawing.Point(311, 9);
            this.labelDwarfBattleMissonName.Name = "labelDwarfBattleMissonName";
            this.labelDwarfBattleMissonName.Size = new System.Drawing.Size(181, 28);
            this.labelDwarfBattleMissonName.TabIndex = 4;
            this.labelDwarfBattleMissonName.Text = "Wzgórza Hotamu";
            // 
            // FormBattleDwarf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDwarfBattleMissonName);
            this.Controls.Add(this.labelBattleDwarfProgress);
            this.Controls.Add(this.pictureBoxBattleDwarf);
            this.Controls.Add(this.buttonStartBattleDwarf);
            this.Controls.Add(this.progressBarBattleDwarf);
            this.DoubleBuffered = true;
            this.Name = "FormBattleDwarf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "King Adventure";
            this.Load += new System.EventHandler(this.FormBattleDwarf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleDwarf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerBattleDwarf;
        private System.Windows.Forms.ProgressBar progressBarBattleDwarf;
        private System.Windows.Forms.Button buttonStartBattleDwarf;
        private System.Windows.Forms.PictureBox pictureBoxBattleDwarf;
        private System.Windows.Forms.Label labelBattleDwarfProgress;
        private System.Windows.Forms.Label labelDwarfBattleMissonName;
    }
}