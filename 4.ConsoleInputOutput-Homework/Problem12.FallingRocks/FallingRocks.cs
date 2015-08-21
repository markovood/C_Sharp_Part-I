using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

// Problem:
// Implement the "Falling Rocks" game in the text console.
// 
// A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
// A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
// 
// Ensure a constant game speed by Thread.Sleep(150).
// 
// Implement collision detection and scoring system.
namespace Problem12.FallingRocks
{
    class FallingRocks
    {
        struct Rock
        {
            public int x;
            public int y;
            public string symbol;
        }

        static int initialDwarfCoordinateX = (Console.WindowWidth - 30) / 2;
        static int initialDwarfCoordinateY = Console.WindowHeight - 1;
        static string[] rockSymbol = new string[11] { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        static Random randomNumberGenerator = new Random();
        static List<Rock> rocks = new List<Rock>();
        static double lives = 5.0;
        static int score = 0;

        static void Settings()
        {
            Console.Title = "Falling Rocks Game";

            // sets window properties
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;

        }
        static void SettingNotificationArea()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(Console.WindowWidth - 19, 7);
            Console.Write("Lives: {0}", lives);
            Console.SetCursorPosition(Console.WindowWidth - 19, 8);
            Console.Write("Score: {0}", score);
            Console.SetCursorPosition(Console.WindowWidth - 19, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Bonus: N/A");
            Console.SetCursorPosition(Console.WindowWidth - 19, 31);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("CONTROLS: ");
            Console.SetCursorPosition(Console.WindowWidth - 28, 32);
            Console.Write("- For pause press SPACEBAR");
            Console.SetCursorPosition(Console.WindowWidth - 28, 33);
            Console.Write("- To move left press \u2190");
            Console.SetCursorPosition(Console.WindowWidth - 28, 34);
            Console.Write("- To move right press \u2192");
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void SettingPlayingArea()
        {
            // sets the playing area
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(Console.WindowWidth - 30, i);
                Console.Write('|');
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void DistributeRocks(int x, int y, string symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(symbol);
        }
        static void InitialDwarfPosition()
        {
            Console.SetCursorPosition(initialDwarfCoordinateX, initialDwarfCoordinateY);
            Console.CursorVisible = false;
            Console.Write("0");
            Console.SetCursorPosition(initialDwarfCoordinateX + 1, initialDwarfCoordinateY);
            Console.Write(")");
            Console.SetCursorPosition(initialDwarfCoordinateX - 1, initialDwarfCoordinateY);
            Console.Write("(");
        }
        static void MoveRocks()
        {
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.symbol = oldRock.symbol;
                // Collision detection Rocks vs Bottom
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
                // Collision detection Rocks vs Dwarf
                if ((newRock.x == initialDwarfCoordinateX) && (newRock.y == initialDwarfCoordinateY)) // detects rock vs "0" - center of dwarf
                {
                    lives = 0;      // if hitted in the center takes down all lives
                }
                else if ((newRock.x == initialDwarfCoordinateX - 1) && (newRock.y == initialDwarfCoordinateY)) // detects rock vs "(" - left part of dwarf
                {
                    lives -= 0.5; // if hitted on the left only takes down half-life
                    rocks.Clear();// clears the rocks and starts from beginning
                }
                else if ((newRock.x == initialDwarfCoordinateX + 1) && (newRock.y == initialDwarfCoordinateY)) // detects rock vs ")" - right part of dwarf
                {
                    lives -= 0.5; // if hitted on the right only takes down half-life
                    rocks.Clear();// clears the rocks and starts from beginning
                }
            }
            rocks = newList;
        }
        static void MoveDwarf()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true); // "true" кара конзолата да не принтира натиснатите клавиши,а само да ги чете,но понеже сме 
                                                                   // скрили курсора,това "true" не е нужно.ще го оставя все пак....

                // Изчиства буфера за натиснати клавиши като ги прочита (ако има натиснати други клавиш/и различен/ни от Left/Right Arrow)
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if ((initialDwarfCoordinateX - 1) != 0)
                    {
                        initialDwarfCoordinateX--;
                        Console.SetCursorPosition(initialDwarfCoordinateX, initialDwarfCoordinateY);
                        Console.Write("0");
                        Console.SetCursorPosition(initialDwarfCoordinateX - 1, initialDwarfCoordinateY);
                        Console.Write("(");
                        Console.SetCursorPosition(initialDwarfCoordinateX + 1, initialDwarfCoordinateY);
                        Console.Write(")");
                        Console.SetCursorPosition(initialDwarfCoordinateX + 2, initialDwarfCoordinateY);
                        Console.Write(" ");
                    }
                }

                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (initialDwarfCoordinateX + 1 != (Console.WindowWidth - 31))
                    {
                        initialDwarfCoordinateX++;
                        Console.SetCursorPosition(initialDwarfCoordinateX, initialDwarfCoordinateY);
                        Console.Write("0");
                        Console.SetCursorPosition(initialDwarfCoordinateX + 1, initialDwarfCoordinateY);
                        Console.Write(")");
                        Console.SetCursorPosition((initialDwarfCoordinateX - 1), initialDwarfCoordinateY);
                        Console.Write("(");
                        Console.SetCursorPosition((initialDwarfCoordinateX - 2), initialDwarfCoordinateY);
                        Console.Write(" ");
                    }
                }
                if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(Console.WindowWidth - 70, 20);
                    Console.Write("PAUSE...");
                    Console.SetCursorPosition(Console.WindowWidth - 80, 21);
                    Console.Write("PRESS ANY KEY TO GET BACK...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
            }
        }
        static void GameOver()
        {
            Console.Clear();
            SettingNotificationArea();
            SettingPlayingArea();
            InitialDwarfPosition();
            Console.SetCursorPosition(Console.WindowWidth - 70, 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("GAME OVER!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static void MakeNewRock()
        {
            Rock newRock = new Rock();
            newRock.symbol = rockSymbol[randomNumberGenerator.Next(0, 11)];
            newRock.x = randomNumberGenerator.Next(0, (Console.WindowWidth - 30));
            newRock.y = 0;
            rocks.Add(newRock);
        }
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // TODO: Implement scoring and bonus system

            Settings();

            while (lives > 0)
            {
                // Create new rock on random position X and always on top
                MakeNewRock();
                // Move dwarf
                MoveDwarf();
                // Clear the Console
                Console.Clear();
                // Re-draw playing area
                SettingPlayingArea();
                InitialDwarfPosition();
                // Move rocks
                MoveRocks();
                // Distribute rocks
                foreach (Rock rock in rocks)
                {
                    DistributeRocks(rock.x, rock.y, rock.symbol);
                }
                // Sets notification area
                SettingNotificationArea();
                // Slow down the program
                Thread.Sleep(150);
            }
            // Finish the game
            GameOver();
        }

        /*
           !!! Важно!!! Тази игра нямаше да просъществува ако не беше видео лекцията на Николай Костов от https://www.youtube.com/watch?v=bQexyufgclY !!!
        */
    }
}
