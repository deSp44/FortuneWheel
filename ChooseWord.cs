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
        public static Puzzle _puzzle;

        public ChooseWord()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbSentence.Text == "")
                MessageBox.Show("Nie wpisano wyrazu do odgadnięcia.", "Brak wyrazu!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(cbCategory.Text == "")
                MessageBox.Show("Nie wybrano kategorii!", "Brak kategorii!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _puzzle = new Puzzle
                {
                    Category = cbCategory.Text,
                    Sentence = tbSentence.Text
                };

                this.Hide();
                var guess = new Guess();
                guess.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangeGameMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextWindow = new MainMenu();
            nextWindow.ShowDialog();
            this.Close();
        }
    }
}
