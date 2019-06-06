//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace GameLogic
//{
//    class GameManager
//    {
//        public static void Run(int i_BoardSize)
//        {
//            int turnIndicator = 0;
//            int consecutiveNumberOfTurnsWithoutValidMoves = 0;
//            int player1NumberOfDiscs = 0;
//            int player2NumberOfDiscs = 0;
//            bool anotherGame = true;

//            GameData.OthelloPlayer[] players = new GameData.OthelloPlayer[2];
//            //int boardSize = UI.Console.RecieveInputFromUser(players);
//            //UI.Console.ClearScreen();

//            while (anotherGame == true)
//            {
//                GameData.OthelloBoard board = new GameData.OthelloBoard(i_BoardSize); //clicked at the beginning
//                consecutiveNumberOfTurnsWithoutValidMoves = 0;

//                while (consecutiveNumberOfTurnsWithoutValidMoves != 2)
//                {
//                    TurnManager.OthelloTurnManager(board, players[turnIndicator % 2], ref consecutiveNumberOfTurnsWithoutValidMoves);
//                    turnIndicator += 1;
//                }

//                board.CountNumberOfDiscsForBothPlayers(ref player1NumberOfDiscs, ref player2NumberOfDiscs);
//                System.Threading.Thread.Sleep(1500);
//                //UI.Console.PrintFinalScore(players[0], players[1], player1NumberOfDiscs, player2NumberOfDiscs); //new form.
//                //anotherGame = UI.Console.AskIfPlayAgain();
//                System.Threading.Thread.Sleep(2000);
//            }

//            // UI.Console.ExitSequence();
//        }
//    }
//}
