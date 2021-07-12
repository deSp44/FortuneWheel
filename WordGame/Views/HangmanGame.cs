using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FortuneWheel.Model;

namespace FortuneWheel.Views
{
    public partial class HangmanGame : Form
    {
        private readonly Puzzle _data = HangmanCreate.Puzzle; // Object passed

        private int _failCounter;
        private int _timeCount;

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
            lbAttemptsCounter.Text = _data.PossibleAttempts != null ? $"Pozostałe próby: {_data.PossibleAttempts}" : $"Błędne strzały: {_failCounter}";

            if (_data.TimeRemains != null)
                lbTimeView.Text = _data.TimeRemains.ToString() + " s";
            else
                lbTimeView.Text = _timeCount.ToString() + " s";
        }

        private void btnWithLetter_Click(object sender, EventArgs e)
        {
            var sentence = _data.Sentence.ToUpper(); // Borrow sentence from object and make capital

            if (sender is Button buttonThatClicked) // Identify the button
            {
                var letter = buttonThatClicked.Text.ToUpper(); // Make capital

                var hit = false; // Starting hit status = false
                var letterPosition = 0; // Starting letter position
                foreach (var c in sentence) // Checking all letters in sentence (c - checked letter)
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
                    lbAttemptsCounter.Text = _data.PossibleAttempts != null ? $"Pozostałe próby: {--_data.PossibleAttempts}" : $"Błędne strzały: {++_failCounter}";
                    
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
                else if (_failCounter == _data.PossibleAttempts || _timeCount == _data.TimeRemains)
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
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund zajęło rozwiązanie: {_timeCount}s\r\n\r\nSzanse: {_data.PossibleAttempts}");
            else if (_data.TimeRemains != null)
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund pozostało: {_data.TimeRemains}s\r\n\r\nBłędy: {_failCounter}");
            else
                lbMessages.Text = ($"Dobre hasło!!!\r\n\r\nTyle sekund zajęło rozwiązanie: {_timeCount}s\r\n\r\nBłędy: {_failCounter}");

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
                _timeCount++;
                lbTimeView.Text = _timeCount.ToString() + " s";
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