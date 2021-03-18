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
            ;
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
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
