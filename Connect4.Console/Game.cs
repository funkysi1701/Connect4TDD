using System;

namespace Connect4.Console
{
    public class Game
    {
        public int[,] gameArray = new int[7, 7];

        public int player = 1;

        public bool HasWon = false;

        public int GetCellValue(int x, int y)
        {
            return gameArray[x, y];
        }

        public void Move(int column)
        {
            int height = 0;
            UpdateCell(column, height);
            HasWon = CheckHasWon();
            ChangePlayer();
        }

        private bool CheckHasWon()
        {
            for (int i = 0; i < gameArray.GetLength(0); i++)
            {
                for (int j = 0; j < gameArray.GetLength(1)-3; j++)
                {
                    if(gameArray[i,j]>0 && gameArray[i,j]==gameArray[i,j+1] && gameArray[i,j+1]==gameArray[i,j+2] && gameArray[i, j + 2] == gameArray[i, j + 3])
                    {
                        return true;
                    }
                }
            }
            for (int i = 0; i < gameArray.GetLength(0)-3; i++)
            {
                for (int j = 0; j < gameArray.GetLength(1); j++)
                {
                    if (gameArray[i, j] > 0 && gameArray[i, j] == gameArray[i + 1, j] && gameArray[i + 1, j] == gameArray[i + 2, j] && gameArray[i + 2, j] == gameArray[i + 3, j])
                    {
                        return true;
                    }
                }
            }
            for (int i = 0; i < gameArray.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < gameArray.GetLength(1)-3; j++)
                {
                    if (gameArray[i, j] > 0 && gameArray[i, j] == gameArray[i + 1, j+1] && gameArray[i + 1, j+1] == gameArray[i + 2, j+2] && gameArray[i + 2, j+2] == gameArray[i + 3, j+3])
                    {
                        return true;
                    }
                }
            }
            for (int i = gameArray.GetLength(0) - 1; i > 2; i--)
            {
                for (int j = 0; j < gameArray.GetLength(1) - 3; j++)
                {
                    if (gameArray[i, j] > 0 && gameArray[i, j] == gameArray[i - 1, j + 1] && gameArray[i - 1, j + 1] == gameArray[i - 2, j + 2] && gameArray[i - 2, j + 2] == gameArray[i - 3, j + 3])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ChangePlayer()
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
