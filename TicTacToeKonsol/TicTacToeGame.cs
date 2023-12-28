using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeKonsol
{
    public class TicTacToeGame
    {
        public void Run()
        {
            Board board = new Board();
            BoardRenderer renderer = new BoardRenderer();
            Player player1 = new Player(Cell.X);
            Player player2 = new Player(Cell.O);

            int turnNumber = 0;

            Player currentPlayer = player1;

            while (turnNumber < 9) //Efter 9 gånger, om ingen har vunnit då är det "draw".
            {
                renderer.Draw(board);
                Console.WriteLine($"It is {currentPlayer.Symbol}' turn.");
                Square square = currentPlayer.PickSquare(board);
                board.FillCell(square.Row, square.Column, currentPlayer.Symbol);

                //HasWon
                if (HasWon(board, Cell.X))
                {
                    renderer.Draw(board);
                    Console.WriteLine("X Won!");
                    return;
                }
                else if (HasWon(board, Cell.O))
                {
                    renderer.Draw(board);
                    Console.WriteLine("O Won!");
                    return;
                }

                //Ändra spelare
                currentPlayer = currentPlayer == player1 ? player2 : player1;
                turnNumber++;
            }
            renderer.Draw(board);
            Console.WriteLine("Draw!");
        }

        private bool HasWon(Board board, Cell value)
        {
            //Kontrollera rader
            if (board.ContentsOf(0, 0) == value && board.ContentsOf(0, 1) == value && board.ContentsOf(0, 2) == value) return true;
            if (board.ContentsOf(1, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(1, 2) == value) return true;
            if (board.ContentsOf(2, 0) == value && board.ContentsOf(2, 1) == value && board.ContentsOf(2, 2) == value) return true;

            //Kontrollera kolumner
            if (board.ContentsOf(0, 0) == value && board.ContentsOf(1, 0) == value && board.ContentsOf(2, 0) == value) return true;
            if (board.ContentsOf(0, 1) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(2, 1) == value) return true;
            if (board.ContentsOf(0, 2) == value && board.ContentsOf(1, 2) == value && board.ContentsOf(2, 2) == value) return true;
            //Kontrollera diagonaler
            if (board.ContentsOf(0, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(2, 2) == value) return true;
            if (board.ContentsOf(2, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(0, 2) == value) return true;

            return false;
        }
    }
}
