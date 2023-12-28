namespace TicTacToeKonsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
           new TicTacToeGame().Run();
        }
    }
    public enum Cell { Empty, X, O }
}
