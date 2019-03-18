namespace KingsAdventure
{
    partial class TopGamers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopGamers));
            this.dataGridViewTopGamers = new System.Windows.Forms.DataGridView();
            this.buttonShowTopGamers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopGamers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTopGamers
            // 
            this.dataGridViewTopGamers.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTopGamers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopGamers.Location = new System.Drawing.Point(186, 96);
            this.dataGridViewTopGamers.Name = "dataGridViewTopGamers";
            this.dataGridViewTopGamers.Size = new System.Drawing.Size(443, 227);
            this.dataGridViewTopGamers.TabIndex = 0;
            this.dataGridViewTopGamers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTopGamers_CellContentClick);
            // 
            // buttonShowTopGamers
            // 
            this.buttonShowTopGamers.BackColor = System.Drawing.Color.Black;
            this.buttonShowTopGamers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShowTopGamers.BackgroundImage")));
            this.buttonShowTopGamers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowTopGamers.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowTopGamers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShowTopGamers.Location = new System.Drawing.Point(340, 329);
            this.buttonShowTopGamers.Name = "buttonShowTopGamers";
            this.buttonShowTopGamers.Size = new System.Drawing.Size(175, 84);
            this.buttonShowTopGamers.TabIndex = 1;
            this.buttonShowTopGamers.Text = "SHOW";
            this.buttonShowTopGamers.UseVisualStyleBackColor = false;
            this.buttonShowTopGamers.Click += new System.EventHandler(this.buttonShowTopGamers_Click);
            // 
            // TopGamers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowTopGamers);
            this.Controls.Add(this.dataGridViewTopGamers);
            this.Name = "TopGamers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KingAdventure";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopGamers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTopGamers;
        private System.Windows.Forms.Button buttonShowTopGamers;
    }
}