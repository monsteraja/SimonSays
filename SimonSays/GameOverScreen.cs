using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            parentForm.Controls.Remove(this);
            parentForm.Controls.Add(new StartScreen());
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            parentForm.Controls.Remove(this);
            parentForm.Controls.Add(new GameScreen());
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            GameOverLabel.Text = "You Successfully Completed " + (Form1.pattern.Count - 1) + " Rounds";
        }
    }
}
