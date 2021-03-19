using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FortuneWheel
{
    public partial class HangmanGame : Form
    {
        Puzzle data = HangmanCreate._puzzle; // Object passed
        private int failCounter = 0;
        int timeCount = 0;
        bool gameLost = false;

        public HangmanGame()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            var replace = new Regex("\\S").Replace(data.Sentence, "*");
            lbHiddenSentence.Text = replace;
            lbCategory.Text = $"Kategoria: {data.Category}";

            if (data.PossibleAttempts != null)
                lbAttemptsCounter.Text = $"Pozostałe próby: {data.PossibleAttempts}";
            else
                lbAttemptsCounter.Text = $"Błędne strzały: {failCounter}";

            if (data.TimeRemains != null)
                lbTimeView.Text = data.TimeRemains.ToString() + " s";
            else
                lbTimeView.Text = timeCount.ToString() + " s";
        }

        private void btnWithLetter_Click(object sender, EventArgs e)
        {
            var sentence = data.Sentence.ToUpper();

            if (sender is Button buttonThatClicked)
            {
                var letter = buttonThatClicked.Text.ToUpper();

                var hit = false;
                var letterPosition = 0;
                foreach (char c in sentence)
                {
                    if (c.ToString() == letter)
                    {
                        lbHiddenSentence.Text = lbHiddenSentence.Text.Remove(letterPosition, 1).Insert(letterPosition, c.ToString());
                        hit = true;
                    }
                    letterPosition++;
                }
                if (!hit)
                {
                    if (data.PossibleAttempts != null)
                    {
                        data.PossibleAttempts--;
                        lbAttemptsCounter.Text = $"Pozostałe próby: {data.PossibleAttempts}";
                    }
                    else
                    {
                        failCounter++;
                        lbAttemptsCounter.Text = $"Błędne strzały: {failCounter}";
                    }
                        
                    buttonThatClicked.Enabled = false;
                    buttonThatClicked.BackColor = Color.LightCoral;
                    buttonThatClicked.ForeColor = Color.Red;
                }
                else
                {
                    buttonThatClicked.Enabled = false;
                    buttonThatClicked.BackColor = Color.LightGreen;
                    buttonThatClicked.ForeColor = Color.Green;
                }
                
                if (failCounter == data.PossibleAttempts)
                {
                    gameLost = true;
                }
                if (timeCount == data.TimeRemains)
                {
                    gameLost = true;
                }

                if (lbHiddenSentence.Text == sentence)
                {
                    if (data.PossibleAttempts != null && data.TimeRemains != null)
                        lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund pozostało: {data.TimeRemains}s\r\n\r\nSzanse: {data.PossibleAttempts}");
                    else if(data.PossibleAttempts != null)
                        lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund zajęło rozwiązanie: {timeCount}s\r\n\r\nSzanse: {data.PossibleAttempts}");
                    else if(data.TimeRemains != null)  
                        lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund pozostało: {data.TimeRemains}s\r\n\r\nBłędy: {failCounter}");
                    else      
                        lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund zajęło rozwiązanie: {timeCount}s\r\n\r\nBłędy: {failCounter}");

                    tmrCounter.Stop();
                    btnReplay.Enabled = true;
                    panel1.Enabled = false;
                    btnGiveUp.Text = "Wyjdź do menu";
                }
                else if (gameLost)
                {
                    lbMessages.Text = ($"Przegrana!!!");
                    tmrCounter.Stop();
                    btnReplay.Enabled = true;
                    panel1.Enabled = false;
                    btnGiveUp.Text = "Wyjdź do menu";

                    lbHiddenSentence.Text = data.Sentence.ToUpper();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (data.TimeRemains != null)
            {
                data.TimeRemains--;
                lbTimeView.Text = data.TimeRemains.ToString() + " s";
            }
            else
            {
                timeCount++;
                lbTimeView.Text = timeCount.ToString() + " s";
            }
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (btnGiveUp.Text == "Wyjdź do menu")
            {
                this.Hide();
                var nextWindow = new MainMenu();
                nextWindow.ShowDialog();
                this.Close();
            }

            lbHiddenSentence.Text = data.Sentence.ToUpper();
            btnGiveUp.Text = "Wyjdź do menu";
            panel1.Enabled = false;
            btnReplay.Enabled = true;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextWindow = new HangmanCreate();
            nextWindow.ShowDialog();
            this.Close();
        }
    }
}
