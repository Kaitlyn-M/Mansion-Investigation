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
    public partial class LeftHall : Form
    {
        public LeftHall()
        {
            InitializeComponent();

            // Left hall's story
            leftStory.Text = "As you carefully walk through the left hall, you hear a variety of noises. " +
            "You slowly approach the closest room then put your ear against the door. " +          
            "There is a strange combination of lively music and eerie sounds. " +
            "Will you investigate the room straight ahead or go right?";
        }

        // Moves the player to the GameOver form
        private void ForwardRoom_Click(object sender, EventArgs e)
        {
            // Creates the Creature form
            Creature creature = new Creature();

            // Hides the current form
            this.Hide();
            // Shows the Creature form
            creature.Show();
        }

        // Moves the player to the GameOver form
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
