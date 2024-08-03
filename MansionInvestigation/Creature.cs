using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Allows input and output functions
using System.IO;

// Picture resource: https://crypttv.fandom.com/wiki/Miss_Annity_(character)
// Picture resource: https://crypttv.fandom.com/wiki/The_Mordeo_Queen

namespace MansionInvestigation
{
    public partial class Creature : Form
    {

        public Creature()
        {
            InitializeComponent();

            // Creates a random creature object
            Random rdmCreature = new Random();
            // Random number is between 0 and 4
            int creature = rdmCreature.Next(0, 4);

            // Annity encounter
            if (creature < 2)
            {
                // Annity's image
                creaturePic.Image = Image.FromFile(@"annity.png");

                // Annity's story
                creatureStory.Text = "Once you enter the pitch black room, the creature scurries towards the far-left corner of the room. " +
                "Suddenly, you feel a sense of dread as you hurriedly reach for your flashlight. " +
                "As your back is put against the door, you manage to turn your flashlight on. " +
                "It didn't take long before you shine the light on the arachnid woman. " +
                "The woman screeches then charages at you. " +
                "Will you run or hide?";
            }
            // Mordeo encounter
            else
            {
                // Mordeo's image
                creaturePic.Image = Image.FromFile(@"mordeo.png");

                // Mordeo's story
                creatureStory.Text = "Once you enter the pitch black room, the creature turns it's head towards you." +
                "Suddenly, you feel a sense of dread as you hurriedly reach for your flashlight. " +
                "As your back is put against the door, you manage to turn your flashlight on. " +
                "It didn't take long before you shine the light on the alien-deer-human hybrid. " +
                "The hybrid growls then charages at you on it's hands and feet." +
                "Will you run or hide?";
            }

        }

        // Executes if the player fights the creature
        private void Fight_Click(object sender, EventArgs e)
        {
  
            // Creates a reader .txt file
            StreamReader File = new StreamReader("CharacterType.txt");
            // The character type is the first line read in .txt file
            string characterType = File.ReadLine();
            // Closes .txt file
            File.Close();

            // Creates a random number object
            Random rdmNum = new Random();
            // Random number is between 0 and 10
            int fightLuck = rdmNum.Next(0, 10);

            // If the player is successful
            if ((characterType == "Cop" && fightLuck > 2) || (characterType == "Detective" && fightLuck > 5))
            {
                // Creates the Winner form
                Winner winner = new Winner();

                // Hides the current form
                this.Hide();
                // Shows the Winner form
                winner.Show();
            }
                
            // If the player fails
            else
            {
                // Creates the GameOver form
                GameOver gameOver = new GameOver();

                // Hides the current form
                this.Hide();
                // Shows the GameOver form
                gameOver.Show();
            }                                  
        }

        // Executes if the player runs from the creature
        private void Run_Click(object sender, EventArgs e)
        {
            // Executes if successful
            try
            {

            }
            // Executes if failure
            catch
            {
                MessageBox.Show("Unable to access data.");
            }
            // Creates a reader .txt file
            StreamReader File = new StreamReader("CharacterType.txt");
            // The character type is the first line read in .txt file
            string characterType = File.ReadLine();
            // Closes .txt file
            File.Close();

            // Creates a random number object
            Random rdmNum = new Random();
            // Random number is between 0 and 10
            int runLuck = rdmNum.Next(0, 10);

            // If the player is successful
            if ((characterType == "Cop" && runLuck > 6) || (characterType == "Detective" && runLuck > 3))
            {
                // Creates the Winner form
                Winner winner = new Winner();

                // Hides the current form
                this.Hide();
                // Shows the Winner form
                winner.Show();
            }
                
            // If the player fails
            else
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
}
