using System;

namespace Connect4.Console
{
    public class Game
    {
        public int[,] gameArray = new int[7, 7];

        public int player = 1;

        public int GetCellValue(int x, int y)
        {
            return gameArray[x, y];
        }

        public void Move(int column)
        {
            int height = 0;
            UpdateCell(column, height);
            ChangePlayer();
        }

        private void ChangePlayer()
        {
            player++;
            if (player == 3) player = 1;
        }

        public void UpdateCell(int x,int y)
        {
            if (CheckifEmpty(x, y))
            {
                gameArray[x, y] = player;
            }
            else
            {
                y++;
                UpdateCell(x, y);
            }
        }

        public bool CheckifEmpty(int x,int y)
        {
            if (GetCellValue(x, y) == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
