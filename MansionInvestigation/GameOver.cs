using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Picture resource: https://freerangestock.com/photos/136104/close-up-of-a-dark-brick-wall--black-bricks.html

namespace MansionInvestigation
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        // Allows the player to restart the game
        private void Restart_Click(object sender, EventArgs e)
        {
            // Creates the TitleScreen form
            TitleScreen titleScreen = new TitleScreen();

            // Hides the current form
            this.Hide();
            // Shows the TitleScreen form
            titleScreen.Show();
        }
    }
}
