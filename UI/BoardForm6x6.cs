using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FormBoard6x6 : Form
    {
        GameData.OthelloBoard m_OthelloBoard = null;
        GameData.OthelloPlayer[] m_Players = new GameData.OthelloPlayer[2];
        int m_ConsecutiveNumberOfTurnsWithoutValidMoves = 0;
        const int k_BoardSize = 6;

        public FormBoard6x6(int i_NumberOfPlayers)
        {
            m_OthelloBoard = new GameData.OthelloBoard(6);
            m_Players[0] = new GameData.OthelloPlayer(1);
            m_Players[0].Color = GameData.OthelloPlayer.k_Black;

            if (i_NumberOfPlayers == 1)
            {
                m_Players[1] = new GameData.OthelloPlayer(3);
                m_Players[1].Color = GameData.OthelloPlayer.k_White;
            }
            else
            {
                m_Players[1] = new GameData.OthelloPlayer(2);
            }

            InitializeComponent();
        }

        private void BoardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            string currentPlayerString = this.Text.ToLower();
            GameData.OthelloPlayer tempPlayer = null;
            PictureBox tempPictureBox = null;

            if(currentPlayerString.Contains("black"))
            {
                (sender as PictureBox).BackgroundImage = Properties.Resources.CoinYellow1;
                tempPlayer = m_Players[0];
            }
            else
            {
                (sender as PictureBox).BackgroundImage = Properties.Resources.CoinRed1;
                tempPlayer = m_Players[1];
            }

            (sender as PictureBox).Enabled = false;

            GameLogic.TurnManager.OthelloTurnManager(m_OthelloBoard, (sender as PictureBox).Name, tempPlayer, ref m_ConsecutiveNumberOfTurnsWithoutValidMoves);

            if (m_ConsecutiveNumberOfTurnsWithoutValidMoves == 2)
            {
                //end form and winner calculation
            }
            else
            {
                foreach(GameData.OthelloBoard.Point point in m_OthelloBoard.M_OthelloBoard)
                {
                    tempPictureBox = (Controls.Find("pictureBox" + point.ToString(), true)[0] as PictureBox);
                    tempPictureBox.Enabled = false;

                    if (point.M_CellValue == 'X')
                    {
                        tempPictureBox.BackgroundImage = Properties.Resources.CoinYellow1;
                    }
                    else if(point.M_CellValue == 'O')
                    {
                        tempPictureBox.BackgroundImage = Properties.Resources.CoinRed1;
                    }
                    else
                    {
                        tempPictureBox.BackgroundImage = null;
                    }
                }

                if(tempPlayer.Color == 'X')
                {
                    this.Text = "Othello - White's Turn";
                }
                else
                {
                    this.Text = "Othello - Black's Turn";
                }

                UpdateValidPointsToChooseFrom();
            }
        }

        void UpdateValidPointsToChooseFrom()
        {
            Bitmap currentRefreshIcon = null;
            string turnIndicator = this.Text.ToLower();
            char currentPlayerColor = '0';

            if (turnIndicator.Contains("black"))
            {
                currentRefreshIcon = UI.Properties.Resources.refreshBlue;
                currentPlayerColor = m_Players[0].Color;

            }
            else ///Contains("white")
            {
                currentRefreshIcon = Properties.Resources.refreshGreen;
                currentPlayerColor = m_Players[1].Color;
            }

            List<string> pointsToChangeAvailability = GameLogic.TurnManager.GetListOfOptionalPointsToChooseFromParsedToString(m_OthelloBoard, currentPlayerColor);

            foreach (string currentPointString in pointsToChangeAvailability)
            {
                PictureBox tempPicBox = (PictureBox)(this.Controls.Find("pictureBox" + currentPointString, true))[0];
                tempPicBox.BackgroundImage = currentRefreshIcon;
                tempPicBox.Enabled = true;
            }
        } 
    }
}
