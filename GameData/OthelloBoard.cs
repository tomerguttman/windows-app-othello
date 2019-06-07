using System;
using System.Collections.Generic;
using System.Text;

namespace GameData
{
    public class OthelloBoard
    {
        private int m_BoardSize;
        private Point[,] m_OthelloBoard;

        public static bool IsValidDiscPlacement(OthelloBoard i_OthelloBoard, int i_Longtitude, char i_Latitude, OthelloPlayer i_Player)
        {
            return i_OthelloBoard.M_OthelloBoard[i_Longtitude - 1, i_Latitude - 'A'].M_IsAvailableCell == true;
        }

        public OthelloBoard(OthelloBoard i_Board)
        {
            m_BoardSize = i_Board.M_BoardSize;
            m_OthelloBoard = new Point[m_BoardSize, m_BoardSize];

            char maxBoardLatitude = (char)('A' + m_BoardSize);

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (char c = 'A'; c < maxBoardLatitude; c++)
                {
                    m_OthelloBoard[i, (int)(c - 'A')] = new Point(i + 1, c, i_Board.m_OthelloBoard[i, (int)(c - 'A')].M_CellValue);
                }
            }
        }

        public int M_BoardSize
        {
            get
            {
                return m_BoardSize;
            }

            set
            {
                m_BoardSize = value;
            }
        }

        public Point[,] M_OthelloBoard
        {
            get
            {
                return m_OthelloBoard;
            }

            set
            {
                m_OthelloBoard = value;
            }
        }

        public OthelloBoard(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            m_OthelloBoard = new Point[m_BoardSize, m_BoardSize];

            char maxBoardLatitude = (char)('A' + m_BoardSize);

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (char c = 'A'; c < maxBoardLatitude; c++)
                {
                    m_OthelloBoard[i, (c - 'A')] = new Point(i + 1, c, Point.k_Empty);
                }
            }

            InitializeBoard();
        }

        public void InitializeBoard()
        {
            if (m_BoardSize == 8)
            {
                m_OthelloBoard[3, 3].M_CellValue = Point.k_White;
                m_OthelloBoard[3, 4].M_CellValue = Point.k_Black;
                m_OthelloBoard[4, 3].M_CellValue = Point.k_Black;
                m_OthelloBoard[4, 4].M_CellValue = Point.k_White;

                m_OthelloBoard[3, 3].M_IsAvailableCell = false;
                m_OthelloBoard[3, 4].M_IsAvailableCell = false;
                m_OthelloBoard[4, 3].M_IsAvailableCell = false;
                m_OthelloBoard[4, 4].M_IsAvailableCell = false;
            }
            else if (m_BoardSize == 6)
            {
                m_OthelloBoard[2, 2].M_CellValue = Point.k_White;
                m_OthelloBoard[2, 3].M_CellValue = Point.k_Black;
                m_OthelloBoard[3, 2].M_CellValue = Point.k_Black;
                m_OthelloBoard[3, 3].M_CellValue = Point.k_White;

                m_OthelloBoard[2, 2].M_IsAvailableCell = false;
                m_OthelloBoard[2, 3].M_IsAvailableCell = false;
                m_OthelloBoard[3, 2].M_IsAvailableCell = false;
                m_OthelloBoard[3, 3].M_IsAvailableCell = false;
            }
            else if (m_BoardSize == 10)
            {
                m_OthelloBoard[4, 4].M_CellValue = Point.k_White;
                m_OthelloBoard[4, 5].M_CellValue = Point.k_Black;
                m_OthelloBoard[5, 4].M_CellValue = Point.k_Black;
                m_OthelloBoard[5, 5].M_CellValue = Point.k_White;

                m_OthelloBoard[4, 4].M_IsAvailableCell = false;
                m_OthelloBoard[4, 5].M_IsAvailableCell = false;
                m_OthelloBoard[5, 4].M_IsAvailableCell = false;
                m_OthelloBoard[5, 5].M_IsAvailableCell = false;
            }
            else if (m_BoardSize == 12)
            {
                m_OthelloBoard[5, 5].M_CellValue = Point.k_White;
                m_OthelloBoard[5, 6].M_CellValue = Point.k_Black;
                m_OthelloBoard[6, 5].M_CellValue = Point.k_Black;
                m_OthelloBoard[6, 6].M_CellValue = Point.k_White;

                m_OthelloBoard[5, 5].M_IsAvailableCell = false;
                m_OthelloBoard[5, 6].M_IsAvailableCell = false;
                m_OthelloBoard[6, 5].M_IsAvailableCell = false;
                m_OthelloBoard[6, 6].M_IsAvailableCell = false;
            }
        }

        public void CountNumberOfDiscsForBothPlayers(ref int io_Player1NumberOfDiscs, ref int io_Player2NumberOfDiscs)
        {
            foreach (OthelloBoard.Point currentPoint in m_OthelloBoard)
            {
                if (currentPoint.M_CellValue == Point.k_Black)
                {
                    io_Player1NumberOfDiscs += 1;
                }
                else if (currentPoint.M_CellValue == Point.k_White)
                {
                    io_Player2NumberOfDiscs += 1;
                }
            }
        }

        public class Point
        {
            private bool m_IsAvailableCell = false;
            private int m_Longtitude;
            private char m_Latitude;
            private char m_CellValue;
            public const char k_Black = 'X';
            public const char k_White = 'O';
            public const char k_Empty = ' ';

            public static Point ToPoint(string i_PointName)
            {
                Point returnPoint = new Point(0, '\0', '\0');
                int i;
                int strLength = i_PointName.Length;

                for (i = 10; i < strLength; i++)
                {
                    if (char.IsDigit(i_PointName[i]))
                    {
                        returnPoint.M_Longtitude *= 10;
                        returnPoint.M_Longtitude += int.Parse(i_PointName[i].ToString());
                    }
                    else
                    {
                        returnPoint.M_Latitude = i_PointName[i];
                    }
                }

                return returnPoint;
            }

            public Point(int i_Longtitude, char i_Latitude, char i_CellValue)
            {
                m_Longtitude = i_Longtitude;
                m_Latitude = i_Latitude;
                m_CellValue = i_CellValue;
            }

            public int M_Longtitude
            {
                get
                {
                    return m_Longtitude;
                }

                set
                {
                    m_Longtitude = value;
                }
            }

            public char M_Latitude
            {
                get
                {
                    return m_Latitude;
                }

                set
                {
                    m_Latitude = value;
                }
            }

            public char M_CellValue
            {
                get
                {
                    return m_CellValue;
                }

                set
                {
                    m_CellValue = value;
                }
            }

            public bool M_IsAvailableCell
            {
                get
                {
                    return m_IsAvailableCell;
                }

                set
                {
                    m_IsAvailableCell = value;
                }
            }

            public override string ToString()
            {
                string o_PointInString = null;
                o_PointInString += this.m_Longtitude.ToString();
                o_PointInString += this.m_Latitude.ToString();
                return o_PointInString;
            }
        }
    }
}
