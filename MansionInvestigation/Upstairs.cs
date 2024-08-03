using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Picture resource: https://www.artstation.com/artwork/Qa5eE

namespace MansionInvestigation
{
    public partial class Upstairs : Form
    {
        public Upstairs()
        {
            InitializeComponent();

            // Upstairs' story
            upstairsStory.Text = "The stairs creak and seem to sink as you walk up. " +
            "As you luckily made it up the stairs, you decide to check the left and right rooms. " +           
            "You slowly approach the left room, which is eerily silent. " +
            "Immediately when you turn around, the right door violently shakes. " +
            "Once you get slightly closer, loud and discordant scratching is heard. " +
            "Will you investigate the left or right room?";
        }

        // Moves the player to the GameOver form
        private void LeftRoom_Click(object sender, EventArgs e)
        {
            // Creates the GameOver form
            GameOver gameOver = new GameOver();

            // Hides the current form
            this.Hide();
            // Shows the GameOver form
            gameOver.Show();
        }

        // Moves the player to the Creature form
        private void RightRoom_Click(object sender, EventArgs e)
        {
            // Creates the Creature form
            Creature creature = new Creature();

            // Hides the current form
            this.Hide();
            // Shows the Creature form
            creature.Show();
        }
    }
}
