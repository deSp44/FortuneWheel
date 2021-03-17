using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneWheel
{
    public partial class ChooseWord : Form
    {
        public static Sentence _sentence;

        public ChooseWord()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _sentence = new Sentence
            { 
                Category = tbCategory.Text,
                SentenceToFind = tbSentence.Text
            };

            this.Hide();
            var guess = new Guess();
            guess.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangeGameMode_Click(object sender, EventArgs e)
        {
            //TODO : inne tryby
        }
    }
}
