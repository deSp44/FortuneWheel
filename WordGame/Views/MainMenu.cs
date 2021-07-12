using System;
using System.Windows.Forms;

namespace FortuneWheel.Views
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextWindow = new HangmanCreate();
            nextWindow.ShowDialog();
            this.Close();
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            //TODO : GAMEMODE_2
            ;
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            //TODO : GAMEMODE_3
            ;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program napisany przez deSp\r\nhttps://github.com/deSp44", "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
