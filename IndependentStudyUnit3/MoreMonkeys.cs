using System;
using System.Windows.Forms;

namespace IndependentStudyUnit3
{
    public partial class MoreMonkeys : Form
    {
        private int x;
        private int y;

        private int hits, misses;

        private Random generator = new Random();

        public MoreMonkeys()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            gameTimer2.Start();
            gameTimer3.Start();
            gameTimer4.Start();
            gameTimer5.Start();

            hits = 0;
            misses = 0;
            DisplayResults();
        }

        private void DisplayResults()
        {
            hitsLabel.Text = hits.ToString("Hits = 0");
            missLabel.Text = misses.ToString("Miss = 0");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameTimer2.Stop();
            gameTimer3.Stop();
            gameTimer4.Stop();
            gameTimer5.Stop();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// If any of the the Picture boxes is clicked then the monkey has 
        /// been hit 
        /// </summary>
        private void HitMonkey(object sender, EventArgs e)
        {
            if (gameTimer.Enabled || gameTimer2.Enabled || gameTimer3.Enabled || gameTimer4.Enabled || gameTimer5.Enabled)
            {
                hits++;
                DisplayResults();
            }
        }

        /// <summary>
        /// Mouse Down to GetXY
        /// Get x and y coordinates of the mouse when down
        /// on the PictureBox
        /// </summary>
        private void GetXY(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            xyLabel.Text = String.Format("XY = ({0},{1})", x, y);
        }

        /// <summary>
        /// If the panel is clicked on then the player has missed
        /// the monkey (Panel.Click)
        /// </summary>
        private void MissMonkey(object sender, EventArgs e)
        {
            if (gameTimer.Enabled || gameTimer2.Enabled || gameTimer3.Enabled || gameTimer4.Enabled || gameTimer5.Enabled)
            {
                misses++;
                DisplayResults();
            }
        }

        /// <summary>
        /// This method sets an interval of 2000
        /// for pictureBox1
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox1.Width);
            y = generator.Next(gamePanel.Height - pictureBox1.Height);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            Refresh();
        }

        /// <summary>
        /// This method sets an interval of 4000
        /// for pictureBox2
        /// </summary>
        private void gameTimer_Tick2(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox2.Width);
            y = generator.Next(gamePanel.Height - pictureBox2.Height);

            pictureBox2.Left = x;
            pictureBox2.Top = y;

            Refresh();
        }

        /// <summary>
        /// This method sets an interval of 6000
        /// for pictureBox3
        /// </summary>
        private void gameTimer_Tick3(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox3.Width);
            y = generator.Next(gamePanel.Height - pictureBox3.Height);

            pictureBox3.Left = x;
            pictureBox3.Top = y;

            Refresh();
        }

        /// <summary>
        /// This method sets an interval of 8000
        /// for pictureBox4
        /// </summary>
        private void gameTimer_Tick4(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox4.Width);
            y = generator.Next(gamePanel.Height - pictureBox4.Height);

            pictureBox4.Left = x;
            pictureBox4.Top = y;

            Refresh();
        }

        /// <summary>
        /// This method sets an interval of 10000
        /// for pictureBox5
        /// </summary>
        private void gameTimer_Tick5(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - pictureBox5.Width);
            y = generator.Next(gamePanel.Height - pictureBox5.Height);

            pictureBox5.Left = x;
            pictureBox5.Top = y;

            Refresh();
        }
    }
}