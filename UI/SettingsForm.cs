using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameData;

namespace UI
{
    public partial class SettingsForm : Form
    {
        int m_BoardSize = 6;
        int m_NumberOfPlayers = 0;

        public SettingsForm()
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
            m_NumberOfPlayers = 1;
        }

        private void ButtonAgainstFriend_Click(object sender, EventArgs e)
        {
            m_NumberOfPlayers = 2;
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

        public int NumberOfPlayers
        {
            get
            {
                return m_NumberOfPlayers;
            }
            set
            {
                this.m_NumberOfPlayers = value;
            }
        }
    }
}
