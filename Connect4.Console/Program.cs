namespace Connect4.Console
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Game
    {
        public int [,] gameArray = new int[7,7];

        public int GetCellValue(int x,int y)
        {
            return gameArray[x,y];
        }
    }
}
