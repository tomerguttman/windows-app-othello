using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            RunGame();
        }


        public static void RunGame()
        {
            int boardSize = 0;
            int numberOfPlayers = 0;

            InitializeGame(out boardSize, out numberOfPlayers);
            Form othelloForm = ReturnFormInSizeChosen(boardSize, numberOfPlayers);

            othelloForm.ShowDialog();

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
                    //o_ReturnForm = new BoardForm8x8(i_numberOfPlayers);  ///need to update ctor
                    break;

                case 10:
                    //o_ReturnForm = new BoardForm10x10(i_numberOfPlayers);  ///need to update ctor
                    break;

                case 12:
                    //o_ReturnForm = new BoardForm12x12(i_numberOfPlayers);   ///need to update ctor
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
