using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class BoardForm10x10 : Form
    {
        GameData.OthelloBoard m_OthelloBoard = null;
        GameData.OthelloPlayer[] m_Players = new GameData.OthelloPlayer[2];
        int m_ConsecutiveNumberOfTurnsWithoutValidMoves = 0;
        int m_AmountOfPlayersPlaying = 0;
        const int k_BoardSize = 10;

        public BoardForm10x10(int i_NumberOfPlayers)
        {
            m_AmountOfPlayersPlaying = i_NumberOfPlayers;
            m_OthelloBoard = new GameData.OthelloBoard(k_BoardSize);
            m_Players[0] = new GameData.OthelloPlayer(1);
            m_Players[0].Color = GameData.OthelloPlayer.k_Black;

            if (i_NumberOfPlayers == 1)
            {
                m_Players[1] = new GameData.OthelloPlayer(3);

            }
            else
            {
                m_Players[1] = new GameData.OthelloPlayer(2);
            }

            m_Players[1].Color = GameData.OthelloPlayer.k_White;
            InitializeComponent();
        }

        public GameData.OthelloBoard OthelloBoard
        {
            get
            {
                return m_OthelloBoard;
            }
        }

        private void BoardForm_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            char currentPlayerColor = GetCurrentPlayerColorFromFormText();
            GameData.OthelloPlayer currentPlayer = GetCurrentPlayer(currentPlayerColor);

            GameLogic.TurnManager.OthelloTurnManager(m_OthelloBoard, (sender as PictureBox).Name, currentPlayer);

            UpdateFormAfterPlacement();
            SwitchFormTextToNextPlayer(ref currentPlayerColor);
            UpdateFormValidPointsToChooseFrom(currentPlayerColor);
        }

        private void UpdateFormAfterPlacement()
        {
            PictureBox currentPictureBox = null;

            foreach (GameData.OthelloBoard.Point currentPoint in m_OthelloBoard.M_OthelloBoard)
            {
                currentPictureBox = (Controls.Find("pictureBox" + currentPoint.ToString(), true)[0] as PictureBox);
                currentPictureBox.Enabled = false;

                if (currentPoint.M_CellValue == GameData.OthelloBoard.Point.k_Black)
                {
                    currentPictureBox.BackgroundImage = Properties.Resources.CoinYellow1;
                }
                else if (currentPoint.M_CellValue == GameData.OthelloBoard.Point.k_White)
                {
                    currentPictureBox.BackgroundImage = Properties.Resources.CoinRed1;
                }
                else
                {
                    currentPictureBox.BackgroundImage = null;
                }
            }
        }

        private GameData.OthelloPlayer GetCurrentPlayer(char i_CurrentPlayerColor)
        {
            GameData.OthelloPlayer currentPlayer = null;
            if (i_CurrentPlayerColor == GameData.OthelloPlayer.k_Black)
            {
                currentPlayer = m_Players[0];
            }
            else
            {
                currentPlayer = m_Players[1];
            }
            return currentPlayer;
        }

        private void SwitchFormTextToNextPlayer(ref char io_CurrentPlayerColor)
        {
            if (io_CurrentPlayerColor == GameData.OthelloPlayer.k_Black)
            {
                this.Text = "Othello - White's turn";
                io_CurrentPlayerColor = GameData.OthelloPlayer.k_White;
            }
            else
            {
                this.Text = "Othello - Black's turn";
                io_CurrentPlayerColor = GameData.OthelloPlayer.k_Black;
            }
        }

        private char GetCurrentPlayerColorFromFormText()
        {
            char o_CurrentPlayerColor = '\0';
            if (this.Text.ToLower().Contains("black"))
            {
                o_CurrentPlayerColor = GameData.OthelloPlayer.k_Black;
            }
            else
            {
                o_CurrentPlayerColor = GameData.OthelloPlayer.k_White;
            }

            return o_CurrentPlayerColor;
        }

        void UpdateFormValidPointsToChooseFrom(char i_PlayerColor)
        {
            List<string> computerOptionalMoves = null;
            Bitmap currentPlayerRefreshIcon = GetPlayerRefreshIcon(i_PlayerColor);
            List<string> currentPlayerOptionalActionsOnFormBoard = GameLogic.TurnManager.GetListOfOptionalPointsToChooseFromParsedToString(m_OthelloBoard, i_PlayerColor);
            PictureBox currentPictureBox = null;

            if (currentPlayerOptionalActionsOnFormBoard.Count > 0)
            {
                foreach (string currentPictureBoxName in currentPlayerOptionalActionsOnFormBoard)
                {
                    currentPictureBox = (Controls.Find("pictureBox" + currentPictureBoxName, true)[0] as PictureBox);
                    currentPictureBox.BackgroundImage = currentPlayerRefreshIcon;
                    currentPictureBox.Enabled = true;
                }

                m_ConsecutiveNumberOfTurnsWithoutValidMoves = 0;

                if (IsComputerTurn(i_PlayerColor))
                {
                    string computerChosenPictureBoxName = null;
                    computerOptionalMoves = GameLogic.TurnManager.GetListOfOptionalPointsToChooseFromParsedToString(m_OthelloBoard, GameData.OthelloPlayer.k_White);

                    if (computerOptionalMoves.Count > 0)
                    {
                        computerChosenPictureBoxName = computerOptionalMoves[new Random().Next(0, computerOptionalMoves.Count)];
                        //GameLogic.TurnManager.OthelloTurnManager(m_OthelloBoard, "pictureBox" + computerChosenPictureBoxName, m_Players[1]);
                    }

                    PictureBox_Click((Controls.Find("pictureBox" + computerChosenPictureBoxName, true)[0] as PictureBox), new EventArgs());

                }
            }
            else
            {
                m_ConsecutiveNumberOfTurnsWithoutValidMoves += 1; //need to be checked!

                if (m_ConsecutiveNumberOfTurnsWithoutValidMoves == 2)
                {
                    this.Refresh();
                    EndGame();
                }
                else
                {
                    SwitchFormTextToNextPlayer(ref i_PlayerColor);
                    UpdateFormValidPointsToChooseFrom(i_PlayerColor);
                }
            }
        }

        private void EndGame()
        {
            ButtonGameOver_Click(ButtonGameOver, new EventArgs());
        }

        private bool IsComputerTurn(char i_PlayerColor)
        {
            return m_AmountOfPlayersPlaying == 1 && i_PlayerColor == GameData.OthelloPlayer.k_White;
        }

        private Bitmap GetPlayerRefreshIcon(char i_PlayerColor)
        {
            Bitmap currentPlayerRefreshIcon = null;
            if (i_PlayerColor == GameData.OthelloPlayer.k_Black)
            {
                currentPlayerRefreshIcon = Properties.Resources.refreshBlue;
            }
            else
            {
                currentPlayerRefreshIcon = Properties.Resources.refreshGreen;
            }

            return currentPlayerRefreshIcon;
        }

        private void ButtonGameOver_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
