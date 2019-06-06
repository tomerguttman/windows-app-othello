using System;
using System.Collections.Generic;
using System.Text;

namespace GameData
{
    public class OthelloPlayer
    {
        int m_PlayerNumber;
        private char m_Color;
        public const char k_Black = 'X';
        public const char k_White = 'O';

        public OthelloPlayer(int i_PlayerNumber)
        {
            m_PlayerNumber = i_PlayerNumber;
        }

        public int PlayerNumber
        {
            get
            {
                return m_PlayerNumber;
            }

            set
            {
                this.m_PlayerNumber = value;
            }
        }

        public char Color
        {
            get
            {
                return m_Color;
            }

            set
            {
                m_Color = value;
            }
        }

        public string PrintPlayerInfo()
        {
            string o_PlayerInfo = string.Format("{0}", m_Color);

            return o_PlayerInfo;
        }
    }
}
