using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FortuneWheel
{
    public partial class HangmanGame : Form
    {
        Puzzle _data = HangmanCreate._puzzle; // Object passed

        int failCounter = 0;
        int timeCount = 0;

        public HangmanGame()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            // Replace sentence with asterisk
            var replace = new Regex("\\S").Replace(_data.Sentence, "*");
            lbHiddenSentence.Text = replace;

            // Load other labels
            lbCategory.Text = $"Kategoria: {_data.Category}";

            if (_data.PossibleAttempts != null)
                lbAttemptsCounter.Text = $"Pozostałe próby: {_data.PossibleAttempts}";
            else
                lbAttemptsCounter.Text = $"Błędne strzały: {failCounter}";

            if (_data.TimeRemains != null)
                lbTimeView.Text = _data.TimeRemains.ToString() + " s";
            else
                lbTimeView.Text = timeCount.ToString() + " s";
        }

        private void btnWithLetter_Click(object sender, EventArgs e)
        {
            var sentence = _data.Sentence.ToUpper(); // Borrow sentence from object and make capital

            if (sender is Button buttonThatClicked) // Identify the button
            {
                var letter = buttonThatClicked.Text.ToUpper(); // Make capital

                var hit = false; // Starting hit status = false
                var letterPosition = 0; // Starting letter position
                foreach (char c in sentence) // Checking all letters in sentence (c - checked letter)
                {
                    if (c.ToString() == letter)
                    {
                        lbHiddenSentence.Text = lbHiddenSentence.Text.Remove(letterPosition, 1).Insert(letterPosition, c.ToString()); // Replace
                        hit = true;
                    }
                    letterPosition++;
                }

                if (!hit) // Letter hit negative (-)
                {
                    if (_data.PossibleAttempts != null)
                        lbAttemptsCounter.Text = $"Pozostałe próby: {--_data.PossibleAttempts}";
                    else
                        lbAttemptsCounter.Text = $"Błędne strzały: {++failCounter}";
                    
                    // the button becomes used
                    buttonThatClicked.Enabled = false;
                    buttonThatClicked.BackColor = Color.LightCoral;
                    buttonThatClicked.ForeColor = Color.Red;
                }
                else // Letter hit positive (+)
                {
                    // the button becomes used
                    buttonThatClicked.Enabled = false;
                    buttonThatClicked.BackColor = Color.LightGreen;
                    buttonThatClicked.ForeColor = Color.Green;
                }
                
                // Game result
                if (lbHiddenSentence.Text == sentence)
                    GameWonMessage();
                else if (failCounter == _data.PossibleAttempts || timeCount == _data.TimeRemains)
                    GameLostMessage();
            }
        }

        private void GameLostMessage()
        {
            lbMessages.Text = ("Przegrana!!!");
            panKeyboard.Enabled = false;
            btnReplay.Enabled = true;
            tmrCounter.Stop();
            btnGiveUp.Text = "Wyjdź do menu";
            lbHiddenSentence.Text = _data.Sentence.ToUpper();
        }

        private void GameWonMessage()
        {
            if (_data.PossibleAttempts != null && _data.TimeRemains != null)
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund pozostało: {_data.TimeRemains}s\r\n\r\nSzanse: {_data.PossibleAttempts}");
            else if (_data.PossibleAttempts != null)
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund zajęło rozwiązanie: {timeCount}s\r\n\r\nSzanse: {_data.PossibleAttempts}");
            else if (_data.TimeRemains != null)
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund pozostało: {_data.TimeRemains}s\r\n\r\nBłędy: {failCounter}");
            else
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund zajęło rozwiązanie: {timeCount}s\r\n\r\nBłędy: {failCounter}");

            tmrCounter.Stop();
            btnReplay.Enabled = true;
            panKeyboard.Enabled = false;
            btnGiveUp.Text = "Wyjdź do menu";
        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            if (_data.TimeRemains != null)
            {
                _data.TimeRemains--;
                lbTimeView.Text = _data.TimeRemains.ToString() + " s";
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
            else
            {
                lbHiddenSentence.Text = _data.Sentence.ToUpper();
                btnGiveUp.Text = "Wyjdź do menu";
                panKeyboard.Enabled = false;
                btnReplay.Enabled = true;
            }   
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
