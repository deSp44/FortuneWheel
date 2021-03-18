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
    public partial class HangmanCreate : Form
    {
        public static Puzzle _puzzle;

        public HangmanCreate()
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
                    Sentence = tbSentence.Text,
                };

                if (nupAttempts.Enabled)
                    _puzzle.PossibleAttempts = Convert.ToInt32(nupAttempts.Value);
                if (nupTime.Enabled)
                    _puzzle.TimeRemains = Convert.ToInt32(nupTime.Value);

                this.Hide();
                var guess = new HangmanGame();
                guess.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextWindow = new MainMenu();
            nextWindow.ShowDialog();
            this.Close();
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked)
                nupTime.Enabled = true;
            else
                nupTime.Enabled = false;
        }

        private void cbAttempts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAttempts.Checked)
                nupAttempts.Enabled = true;
            else
                nupAttempts.Enabled = false;
        }
    }
}
