namespace TicTacToe
{
    using System;

    class Program
    {
        public const string ProductName = "Tic Tac Toe";

        public const string ProductVersion = "0.1.0";

        static void Main(string[] args)
        {
            // setup the players
            char playerX = 'x';
            char playerY = 'y';

            // setup the grid
            char[,] grid = new char[3,3];

            Console.WriteLine("{0} Version {1}", ProductName, ProductVersion);

            // start the game

            Console.Read();
        }
    }
}
