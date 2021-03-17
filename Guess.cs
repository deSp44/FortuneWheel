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
                    MessageBox.Show($"Zgadłeś hasło!!! Błędne strzały: {failCounter} :)");
                }
            }
        }
    }
}
