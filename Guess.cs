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
        Sentence data = ChooseWord._sentence;
        private int counter = 0;
        public Guess()
        {
            InitializeComponent();

            SetData();
        }

        public void SetData()
        {
            var replace = new Regex("\\S").Replace(data.SentenceToFind, "*");
            lbHiddenSentence.Text = replace;
            lbCategory.Text = $"Kategoria: {data.Category}";
        }

        private void btnAcceptLetter_Click(object sender, EventArgs e)
        {
            var sentence = data.SentenceToFind.ToLower();
            var letter = tbGuess.Text.ToLower();   

            //TODO : Duże i małe litery

            //TODO : niepowtarzalność wyszukiwania znaków (zapisywanie char do listy i porównywanie na kliknięciu?)

            var iter = 0;
            foreach (char c in sentence)
            {
                if (c.ToString() == letter)
                {
                    lbHiddenSentence.Text = lbHiddenSentence.Text.Remove(iter, 1).Insert(iter, c.ToString());
                }
                iter++;
            }
            tbGuess.Clear();
            counter++;
            lbAttemptsCounter.Text = counter.ToString();

            if (lbHiddenSentence.Text == sentence)
            {
                MessageBox.Show($"Zgadłeś hasło!!! Ilość prób: {counter} :)");
            }
        }
    }
}
