using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameData;

namespace UI
{
    public partial class Form1 : Form
    {
        public int m_BoardSize = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBoardSize_Click(object sender, EventArgs e)
        {
            if (m_BoardSize == 12)
            {
                m_BoardSize = 6;
            }
            else
            {
                m_BoardSize += 2;
            }

            (sender as Button).Text = string.Format("Board size: {0}x{0} (click to increase)",m_BoardSize);
        }

        private void AgainstPc_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAgainstFriend_Click(object sender, EventArgs e)
        {
            //build othello board with m_BoardSize.
            //method to start the game.
        }

        public int BoardSize
        {
            get
            {
                return m_BoardSize;
            }
            set
            {
                this.m_BoardSize = value;
            }
        }
    }
}
