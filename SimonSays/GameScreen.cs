using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //Define the two sounds to play when the player makes a guess
        SoundPlayer correctGuessSound = new SoundPlayer(Properties.Resources.Correct_Guess);
        SoundPlayer wrongGuessCound = new SoundPlayer(Properties.Resources.Wrong_Guess);

        //The global Random class
        Random random = new Random();

        //Integer variables
        int interval = 1000;
        int patternGuessIndex = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Clear the pattern, wait for 1 second, then call computer turn
            Form1.pattern.Clear();

            Refresh();

            Thread.Sleep(1000);

            ComputerTurn();
        }

        //Calls player turn on each button click with the argument being the button number
        private void Button1_Click(object sender, EventArgs e)
        {
            PlayerTurn(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PlayerTurn(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PlayerTurn(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PlayerTurn(4);
        }

        /// <summary>
        /// A method to add a new item to the pattern list, and flash the corresponding buttons
        /// </summary>
        public void ComputerTurn ()
        {
            Form1.pattern.Add(random.Next(1, 5));

            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                if (Form1.pattern[i] == 1)
                {
                    Button1.BackColor = Color.Red;
                }
                else if (Form1.pattern[i] == 2)
                {
                    Button2.BackColor = Color.Blue;
                }
                else if (Form1.pattern[i] == 3)
                {
                    Button3.BackColor = Color.Green;
                }
                else if (Form1.pattern[i] == 4)
                {
                    Button4.BackColor = Color.Yellow;
                }

                Refresh();
                Thread.Sleep(interval);

                Button1.BackColor = Color.Gainsboro;
                Button2.BackColor = Color.Gainsboro;
                Button3.BackColor = Color.Gainsboro;
                Button4.BackColor = Color.Gainsboro;

                Refresh();
                Thread.Sleep(100);
            }

            patternGuessIndex = 0;
        }

        /// <summary>
        /// Checks the player's button press against the relevant index in the pattern
        /// </summary>
        /// <param name="buttonNumber"></param>
        public void PlayerTurn(int buttonNumber)
        {
            //Checks if the pararmeter buttonNumber is equal to the next item in the pattern
            if (buttonNumber == Form1.pattern[patternGuessIndex])
            {
                //Then light up the appropriate button
                switch (Form1.pattern[patternGuessIndex])
                {
                    case 1:
                        Button1.BackColor = Color.Red;
                        break;
                    case 2:
                        Button2.BackColor = Color.Blue;
                        break;
                    case 3:
                        Button3.BackColor = Color.Green;
                        break;
                    case 4:
                        Button4.BackColor = Color.Yellow;
                        break;
                }

                //Plays the right sound, waits then resets the colors and adds 1 to the guess index
                correctGuessSound.Play();

                Refresh();
                Thread.Sleep(200);

                Button1.BackColor = Color.Gainsboro;
                Button2.BackColor = Color.Gainsboro;
                Button3.BackColor = Color.Gainsboro;
                Button4.BackColor = Color.Gainsboro;

                patternGuessIndex++;

                //If the turn is over then pause and speed up the shown pattern 
                if (patternGuessIndex == Form1.pattern.Count)
                {
                    Refresh();
                    Thread.Sleep(500);

                    if (interval > 100)
                        interval -= 150;
                    else if (interval > 40)
                        interval -= 20;

                    ComputerTurn();
                }
            }
            else
            {
                //Play the wrong sound and show the GameOver screen
                wrongGuessCound.Play();

                Form parentForm = this.FindForm();
                ParentForm.Controls.Add(new GameOverScreen());
                parentForm.Controls.Remove(this);
            }

        }
    }
}
