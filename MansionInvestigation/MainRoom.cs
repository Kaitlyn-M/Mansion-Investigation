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
    public partial class MainRoom : Form
    {
        public MainRoom(string characterName, string characterType)
        {
            InitializeComponent();

            // Main room's story                  
            mainStory.Text = "You enter the mansion then step onto the red carpet. " +
            "Seconds later, you hear a mysterious voice from a hidden one-way intercom system. " +
            "The stranger begins to speak. " +
            "\"Hello, " + characterName.Trim() + ". " +
            "Although I expected you, I'm sure you didn't expect me. " +
            "Well, I hope you find whatever you are looking for. " +
            "Good luck, " + characterType.ToLower() + ".\" " +
            "Suddenly, the intercom shuts off with a loud buzz. " +
            "Where will you investigate first, " + characterType.ToLower() + "?";                      
        }

        // Moves the player to the LeftHall form
        private void LeftHall_Click(object sender, EventArgs e)
        {
            // Creates the LeftHall form
            LeftHall leftHall = new LeftHall();

            // Hides the current form
            this.Hide();
            // Shows the LeftHall form
            leftHall.Show();
        }

        // Moves the player to the Upstairs form
        private void Upstairs_Click(object sender, EventArgs e)
        {
            // Creates the Upstairs form
            Upstairs upstairs = new Upstairs();

            // Hides the current form
            this.Hide();
            // Shows the Upstairs form
            upstairs.Show();
        }

        // Moves the player to the GameOver form
        private void RightHall_Click(object sender, EventArgs e)
        {
            // Creates the GameOver form
            GameOver gameOver = new GameOver();
            
            // Hides the current form
            this.Hide();         
            // Shows the GameOver form
            gameOver.Show();
        }
    }
}
