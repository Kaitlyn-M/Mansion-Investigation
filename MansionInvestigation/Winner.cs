using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Picture resource: https://wallpapersafari.com/w/KGsTWO

namespace MansionInvestigation
{
    public partial class Winner : Form
    {
        public Winner()
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
