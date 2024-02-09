namespace PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.gameStarting = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(316, 117);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(154, 109);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gameStarting
            // 
            this.gameStarting.AutoSize = true;
            this.gameStarting.BackColor = System.Drawing.Color.Black;
            this.gameStarting.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStarting.ForeColor = System.Drawing.Color.LimeGreen;
            this.gameStarting.Location = new System.Drawing.Point(290, 316);
            this.gameStarting.Name = "gameStarting";
            this.gameStarting.Size = new System.Drawing.Size(226, 21);
            this.gameStarting.TabIndex = 1;
            this.gameStarting.Text = "Game Starting In: ";
            // 
            // loadingBar
            // 
            this.loadingBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.loadingBar.Location = new System.Drawing.Point(294, 355);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loadingBar.Size = new System.Drawing.Size(222, 23);
            this.loadingBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.gameStarting);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label gameStarting;
        private System.Windows.Forms.ProgressBar loadingBar;
    }
}

