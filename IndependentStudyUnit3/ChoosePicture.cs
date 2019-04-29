using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndependentStudyUnit3
{
    public partial class ChoosePicture : Form
    {
        /// <summary>
        /// This method initializes the form.
        /// </summary>
        public ChoosePicture()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will show a gif in the pictureBox according to the selection
        /// made in the choiceComboBox.
        /// </summary>
        private void choiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choiceComboBox.SelectedIndex)
            {
                case 0:
                        pictureBox.Show();
                        pictureBox.Image = Image.FromFile("Alsor.gif"); break;
                case 1:
                        pictureBox.Show();
                        pictureBox.Image = Image.FromFile("Big.gif"); break;
                case 2:
                        pictureBox.Show();
                        pictureBox.Image = Image.FromFile("Kasijas.gif"); break;
                case 3:
                        pictureBox.Show();
                        pictureBox.Image = Image.FromFile("Luminous.gif"); break;
                case 4:
                        pictureBox.Show();
                        pictureBox.Image = Image.FromFile("Tau.gif"); break;
                case 5:
                        pictureBox.Show();
                        pictureBox.Image = Image.FromFile("Vence.gif"); break;
            }
            
        }

        /// <summary>
        /// Thi method exits the form when the quitButton is clicked.
        /// </summary>
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}