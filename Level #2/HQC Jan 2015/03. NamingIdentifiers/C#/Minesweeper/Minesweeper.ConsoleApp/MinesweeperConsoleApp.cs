using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.ConsoleApp
{
    public class Minesweeper
    {
        public class FinalScore
        {
            private string playerName;
            private int score;

            public string player
            {
                get
                {
                    return playerName;
                }

                set
                {
                    playerName = value;
                }
            }

            public int scoreSquereCount
            {
                get
                {
                    return score;
                }

                set
                {
                    score = value;
                }
            }

            public FinalScore()
            {
            }

            public FinalScore(string playerName, int score)
            {
                this.playerName = playerName;
                this.score = score;
            }
        }

        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = createGameField();
            char[,] bombs = placeBombs();
            int squereCount = 0;
            bool isFinalGame = false;
            List<FinalScore> topPlayers = new List<FinalScore>(6);
            int row = 0;
            int col = 0;
            bool isStartGame = true;
            const int Max = 35;
            bool isFinishGame = false;

            do
            {
                if (isStartGame)
                {
                    Console.WriteLine(
                        "Start new game please write \"restart\" in console.\n Top players please \"top\" in Console. For end game please \"exit\" in Console");
                    print(field);
                    isStartGame = false;
                }

                Console.Write("Set your row and col: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        printTopPlayers(topPlayers);
                        break;
                    case "restart":
                        field = createGameField();
                        bombs = placeBombs();
                        print(field);
                        isFinalGame = false;
                        isStartGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                yourTurn(field, bombs, row, col);
                                squereCount++;
                            }

                            if (Max == squereCount)
                            {
                                isFinishGame = true;
                            }
                            else
                            {
                                print(field);
                            }
                        }
                        else
                        {
                            isFinalGame = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Please corowect command");
                        break;
                }

                if (isFinalGame)
                {
                    print(bombs);
                    Console.Write("\n Game over! Score:{0} " + "Enter your name: ", squereCount);
                    string playerName = Console.ReadLine();
                    FinalScore finalScore = new FinalScore(playerName, squereCount);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(finalScore);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].scoreSquereCount < finalScore.scoreSquereCount)
                            {
                                topPlayers.Insert(i, finalScore);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((FinalScore row1, FinalScore row2) => row2.player.CompareTo(row1.player));
                    topPlayers.Sort((FinalScore row1, FinalScore row2) => row2.scoreSquereCount.CompareTo(row1.scoreSquereCount));
                    printTopPlayers(topPlayers);

                    field = createGameField();
                    bombs = placeBombs();
                    squereCount = 0;
                    isFinalGame = false;
                    isStartGame = true;
                }

                if (isFinishGame)
                {
                    Console.WriteLine("Congratulations");
                    print(bombs);
                    Console.WriteLine("Please enter your name: ");
                    string playerName = Console.ReadLine();
                    FinalScore finalScore = new FinalScore(playerName, squereCount);
                    topPlayers.Add(finalScore);
                    printTopPlayers(topPlayers);
                    field = createGameField();
                    bombs = placeBombs();
                    squereCount = 0;
                    isFinishGame = false;
                    isStartGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Created by SoftUni. Made in Bulgaria");
        }

        private static void printTopPlayers(List<FinalScore> finalScore)
        {
            Console.WriteLine("Score:\n");
            if (finalScore.Count > 0)
            {
                for (int i = 0; i < finalScore.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} squeres", i + 1, finalScore[i].player, finalScore[i].scoreSquereCount);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No result!\n");
            }
        }

        private static void yourTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char countBombs = scoreSquereCount(bombs, row, col);
            bombs[row, col] = countBombs;
            field[row, col] = countBombs;
        }

        private static void print(char[,] board)
        {
            int rowCount = board.GetLength(0);
            int colCount = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] createGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] placeBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> rowList = new List<int>();
            while (rowList.Count < 15)
            {
                Random random = new Random();
                int rnd = random.Next(50);
                if (!rowList.Contains(rnd))
                {
                    rowList.Add(rnd);
                }
            }

            foreach (int fieldRow in rowList)
            {
                int col = fieldRow / cols;
                int row = fieldRow % cols;
                if (row == 0 && row != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void FillGameField(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char cell = scoreSquereCount(field, i, j);
                        field[i, j] = cell;
                    }
                }
            }
        }

        private static char scoreSquereCount(char[,] gameField, int row, int col)
        {
            int countCells = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    countCells++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == '*')
                {
                    countCells++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    countCells++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameField[row, col + 1] == '*')
                {
                    countCells++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    countCells++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    countCells++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    countCells++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    countCells++;
                }
            }

            return char.Parse(countCells.ToString());
        }
    }
}