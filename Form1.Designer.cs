namespace KingsAdventure
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.buttonTopGamers = new System.Windows.Forms.Button();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.buttonGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(511, 214);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(152, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonStartGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartGame.BackgroundImage")));
            this.buttonStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartGame.Location = new System.Drawing.Point(544, 240);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(94, 24);
            this.buttonStartGame.TabIndex = 2;
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInstruction.Location = new System.Drawing.Point(679, 405);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(93, 33);
            this.buttonInstruction.TabIndex = 3;
            this.buttonInstruction.Text = "Instruction";
            this.buttonInstruction.UseVisualStyleBackColor = true;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // buttonTopGamers
            // 
            this.buttonTopGamers.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTopGamers.Location = new System.Drawing.Point(679, 375);
            this.buttonTopGamers.Name = "buttonTopGamers";
            this.buttonTopGamers.Size = new System.Drawing.Size(93, 34);
            this.buttonTopGamers.TabIndex = 4;
            this.buttonTopGamers.Text = "Top Gamers";
            this.buttonTopGamers.UseVisualStyleBackColor = true;
            this.buttonTopGamers.Click += new System.EventHandler(this.buttonTopGamers_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStart.BackgroundImage")));
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStart.Location = new System.Drawing.Point(65, 101);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(241, 248);
            this.pictureBoxStart.TabIndex = 5;
            this.pictureBoxStart.TabStop = false;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.Transparent;
            this.buttonGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGo.BackgroundImage")));
            this.buttonGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGo.Location = new System.Drawing.Point(526, 270);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(127, 50);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.buttonTopGamers);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "King Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.Button buttonTopGamers;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Button buttonGo;
    }
}

