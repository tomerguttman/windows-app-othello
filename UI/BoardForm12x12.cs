using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class BoardForm12x12 : Form
    {
        public BoardForm12x12()
        {
            InitializeComponent();
        }
        
        void UpdateValidPointsToChooseFrom()
        {
            Bitmap currentRefreshIcon = null;
            List<string> pointsToChangeAvailability =  GameLogic.TurnManager.GetListOfOptionalPointsToChooseParsedToString();

            string turnIndicator = this.Text.ToLower();

            if(turnIndicator.Contains("black"))
            {
                currentRefreshIcon = UI.Properties.Resources.refreshBlue1;

            }
            else ///Contains("white")
            {
                currentRefreshIcon = Properties.Resources.refreshGreen1;
            }

            foreach (string currentPointString in pointsToChangeAvailability)
            {
                PictureBox tempPicBox = (PictureBox)(this.Controls.Find("pictureBox" + currentPointString, true))[0];
                tempPicBox.BackgroundImage = currentRefreshIcon;
                tempPicBox.Enabled = true;
            }
        }

        

        private void PictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
