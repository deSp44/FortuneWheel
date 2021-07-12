using System;
using System.Windows.Forms;
using FortuneWheel.Model;

namespace FortuneWheel.Views
{
    public partial class HangmanCreate : Form
    {
        public static Puzzle Puzzle;

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
                CreatePuzzle();

                this.Hide();
                var nextWindow = new HangmanGame();
                nextWindow.ShowDialog();
                this.Close();
            }
        }
        private void CreatePuzzle()
        {
            Puzzle = new Puzzle
            {
                Category = cbCategory.Text,
                Sentence = tbSentence.Text
            };
            if (nupAttempts.Enabled)
                Puzzle.PossibleAttempts = Convert.ToInt32(nupAttempts.Value);
            if (nupTime.Enabled)
                Puzzle.TimeRemains = Convert.ToInt32(nupTime.Value);
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
            nupTime.Enabled = cbTime.Checked;
        }

        private void cbAttempts_CheckedChanged(object sender, EventArgs e)
        {
            nupAttempts.Enabled = cbAttempts.Checked;
        }

        private void tbSentence_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}