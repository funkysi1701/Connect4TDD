namespace Connect4.Console
{
    public class Game
    {
        public int[,] gameArray = new int[7, 7];

        public int GetCellValue(int x, int y)
        {
            return gameArray[x, y];
        }

        public void Move(int column)
        {
            int height = 0;
            UpdateCell(column, height);
        }

        public void UpdateCell(int x,int y)
        {
            if (CheckifEmpty(x, y))
            {
                gameArray[x, y] = 1;
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
