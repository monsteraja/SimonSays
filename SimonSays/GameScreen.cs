using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        Random random = new Random();

        int interval = 1000;
        int patternGuessIndex = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();

            Refresh();

            Thread.Sleep(1000);

            ComputerTurn();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            PlayerTurn(Button1.TabIndex);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PlayerTurn(Button2.TabIndex);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PlayerTurn(Button3.TabIndex);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PlayerTurn(Button4.TabIndex);
        }

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

        public void PlayerTurn (int buttonNumber)
        {
            if (buttonNumber == Form1.pattern[patternGuessIndex])
            {
                switch(Form1.pattern[patternGuessIndex])
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

                Refresh();
                Thread.Sleep(100);

                Button1.BackColor = Color.Gainsboro;
                Button2.BackColor = Color.Gainsboro;
                Button3.BackColor = Color.Gainsboro;
                Button4.BackColor = Color.Gainsboro;

                patternGuessIndex++;

                if (patternGuessIndex == Form1.pattern.Count)
                {
                    Refresh();
                    Thread.Sleep(100);

                    ComputerTurn();

                    if (interval > 100)
                        interval -= 100;
                }
            }
            else
            {
                Form parentForm = this.FindForm();
                ParentForm.Controls.Add(new GameOverScreen());
                parentForm.Controls.Remove(this);
            }
        }
    }
}
