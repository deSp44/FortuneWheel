
namespace FortuneWheel.Views
{
    partial class HangmanGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanGame));
            this.lbSentence = new System.Windows.Forms.Label();
            this.lbHiddenSentence = new System.Windows.Forms.Label();
            this.lbAttemptsCounter = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.panKeyboard = new System.Windows.Forms.Panel();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnŹ = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnŻ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnŚ = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnŃ = new System.Windows.Forms.Button();
            this.btnÓ = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnŁ = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnĘ = new System.Windows.Forms.Button();
            this.btnĆ = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnĄ = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.lbTimeView = new System.Windows.Forms.Label();
            this.lbMessages = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.panKeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSentence
            // 
            this.lbSentence.AutoSize = true;
            this.lbSentence.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSentence.Location = new System.Drawing.Point(12, 48);
            this.lbSentence.Name = "lbSentence";
            this.lbSentence.Size = new System.Drawing.Size(119, 19);
            this.lbSentence.TabIndex = 1;
            this.lbSentence.Text = "Twoje hasło: ";
            // 
            // lbHiddenSentence
            // 
            this.lbHiddenSentence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHiddenSentence.BackColor = System.Drawing.Color.Silver;
            this.lbHiddenSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHiddenSentence.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHiddenSentence.Location = new System.Drawing.Point(16, 78);
            this.lbHiddenSentence.Name = "lbHiddenSentence";
            this.lbHiddenSentence.Size = new System.Drawing.Size(502, 47);
            this.lbHiddenSentence.TabIndex = 8;
            this.lbHiddenSentence.Text = "?";
            this.lbHiddenSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAttemptsCounter
            // 
            this.lbAttemptsCounter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAttemptsCounter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbAttemptsCounter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAttemptsCounter.Location = new System.Drawing.Point(333, 46);
            this.lbAttemptsCounter.Name = "lbAttemptsCounter";
            this.lbAttemptsCounter.Size = new System.Drawing.Size(185, 32);
            this.lbAttemptsCounter.TabIndex = 9;
            this.lbAttemptsCounter.Text = "Błędne strzały: 0";
            this.lbAttemptsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCategory.Location = new System.Drawing.Point(12, 18);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(100, 19);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Kategoria: ";
            // 
            // panKeyboard
            // 
            this.panKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panKeyboard.Controls.Add(this.btnZ);
            this.panKeyboard.Controls.Add(this.btnŹ);
            this.panKeyboard.Controls.Add(this.btnY);
            this.panKeyboard.Controls.Add(this.btnŻ);
            this.panKeyboard.Controls.Add(this.btnW);
            this.panKeyboard.Controls.Add(this.btnX);
            this.panKeyboard.Controls.Add(this.btnV);
            this.panKeyboard.Controls.Add(this.btnŚ);
            this.panKeyboard.Controls.Add(this.btnU);
            this.panKeyboard.Controls.Add(this.btnS);
            this.panKeyboard.Controls.Add(this.btnT);
            this.panKeyboard.Controls.Add(this.btnQ);
            this.panKeyboard.Controls.Add(this.btnR);
            this.panKeyboard.Controls.Add(this.btnP);
            this.panKeyboard.Controls.Add(this.btnŃ);
            this.panKeyboard.Controls.Add(this.btnÓ);
            this.panKeyboard.Controls.Add(this.btnN);
            this.panKeyboard.Controls.Add(this.btnO);
            this.panKeyboard.Controls.Add(this.btnŁ);
            this.panKeyboard.Controls.Add(this.btnM);
            this.panKeyboard.Controls.Add(this.btnL);
            this.panKeyboard.Controls.Add(this.btnI);
            this.panKeyboard.Controls.Add(this.btnK);
            this.panKeyboard.Controls.Add(this.btnH);
            this.panKeyboard.Controls.Add(this.btnJ);
            this.panKeyboard.Controls.Add(this.btnF);
            this.panKeyboard.Controls.Add(this.btnG);
            this.panKeyboard.Controls.Add(this.btnĘ);
            this.panKeyboard.Controls.Add(this.btnĆ);
            this.panKeyboard.Controls.Add(this.btnE);
            this.panKeyboard.Controls.Add(this.btnC);
            this.panKeyboard.Controls.Add(this.btnD);
            this.panKeyboard.Controls.Add(this.btnĄ);
            this.panKeyboard.Controls.Add(this.btnB);
            this.panKeyboard.Controls.Add(this.btnA);
            this.panKeyboard.Location = new System.Drawing.Point(16, 139);
            this.panKeyboard.Name = "panKeyboard";
            this.panKeyboard.Size = new System.Drawing.Size(324, 235);
            this.panKeyboard.TabIndex = 12;
            // 
            // btnZ
            // 
            this.btnZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZ.Location = new System.Drawing.Point(187, 188);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(40, 40);
            this.btnZ.TabIndex = 37;
            this.btnZ.TabStop = false;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnŹ
            // 
            this.btnŹ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnŹ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnŹ.Location = new System.Drawing.Point(279, 188);
            this.btnŹ.Name = "btnŹ";
            this.btnŹ.Size = new System.Drawing.Size(40, 40);
            this.btnŹ.TabIndex = 36;
            this.btnŹ.TabStop = false;
            this.btnŹ.Text = "Ź";
            this.btnŹ.UseVisualStyleBackColor = true;
            this.btnŹ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnY
            // 
            this.btnY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnY.Location = new System.Drawing.Point(141, 188);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(40, 40);
            this.btnY.TabIndex = 35;
            this.btnY.TabStop = false;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnŻ
            // 
            this.btnŻ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnŻ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnŻ.Location = new System.Drawing.Point(233, 188);
            this.btnŻ.Name = "btnŻ";
            this.btnŻ.Size = new System.Drawing.Size(40, 40);
            this.btnŻ.TabIndex = 34;
            this.btnŻ.TabStop = false;
            this.btnŻ.Text = "Ż";
            this.btnŻ.UseVisualStyleBackColor = true;
            this.btnŻ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnW
            // 
            this.btnW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnW.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnW.Location = new System.Drawing.Point(49, 188);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(40, 40);
            this.btnW.TabIndex = 33;
            this.btnW.TabStop = false;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnX
            // 
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnX.Location = new System.Drawing.Point(95, 188);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(40, 40);
            this.btnX.TabIndex = 32;
            this.btnX.TabStop = false;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnV
            // 
            this.btnV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnV.Location = new System.Drawing.Point(3, 188);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(40, 40);
            this.btnV.TabIndex = 31;
            this.btnV.TabStop = false;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnŚ
            // 
            this.btnŚ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnŚ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnŚ.Location = new System.Drawing.Point(187, 142);
            this.btnŚ.Name = "btnŚ";
            this.btnŚ.Size = new System.Drawing.Size(40, 40);
            this.btnŚ.TabIndex = 30;
            this.btnŚ.TabStop = false;
            this.btnŚ.Text = "Ś";
            this.btnŚ.UseVisualStyleBackColor = true;
            this.btnŚ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnU
            // 
            this.btnU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnU.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnU.Location = new System.Drawing.Point(279, 142);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(40, 40);
            this.btnU.TabIndex = 29;
            this.btnU.TabStop = false;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnS
            // 
            this.btnS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnS.Location = new System.Drawing.Point(141, 142);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(40, 40);
            this.btnS.TabIndex = 28;
            this.btnS.TabStop = false;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnT
            // 
            this.btnT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnT.Location = new System.Drawing.Point(233, 142);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(40, 40);
            this.btnT.TabIndex = 27;
            this.btnT.TabStop = false;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnQ
            // 
            this.btnQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnQ.Location = new System.Drawing.Point(49, 142);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(40, 40);
            this.btnQ.TabIndex = 26;
            this.btnQ.TabStop = false;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnR
            // 
            this.btnR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnR.Location = new System.Drawing.Point(95, 142);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(40, 40);
            this.btnR.TabIndex = 25;
            this.btnR.TabStop = false;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnP
            // 
            this.btnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnP.Location = new System.Drawing.Point(3, 142);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(40, 40);
            this.btnP.TabIndex = 24;
            this.btnP.TabStop = false;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnŃ
            // 
            this.btnŃ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnŃ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnŃ.Location = new System.Drawing.Point(187, 96);
            this.btnŃ.Name = "btnŃ";
            this.btnŃ.Size = new System.Drawing.Size(40, 40);
            this.btnŃ.TabIndex = 23;
            this.btnŃ.TabStop = false;
            this.btnŃ.Text = "Ń";
            this.btnŃ.UseVisualStyleBackColor = true;
            this.btnŃ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnÓ
            // 
            this.btnÓ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÓ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnÓ.Location = new System.Drawing.Point(279, 96);
            this.btnÓ.Name = "btnÓ";
            this.btnÓ.Size = new System.Drawing.Size(40, 40);
            this.btnÓ.TabIndex = 22;
            this.btnÓ.TabStop = false;
            this.btnÓ.Text = "Ó";
            this.btnÓ.UseVisualStyleBackColor = true;
            this.btnÓ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnN
            // 
            this.btnN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnN.Location = new System.Drawing.Point(141, 96);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(40, 40);
            this.btnN.TabIndex = 21;
            this.btnN.TabStop = false;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnO
            // 
            this.btnO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnO.Location = new System.Drawing.Point(233, 96);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(40, 40);
            this.btnO.TabIndex = 20;
            this.btnO.TabStop = false;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnŁ
            // 
            this.btnŁ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnŁ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnŁ.Location = new System.Drawing.Point(49, 96);
            this.btnŁ.Name = "btnŁ";
            this.btnŁ.Size = new System.Drawing.Size(40, 40);
            this.btnŁ.TabIndex = 19;
            this.btnŁ.TabStop = false;
            this.btnŁ.Text = "Ł";
            this.btnŁ.UseVisualStyleBackColor = true;
            this.btnŁ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnM
            // 
            this.btnM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnM.Location = new System.Drawing.Point(95, 96);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(40, 40);
            this.btnM.TabIndex = 18;
            this.btnM.TabStop = false;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnL
            // 
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnL.Location = new System.Drawing.Point(3, 96);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(40, 40);
            this.btnL.TabIndex = 17;
            this.btnL.TabStop = false;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnI
            // 
            this.btnI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnI.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnI.Location = new System.Drawing.Point(187, 50);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(40, 40);
            this.btnI.TabIndex = 16;
            this.btnI.TabStop = false;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnK
            // 
            this.btnK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnK.Location = new System.Drawing.Point(279, 50);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(40, 40);
            this.btnK.TabIndex = 15;
            this.btnK.TabStop = false;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnH
            // 
            this.btnH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnH.Location = new System.Drawing.Point(141, 50);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(40, 40);
            this.btnH.TabIndex = 14;
            this.btnH.TabStop = false;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnJ
            // 
            this.btnJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJ.Location = new System.Drawing.Point(233, 50);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(40, 40);
            this.btnJ.TabIndex = 13;
            this.btnJ.TabStop = false;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnF
            // 
            this.btnF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnF.Location = new System.Drawing.Point(49, 50);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(40, 40);
            this.btnF.TabIndex = 12;
            this.btnF.TabStop = false;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnG
            // 
            this.btnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnG.Location = new System.Drawing.Point(95, 50);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(40, 40);
            this.btnG.TabIndex = 11;
            this.btnG.TabStop = false;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnĘ
            // 
            this.btnĘ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnĘ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnĘ.Location = new System.Drawing.Point(3, 50);
            this.btnĘ.Name = "btnĘ";
            this.btnĘ.Size = new System.Drawing.Size(40, 40);
            this.btnĘ.TabIndex = 10;
            this.btnĘ.TabStop = false;
            this.btnĘ.Text = "Ę";
            this.btnĘ.UseVisualStyleBackColor = true;
            this.btnĘ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnĆ
            // 
            this.btnĆ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnĆ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnĆ.Location = new System.Drawing.Point(187, 4);
            this.btnĆ.Name = "btnĆ";
            this.btnĆ.Size = new System.Drawing.Size(40, 40);
            this.btnĆ.TabIndex = 7;
            this.btnĆ.TabStop = false;
            this.btnĆ.Text = "Ć";
            this.btnĆ.UseVisualStyleBackColor = true;
            this.btnĆ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnE
            // 
            this.btnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnE.Location = new System.Drawing.Point(279, 4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(40, 40);
            this.btnE.TabIndex = 6;
            this.btnE.TabStop = false;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnC
            // 
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC.Location = new System.Drawing.Point(141, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 40);
            this.btnC.TabIndex = 4;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnD
            // 
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD.Location = new System.Drawing.Point(233, 4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(40, 40);
            this.btnD.TabIndex = 3;
            this.btnD.TabStop = false;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnĄ
            // 
            this.btnĄ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnĄ.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnĄ.Location = new System.Drawing.Point(49, 4);
            this.btnĄ.Name = "btnĄ";
            this.btnĄ.Size = new System.Drawing.Size(40, 40);
            this.btnĄ.TabIndex = 2;
            this.btnĄ.TabStop = false;
            this.btnĄ.Text = "Ą";
            this.btnĄ.UseVisualStyleBackColor = true;
            this.btnĄ.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnB
            // 
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB.Location = new System.Drawing.Point(95, 4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(40, 40);
            this.btnB.TabIndex = 1;
            this.btnB.TabStop = false;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnA
            // 
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA.Location = new System.Drawing.Point(3, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(40, 40);
            this.btnA.TabIndex = 0;
            this.btnA.TabStop = false;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnWithLetter_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(376, 328);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(118, 40);
            this.btnGiveUp.TabIndex = 13;
            this.btnGiveUp.TabStop = false;
            this.btnGiveUp.Text = "Poddaje się :(";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // tmrCounter
            // 
            this.tmrCounter.Enabled = true;
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // lbTimeView
            // 
            this.lbTimeView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTimeView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTimeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeView.Location = new System.Drawing.Point(429, 18);
            this.lbTimeView.Name = "lbTimeView";
            this.lbTimeView.Size = new System.Drawing.Size(89, 28);
            this.lbTimeView.TabIndex = 14;
            this.lbTimeView.Text = "0 s";
            this.lbTimeView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMessages
            // 
            this.lbMessages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMessages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMessages.Location = new System.Drawing.Point(376, 144);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(118, 132);
            this.lbMessages.TabIndex = 15;
            // 
            // btnReplay
            // 
            this.btnReplay.Enabled = false;
            this.btnReplay.Location = new System.Drawing.Point(376, 282);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(118, 40);
            this.btnReplay.TabIndex = 16;
            this.btnReplay.TabStop = false;
            this.btnReplay.Text = "Zagraj jeszcze raz!";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // HangmanGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 388);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.lbTimeView);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.panKeyboard);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbAttemptsCounter);
            this.Controls.Add(this.lbHiddenSentence);
            this.Controls.Add(this.lbSentence);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangmanGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wisielec";
            this.panKeyboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSentence;
        private System.Windows.Forms.Label lbHiddenSentence;
        private System.Windows.Forms.Label lbAttemptsCounter;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Panel panKeyboard;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnŹ;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnŻ;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnŚ;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnŃ;
        private System.Windows.Forms.Button btnÓ;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnŁ;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnĘ;
        private System.Windows.Forms.Button btnĆ;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnĄ;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.Label lbTimeView;
        private System.Windows.Forms.Label lbMessages;
        private System.Windows.Forms.Button btnReplay;
    }
}

