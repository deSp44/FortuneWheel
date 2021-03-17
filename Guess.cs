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
    public partial class Guess : Form
    {
        Puzzle data = ChooseWord._puzzle; // Object passed
        private int failCounter = 0;
        int timeCount = 0;

        public Guess()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            var replace = new Regex("\\S").Replace(data.Sentence, "*");
            lbHiddenSentence.Text = replace;
            lbCategory.Text = $"Kategoria: {data.Category}";
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
                    failCounter++;
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
                lbAttemptsCounter.Text = $"Błędne strzały: {failCounter}";

                if (lbHiddenSentence.Text == sentence)
                {
                    lbMessages.Text = ($"Dobre hasło!!! Błędne strzały: {failCounter} :)");
                    btnReplay.Enabled = true;
                    panel1.Enabled = false;
                    btnGiveUp.Text = "Wyjdź do menu";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount++;
            lbTimeView.Text = timeCount.ToString() + " s";
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
            var nextWindow = new ChooseWord();
            nextWindow.ShowDialog();
            this.Close();
        }
    }
}
