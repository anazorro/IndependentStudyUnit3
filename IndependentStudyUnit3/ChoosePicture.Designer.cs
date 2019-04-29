namespace IndependentStudyUnit3
{
    partial class ChoosePicture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choiceComboBox = new System.Windows.Forms.ComboBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceComboBox
            // 
            this.choiceComboBox.FormattingEnabled = true;
            this.choiceComboBox.Items.AddRange(new object[] {
            "Alsor",
            "Big",
            "Kasijas",
            "Luminous",
            "Tau",
            "Vence"});
            this.choiceComboBox.Location = new System.Drawing.Point(12, 42);
            this.choiceComboBox.Name = "choiceComboBox";
            this.choiceComboBox.Size = new System.Drawing.Size(248, 28);
            this.choiceComboBox.TabIndex = 0;
            this.choiceComboBox.Text = "Choose Here";
            this.choiceComboBox.SelectedIndexChanged += new System.EventHandler(this.choiceComboBox_SelectedIndexChanged);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(461, 283);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(90, 33);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // choicePictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(302, 42);
            this.pictureBox.Name = "choicePictureBox";
            this.pictureBox.Size = new System.Drawing.Size(249, 207);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // ChoosePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 328);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.choiceComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosePicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a Monster";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox choiceComboBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button quitButton;
    }
}