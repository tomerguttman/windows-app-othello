using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameData;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>ss
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Othello();
        }

        public static void Othello()
        {
            RunGame();
        }

        public static void RunGame()
        {
            int boardSize = 0;
            int numberOfPlayers = 0;
            string gameOverMessage = null;
            int numOfWinsBlack = 0;
            int numOfWinsWhite = 0;

            InitializeGame(out boardSize, out numberOfPlayers);

            STARTGAME:
            Form othelloForm = ReturnFormInSizeChosen(boardSize, numberOfPlayers);

            othelloForm.ShowDialog();
            gameOverMessage = GetGameOverMessage(GetOthelloBoard(othelloForm), ref numOfWinsBlack, ref numOfWinsWhite);
            EndOthelloForm endForm = new EndOthelloForm();
            endForm.Controls.Find("LabelGameRes", true)[0].Text = gameOverMessage;
            if (endForm.ShowDialog() == DialogResult.OK)
            {
                goto STARTGAME;
            }
        }

        private static OthelloBoard GetOthelloBoard(Form i_OthelloForm)
        {
            GameData.OthelloBoard returnOthelloBoard = null;
            if(i_OthelloForm is FormBoard6x6)
            {
                returnOthelloBoard = (i_OthelloForm as FormBoard6x6).OthelloBoard;
            }
            if (i_OthelloForm is BoardForm8x8)
            {
                returnOthelloBoard = (i_OthelloForm as BoardForm8x8).OthelloBoard;
            }

            if (i_OthelloForm is BoardForm10x10)
            {
                returnOthelloBoard = (i_OthelloForm as BoardForm10x10).OthelloBoard;
            }

            if (i_OthelloForm is BoardForm12x12)
            {
                returnOthelloBoard = (i_OthelloForm as BoardForm12x12).OthelloBoard;
            }

            return returnOthelloBoard;
        }

        private static string GetGameOverMessage(OthelloBoard i_OthelloBoard, ref int io_NumOfWinsBlack, ref int io_NumOfWinsWhite)
        {
            string returnGameOverMessage = null;
            int numOfBlackDiscs = 0;
            int numOfWhiteDiscs = 0;

            foreach(GameData.OthelloBoard.Point currentPoint in i_OthelloBoard.M_OthelloBoard)
            {
                if (currentPoint.M_CellValue == GameData.OthelloBoard.Point.k_Black)
                {
                    numOfBlackDiscs += 1;
                }
                else if (currentPoint.M_CellValue == GameData.OthelloBoard.Point.k_White)
                {
                    numOfWhiteDiscs += 1;
                }
            }

            if (numOfBlackDiscs > numOfWhiteDiscs)
            {
                io_NumOfWinsBlack += 1;
                returnGameOverMessage = string.Format("Black Won!! ({0}/{1}) ({2}/{3})", numOfBlackDiscs, numOfWhiteDiscs, io_NumOfWinsBlack, (io_NumOfWinsBlack + io_NumOfWinsWhite));
            }
            else if (numOfBlackDiscs < numOfWhiteDiscs)
            {
                io_NumOfWinsWhite += 1;
                returnGameOverMessage = string.Format("White Won!! ({0}/{1}) ({2}/{3})", numOfWhiteDiscs, numOfBlackDiscs, io_NumOfWinsWhite, (io_NumOfWinsBlack + io_NumOfWinsWhite));
            }
            else
            {
                returnGameOverMessage = string.Format("It's a Tie!! ({0}/{1})", numOfBlackDiscs, numOfWhiteDiscs);
            }

            return returnGameOverMessage;

        }

        private static Form ReturnFormInSizeChosen(int i_BoardSize, int i_numberOfPlayers)
        {
            Form o_ReturnForm = null;

            switch(i_BoardSize)
            {
                case 6:
                    o_ReturnForm = new FormBoard6x6(i_numberOfPlayers);
                    break;

                case 8:
                    o_ReturnForm = new BoardForm8x8(i_numberOfPlayers);  ///need to update ctor
                    break;

                case 10:
                    o_ReturnForm = new BoardForm10x10(i_numberOfPlayers);  ///need to update ctor
                    break;

                case 12:
                    o_ReturnForm = new BoardForm12x12(i_numberOfPlayers);   ///need to update ctor
                    break;
            }

            return o_ReturnForm;
        }

        public static void InitializeGame(out int o_MyOthelloBoardSize, out int o_NumberOfPlayers)
        {
            o_MyOthelloBoardSize = 0;
            o_NumberOfPlayers = 0;
            SettingsForm othelloSettingsForm = new SettingsForm();

            if(othelloSettingsForm.ShowDialog() == DialogResult.OK)
            {
                o_MyOthelloBoardSize = othelloSettingsForm.BoardSize;
                o_NumberOfPlayers = othelloSettingsForm.NumberOfPlayers;
            }
        }
    }
}
