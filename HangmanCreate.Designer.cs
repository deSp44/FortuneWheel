
namespace FortuneWheel
{
    partial class HangmanCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSentence = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nupAttempts = new System.Windows.Forms.NumericUpDown();
            this.nupTime = new System.Windows.Forms.NumericUpDown();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbAttempts = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz kategorie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło do zgadnięcia:";
            // 
            // tbSentence
            // 
            this.tbSentence.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSentence.Location = new System.Drawing.Point(12, 106);
            this.tbSentence.Name = "tbSentence";
            this.tbSentence.Size = new System.Drawing.Size(300, 23);
            this.tbSentence.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 206);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "Akceptuj";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(237, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Cofnij";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "TRYB WISIELCA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Aktorzy",
            "Biologia",
            "Chemia",
            "Czynności",
            "Filozofia",
            "Fizyka",
            "Geografia",
            "Gry wideo",
            "Historia",
            "Imię",
            "Informatyka",
            "Jedzenie",
            "Matematyka",
            "Miejsca",
            "Motoryzacja",
            "Muzycy",
            "Osoba",
            "Piosenki",
            "Postać",
            "Przedmiot",
            "Reżyserzy",
            "Rośliny",
            "Samochody",
            "Seriale",
            "Sport",
            "Tytuł",
            "Zawody",
            "Zwierzęta"});
            this.cbCategory.Location = new System.Drawing.Point(162, 57);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 21);
            this.cbCategory.TabIndex = 8;
            // 
            // nupAttempts
            // 
            this.nupAttempts.Enabled = false;
            this.nupAttempts.Location = new System.Drawing.Point(162, 143);
            this.nupAttempts.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nupAttempts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupAttempts.Name = "nupAttempts";
            this.nupAttempts.Size = new System.Drawing.Size(44, 20);
            this.nupAttempts.TabIndex = 10;
            this.nupAttempts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupTime
            // 
            this.nupTime.Enabled = false;
            this.nupTime.Location = new System.Drawing.Point(162, 167);
            this.nupTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nupTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupTime.Name = "nupTime";
            this.nupTime.Size = new System.Drawing.Size(44, 20);
            this.nupTime.TabIndex = 11;
            this.nupTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Location = new System.Drawing.Point(12, 170);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(147, 17);
            this.cbTime.TabIndex = 14;
            this.cbTime.Text = "Ograniczenie czasowe (s)";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // cbAttempts
            // 
            this.cbAttempts.AutoSize = true;
            this.cbAttempts.Location = new System.Drawing.Point(12, 147);
            this.cbAttempts.Name = "cbAttempts";
            this.cbAttempts.Size = new System.Drawing.Size(124, 17);
            this.cbAttempts.TabIndex = 15;
            this.cbAttempts.Text = "Maks. liczba błędów";
            this.cbAttempts.UseVisualStyleBackColor = true;
            this.cbAttempts.CheckedChanged += new System.EventHandler(this.cbAttempts_CheckedChanged);
            // 
            // HangmanCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 241);
            this.Controls.Add(this.cbAttempts);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.nupTime);
            this.Controls.Add(this.nupAttempts);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbSentence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HangmanCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzupełnij dane";
            ((System.ComponentModel.ISupportInitialize)(this.nupAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSentence;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nupAttempts;
        private System.Windows.Forms.NumericUpDown nupTime;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbAttempts;
    }
}