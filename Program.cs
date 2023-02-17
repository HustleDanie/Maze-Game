using System;

class MazeGame
{
    static void Main(string[] args)
    {
        char[,] maze = {
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#'},
            {'#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#'},
            {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
            {'#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#'},
            {'#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', ' ', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            {'#', '#', '#', '#', '#', ' ', '#', '#', ' ', '#'},
            {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
        };

        int playerRow = 1; // Starting row for the player
        int playerCol = 1; // Starting column for the player

        while (true)
        {
            // Print the current state of the maze
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (row == playerRow && col == playerCol)
                    {
                        Console.Write('P'); // Print the player character
                    }
                    else
                    {
                        Console.Write(maze[row, col]);
                    }
                }
                Console.WriteLine();
            }

            // Check if the player has reached the end of the maze
            if (playerRow == maze.GetLength(0) - 2 && playerCol == maze.GetLength(1) - 2)
            {
                Console.WriteLine("Congratulations, you reached the end of the maze!");
                return; // End the game
            }

            // Get the player's next move
            Console.Write("Enter a direction (up/down/left/right): ");
            string input = Console.ReadLine().ToLower();

            // Move the player in the specified direction if possible
            int newRow = playerRow;
            int newCol = playerCol;
            if (input == "up" && maze[playerRow - 1, playerCol] != '#')
            {
                newRow--;
            }
            else if (input == "down" && maze[playerRow + 1, playerCol] != '#')
            {
                newRow++;
            }
            else if (input == "left" && maze[playerRow, playerCol - 1] != '#')
            {
                newCol--;
            }
            else if (input == "right" && maze[playerRow, playerCol + 1] != '#')
            {
                newCol++;
            }

            // Update the player's position
            playerRow = newRow;
            playerCol = newCol;
        }
    }
}
