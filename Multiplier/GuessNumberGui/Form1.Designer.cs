namespace GuessNumberGui
{
    partial class GuessNumberForm
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
            this.textGuess = new System.Windows.Forms.TextBox();
            this.btnRunGame = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textGuess
            // 
            this.textGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGuess.Location = new System.Drawing.Point(13, 22);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(651, 62);
            this.textGuess.TabIndex = 0;
            // 
            // btnRunGame
            // 
            this.btnRunGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunGame.Location = new System.Drawing.Point(13, 150);
            this.btnRunGame.Name = "btnRunGame";
            this.btnRunGame.Size = new System.Drawing.Size(651, 75);
            this.btnRunGame.TabIndex = 1;
            this.btnRunGame.Text = "Guess Number";
            this.btnRunGame.UseVisualStyleBackColor = true;
            this.btnRunGame.Click += new System.EventHandler(this.btnRunGame_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(13, 299);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 55);
            this.lblResult.TabIndex = 2;
            // 
            // GuessNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 548);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRunGame);
            this.Controls.Add(this.textGuess);
            this.Name = "GuessNumberForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GuessNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGuess;
        private System.Windows.Forms.Button btnRunGame;
        private System.Windows.Forms.Label lblResult;
    }
}

