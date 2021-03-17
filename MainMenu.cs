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
            var nextWindow = new ChooseWord();
            nextWindow.ShowDialog();
            this.Close();
        }
    }
}
