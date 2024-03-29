﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class TurnManager
    {
        private const int k_Increase = 1;
        private const int k_Decrease = -1;
        private const int k_DontMove = 0;
        private const string k_UpdateValidity = "UpdateCellValidity";
        private const string k_ChangeRivalDiscsCellsColor = "ChangeDiscsColor";

        public enum eDirection
        {
            Up,
            UpRight,
            Right,
            DownRight,
            Down,
            DownLeft,
            Left,
            UpLeft,
        }

        public static void OthelloTurnManager(GameData.OthelloBoard io_OthelloBoard, GameData.OthelloPlayer i_Player, ref int io_ConsecutiveNumberOfTurnsWithoutValidMoves)
        {
            GameData.OthelloBoard tempOthelloBoard = new GameData.OthelloBoard(io_OthelloBoard);
            GameData.OthelloBoard.Point playersPointChoice;
            List<GameData.OthelloBoard.Point> validPointsToChooseFrom = new List<GameData.OthelloBoard.Point>();

            if (UpdateValidCells(tempOthelloBoard, i_Player.Color, validPointsToChooseFrom) > 0)
            {
                playersPointChoice = UI.Console.RecievePointFromPlayer(tempOthelloBoard, i_Player, validPointsToChooseFrom);//clicked PictureBox in the form
                playersPointChoice.M_CellValue = i_Player.Color;
                validPointsToChooseFrom.Clear();
                io_OthelloBoard.M_OthelloBoard[playersPointChoice.M_Longtitude - 1, (int)playersPointChoice.M_Latitude - 'A'].M_CellValue = i_Player.Color;
                io_OthelloBoard.M_OthelloBoard[playersPointChoice.M_Longtitude - 1, (int)playersPointChoice.M_Latitude - 'A'].M_IsAvailableCell = false;
                UpdateBoardAfterDiscPlacement(io_OthelloBoard, playersPointChoice);

                if (i_Player.PlayerNumber == 3)
                {
                    System.Threading.Thread.Sleep(2000);
                }

                //UI.Console.PrintBoard(io_OthelloBoard);
                io_ConsecutiveNumberOfTurnsWithoutValidMoves = 0;
            }
            else
            {
                //string message = string.Format("{0} has no optional moves!", i_Player.M_PlayerName);
                //System.Console.WriteLine(message);
                io_ConsecutiveNumberOfTurnsWithoutValidMoves += 1;
            }
        }

        public static int UpdateValidCells(GameData.OthelloBoard io_OthelloBoard, char i_PlayerColor, List<GameData.OthelloBoard.Point> io_ValidPointsToChooseFrom)
        {
            int noValueInt = 0;

            foreach (GameData.OthelloBoard.Point currentPoint in io_OthelloBoard.M_OthelloBoard)
            {
                if (currentPoint.M_CellValue == i_PlayerColor)
                {
                    for (eDirection direction = eDirection.Up; direction <= eDirection.UpLeft; direction++)
                    {
                        EightWayCellsCheckAndUpdateValidityOrChangeCellsColor(io_OthelloBoard, currentPoint, direction, k_UpdateValidity, io_ValidPointsToChooseFrom, ref noValueInt);
                    }
                }
            }

            return io_ValidPointsToChooseFrom.Count;
        }

        public static void EightWayCellsCheckAndUpdateValidityOrChangeCellsColor(GameData.OthelloBoard io_OthelloBoard, GameData.OthelloBoard.Point i_CurrentPoint, eDirection i_Direction, string i_UpdateValidityOrChangeColor, List<GameData.OthelloBoard.Point> io_ValidPointsToChooseFrom, ref int io_NumberOfRivalDiscsToChangeIfNeeded)
        {
            switch (i_Direction)
            {
                case eDirection.Up:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_DontMove, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_DontMove, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_DontMove, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.UpRight:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_Increase, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_Increase, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_Increase, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.Right:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_DontMove, k_Increase, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_DontMove, k_Increase, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_DontMove, k_Increase, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.DownRight:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_Increase, k_Increase, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_Increase, k_Increase, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_Increase, k_Increase, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.Down:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_Increase, k_DontMove, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_Increase, k_DontMove, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_Increase, k_DontMove, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.DownLeft:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_Increase, k_Decrease, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_Increase, k_Decrease, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_Increase, k_Decrease, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.Left:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_DontMove, k_Decrease, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_DontMove, k_Decrease, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_DontMove, k_Decrease, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;

                case eDirection.UpLeft:
                    if (i_UpdateValidityOrChangeColor == k_UpdateValidity)
                    {
                        UpdateCellsValidity(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_Decrease, io_ValidPointsToChooseFrom);
                    }
                    else
                    {
                        if (IsRivalDiscChangeNeeded(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_Decrease, ref io_NumberOfRivalDiscsToChangeIfNeeded))
                        {
                            ChangeDiscsColor(io_OthelloBoard, i_CurrentPoint, k_Decrease, k_Decrease, io_NumberOfRivalDiscsToChangeIfNeeded);
                        }
                    }

                    break;
            }
        }

        public static void UpdateCellsValidity(GameData.OthelloBoard io_OthelloBoard, GameData.OthelloBoard.Point i_CurrentPoint, int i_LongtitudeValue, int i_LatitudeValue, List<GameData.OthelloBoard.Point> io_ValidPointsToChooseFrom)
        {
            int latitude = (i_CurrentPoint.M_Latitude - 'A') + i_LatitudeValue;
            int longtitude = i_CurrentPoint.M_Longtitude - 1 + i_LongtitudeValue;
            bool isPotentialValidPoint = false;

            while (IsPointOnBoardAndRivalDisc(io_OthelloBoard, longtitude, latitude, i_CurrentPoint.M_CellValue) == true)
            {
                longtitude += i_LongtitudeValue;
                latitude += i_LatitudeValue;
                isPotentialValidPoint = true;
            }

            if (latitude >= 0 && latitude < io_OthelloBoard.M_BoardSize && longtitude >= 0 && longtitude < io_OthelloBoard.M_BoardSize && isPotentialValidPoint == true && io_OthelloBoard.M_OthelloBoard[longtitude, latitude].M_CellValue == GameData.OthelloBoard.Point.k_Empty)
            {
                if (io_OthelloBoard.M_OthelloBoard[longtitude, latitude].M_IsAvailableCell == false)
                {
                    io_OthelloBoard.M_OthelloBoard[longtitude, latitude].M_IsAvailableCell = true;
                    io_ValidPointsToChooseFrom.Add(io_OthelloBoard.M_OthelloBoard[longtitude, latitude]);
                }
            }
        }

        public static bool IsPointOnBoardAndRivalDisc(GameData.OthelloBoard i_OthelloBoard, int i_Longtitude, int i_Latitude, char i_PlayerColor)
        {
            return i_Latitude >= 0 && i_Latitude < i_OthelloBoard.M_BoardSize && i_Longtitude >= 0 && i_Longtitude < i_OthelloBoard.M_BoardSize && i_OthelloBoard.M_OthelloBoard[i_Longtitude, i_Latitude].M_CellValue != i_PlayerColor && i_OthelloBoard.M_OthelloBoard[i_Longtitude, i_Latitude].M_CellValue != GameData.OthelloBoard.Point.k_Empty;
        }

        public static bool IsRivalDiscChangeNeeded(GameData.OthelloBoard io_OthelloBoard, GameData.OthelloBoard.Point i_CurrentPoint, int i_LongtitudeValue, int i_LatitudeValue, ref int io_NumberOfRivalDiscsToChange)
        {
            int latitude = (i_CurrentPoint.M_Latitude - 'A') + i_LatitudeValue;
            int longtitude = i_CurrentPoint.M_Longtitude - 1 + i_LongtitudeValue;
            bool isChangeOfDiscsNeeded = false;

            while (IsPointOnBoardAndRivalDisc(io_OthelloBoard, longtitude, latitude, i_CurrentPoint.M_CellValue) == true)
            {
                longtitude += i_LongtitudeValue;
                latitude += i_LatitudeValue;
                io_NumberOfRivalDiscsToChange += 1;
                isChangeOfDiscsNeeded = true;
            }

            if (latitude < 0 || latitude >= io_OthelloBoard.M_BoardSize || longtitude < 0 || longtitude >= io_OthelloBoard.M_BoardSize || isChangeOfDiscsNeeded == false || io_OthelloBoard.M_OthelloBoard[longtitude, latitude].M_CellValue != i_CurrentPoint.M_CellValue)
            {
                isChangeOfDiscsNeeded = false;
                io_NumberOfRivalDiscsToChange = 0;
            }

            return isChangeOfDiscsNeeded;
        }

        internal static void ChangeDiscsColor(GameData.OthelloBoard io_OthelloBoard, GameData.OthelloBoard.Point i_CurrentPoint, int i_LongtitudeVal, int i_LatitudeVal, int i_NumberOfRivalDiscsToChange)
        {
            int startLongtitude = i_CurrentPoint.M_Longtitude - 1;
            int startLatitude = i_CurrentPoint.M_Latitude - 'A';

            for (int i = 1; i <= i_NumberOfRivalDiscsToChange; i++)
            {
                io_OthelloBoard.M_OthelloBoard[startLongtitude + (i * i_LongtitudeVal), startLatitude + (i * i_LatitudeVal)].M_CellValue = i_CurrentPoint.M_CellValue;
            }
        }

        internal static void UpdateBoardAfterDiscPlacement(GameData.OthelloBoard io_OthelloBoard, GameData.OthelloBoard.Point i_UserPointChosen)
        {
            int numberOfDiscsToChange = 0;
            List<GameData.OthelloBoard.Point> emptyList = new List<GameData.OthelloBoard.Point>();

            for (eDirection direction = eDirection.Up; direction <= eDirection.UpLeft; direction++)
            {
                EightWayCellsCheckAndUpdateValidityOrChangeCellsColor(io_OthelloBoard, i_UserPointChosen, direction, k_ChangeRivalDiscsCellsColor, emptyList, ref numberOfDiscsToChange);
                numberOfDiscsToChange = 0;
            }
        }
    }
}
