using System;
using System.Windows.Forms;

namespace IndependentStudyUnit3
{
    public partial class HitTheTarget : Form
    {
        private int x;
        private int y;

        private int hits;

        private double distance = 0;
        
        private double xValue;
        private double yValue;
        private double powerValue= 0;

        private int score;

        private Random generator = new Random();

        public HitTheTarget()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }
        
        private void stopButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// If the Picture box is clicked then the monkey has 
        /// been hit 
        /// </summary>
        private void HitTarget(object sender, EventArgs e)
        {
            if (gameTimer.Enabled)
            {
                hits++;
            }
        }
        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox1.Width);
            y = generator.Next(gamePanel.Height - pictureBox1.Height);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            Refresh();
        }

        /// <summary>
        /// This method will calculate the distance from the target centre
        /// by getting x and y coordinates of the mouse when down on the PictureBox.
        /// It will also show a message with the exact distance in the messageLabel.
        /// </summary>
        private void CalculateDistance(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            xValue = x - 50;
            yValue = y - 50;

            powerValue = Math.Pow(xValue, 2) + Math.Pow(yValue, 2);

            distance = Math.Sqrt(powerValue);

            messageLabel.Text = String.Format("You are ({0}) away from the target centre!", distance);

            ShowScore();
        }

        /// <summary>
        /// This method will show the score according to the distance
        /// the mouse click location is from the target centre
        /// </summary>
        private void ShowScore()
        {
            score = 0;

            if (distance <= 10)
            {
                score += 10;
            }
            else if (distance > 10 && distance <= 50)
            {
                score += 5;
            }
            else
            {
                score += 1;
            }

            scoreLabel.Text = score.ToString("Score = 0");
        }
    }
}