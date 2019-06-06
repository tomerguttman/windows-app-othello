//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Windows.Forms;
//using System.Drawing;

//namespace UI
//{
//    public class BoardFormManager : Form
//    {
//        void UpdateValidPointsToChooseFrom()
//        {
//            Bitmap currentRefreshIcon = null;
//            List<string> pointsToChangeAvailability = GameLogic.TurnManager.GetListOfOptionalPointsToChooseFromParsedToString();

//            string turnIndicator = this.Text.ToLower();

//            if (turnIndicator.Contains("black"))
//            {
//                currentRefreshIcon = UI.Properties.Resources.refreshBlue;

//            }
//            else ///Contains("white")
//            {
//                currentRefreshIcon = Properties.Resources.refreshGreen;
//            }

//            foreach (string currentPointString in pointsToChangeAvailability)
//            {
//                PictureBox tempPicBox = (PictureBox)(this.Controls.Find("pictureBox" + currentPointString, true))[0];
//                tempPicBox.BackgroundImage = currentRefreshIcon;
//                tempPicBox.Enabled = true;
//            }
//        }
//    }
//}
