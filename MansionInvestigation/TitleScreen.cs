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

namespace MansionInvestigation
{
  
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        // Saves data to .txt file
        private void SaveData_Click(object sender, EventArgs e)
        {
            // If character type is chosen
            if (!String.IsNullOrEmpty(characterType.Text))
            {
                // Creates writer .txt file
                StreamWriter File = new StreamWriter("CharacterType.txt");
                // Writes character's type to file
                File.WriteLine(characterType.Text);
                // Closes .txt file
                File.Close();   
            }
            // If character type is not chosen
            else
            {
                MessageBox.Show("Pick a character type to save.");
            }           
        }

        // If data is valid, moves the player to the MainRoom form
        private void Proceed_Click(object sender, EventArgs e)
        {
            // If the player enters valid data
            // Input fields must contain data with no digits 
            if (!String.IsNullOrEmpty(characterName.Text) && !String.IsNullOrEmpty(characterType.Text) && !characterName.Text.Any(char.IsDigit))
            {
                // Creates the MainRoom form
                MainRoom mainRoom = new MainRoom(characterName.Text, characterType.Text);

                // Hides the current form
                this.Hide();
                // Shows the MainRoom form
                mainRoom.Show();
            }

            // If the player enters invalid data
            else
            {
                MessageBox.Show("Enter a valid name and pick a character type.");
            }
        }
    }
}
