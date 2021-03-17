
namespace FortuneWheel
{
    partial class Guess
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
            this.lbGameMode = new System.Windows.Forms.Label();
            this.lbSentence = new System.Windows.Forms.Label();
            this.lbAttempts = new System.Windows.Forms.Label();
            this.lbGuess = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.btnAcceptLetter = new System.Windows.Forms.Button();
            this.lbHiddenSentence = new System.Windows.Forms.Label();
            this.lbAttemptsCounter = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGameMode
            // 
            this.lbGameMode.AutoSize = true;
            this.lbGameMode.Location = new System.Drawing.Point(12, 9);
            this.lbGameMode.Name = "lbGameMode";
            this.lbGameMode.Size = new System.Drawing.Size(59, 13);
            this.lbGameMode.TabIndex = 0;
            this.lbGameMode.Text = "gamemode";
            // 
            // lbSentence
            // 
            this.lbSentence.AutoSize = true;
            this.lbSentence.Location = new System.Drawing.Point(12, 67);
            this.lbSentence.Name = "lbSentence";
            this.lbSentence.Size = new System.Drawing.Size(111, 13);
            this.lbSentence.TabIndex = 1;
            this.lbSentence.Text = "Hasło do zgadnięcia: ";
            // 
            // lbAttempts
            // 
            this.lbAttempts.AutoSize = true;
            this.lbAttempts.Location = new System.Drawing.Point(12, 108);
            this.lbAttempts.Name = "lbAttempts";
            this.lbAttempts.Size = new System.Drawing.Size(37, 13);
            this.lbAttempts.TabIndex = 2;
            this.lbAttempts.Text = "Próby:";
            // 
            // lbGuess
            // 
            this.lbGuess.AutoSize = true;
            this.lbGuess.Location = new System.Drawing.Point(12, 44);
            this.lbGuess.Name = "lbGuess";
            this.lbGuess.Size = new System.Drawing.Size(86, 13);
            this.lbGuess.TabIndex = 5;
            this.lbGuess.Text = "Wprowadź literę:";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(129, 38);
            this.tbGuess.MaxLength = 1;
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(26, 20);
            this.tbGuess.TabIndex = 6;
            // 
            // btnAcceptLetter
            // 
            this.btnAcceptLetter.Location = new System.Drawing.Point(161, 36);
            this.btnAcceptLetter.Name = "btnAcceptLetter";
            this.btnAcceptLetter.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptLetter.TabIndex = 7;
            this.btnAcceptLetter.Text = "Wprowadź";
            this.btnAcceptLetter.UseVisualStyleBackColor = true;
            this.btnAcceptLetter.Click += new System.EventHandler(this.btnAcceptLetter_Click);
            // 
            // lbHiddenSentence
            // 
            this.lbHiddenSentence.AutoSize = true;
            this.lbHiddenSentence.Location = new System.Drawing.Point(129, 67);
            this.lbHiddenSentence.Name = "lbHiddenSentence";
            this.lbHiddenSentence.Size = new System.Drawing.Size(0, 13);
            this.lbHiddenSentence.TabIndex = 8;
            // 
            // lbAttemptsCounter
            // 
            this.lbAttemptsCounter.AutoSize = true;
            this.lbAttemptsCounter.Location = new System.Drawing.Point(58, 108);
            this.lbAttemptsCounter.Name = "lbAttemptsCounter";
            this.lbAttemptsCounter.Size = new System.Drawing.Size(13, 13);
            this.lbAttemptsCounter.TabIndex = 9;
            this.lbAttemptsCounter.Text = "0";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(126, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(58, 13);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Kategoria: ";
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 137);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbAttemptsCounter);
            this.Controls.Add(this.lbHiddenSentence);
            this.Controls.Add(this.btnAcceptLetter);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lbGuess);
            this.Controls.Add(this.lbAttempts);
            this.Controls.Add(this.lbSentence);
            this.Controls.Add(this.lbGameMode);
            this.Name = "Guess";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGameMode;
        private System.Windows.Forms.Label lbSentence;
        private System.Windows.Forms.Label lbAttempts;
        private System.Windows.Forms.Label lbGuess;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button btnAcceptLetter;
        private System.Windows.Forms.Label lbHiddenSentence;
        private System.Windows.Forms.Label lbAttemptsCounter;
        private System.Windows.Forms.Label lbCategory;
    }
}

