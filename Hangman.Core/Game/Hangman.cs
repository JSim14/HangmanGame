using System;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();
        }

        public void Run()
        {
            _renderer.Render(5, 5, 6);

            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine("--------------");
            Console.SetCursorPosition(0, 15);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("What is your next guess: ");
            var nextGuess = Console.ReadLine();
        }
        
    public class Hangman
        {
            private GallowsRenderer _renderer;
            private string _guessProgress;
            private int _numberOfLives;
            private string letter;

            public Hangman()
            {
                _renderer = new GallowsRenderer();
            }


            public void Run()
            {

                _numberOfLives = 6;


                _renderer.Render(5, 5, 6);

                Console.SetCursorPosition(0, 15);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Your current guess: ");


                Console.WriteLine("--------------");
                Console.SetCursorPosition(0, 17);

                Console.ForegroundColor = ConsoleColor.Green;

                /*private static void printHangman()
                {
                    if (!correct== 0)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine("    |");
                        Console.WriteLine("    |");
                        Console.WriteLine("    |");
                        Console.WriteLine("   ===");
                    }
                    else if (wrong == 1)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine("O   |");
                        Console.WriteLine("    |");
                        Console.WriteLine("    |");
                        Console.WriteLine("   ===");
                    }
                    else if (wrong == 2)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine("O   |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("    |");
                        Console.WriteLine("   ===");
                    }
                    else if (wrong == 3)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine(" O  |");
                        Console.WriteLine("/|  |");
                        Console.WriteLine("    |");
                        Console.WriteLine("   ===");
                    }
                    else if (wrong == 4)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine(" O  |");
                        Console.WriteLine("/|\\ |");
                        Console.WriteLine("    |");
                        Console.WriteLine("   ===");
                    }
                    else if (wrong == 5)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine(" O  |");
                        Console.WriteLine("/|\\ |");
                        Console.WriteLine("/   |");
                        Console.WriteLine("   ===");
                    }
                    else if (wrong == 6)
                    {
                        Console.WriteLine("\n+---+");
                        Console.WriteLine(" O   |");
                        Console.WriteLine("/|\\  |");
                        Console.WriteLine("/ \\  |");
                        Console.WriteLine("    ===");
                    }
                }*/


                //  Console.Write("_");
                // var nextGuess = Console.ReadLine();

                Random random = new Random();

                string[] Listwords = new string[] { "Amount", "Obsequious", "Input", "Bike", "Helium", "Nonstop", "Recognize", "Spring", "Property", "bread", "Shallow", "Rings", "Queen", "Conquer", "Internal", "Petite", "Tree", "Room", "Tablet", "pen" };

                var index = random.Next(0, 9);

                string GuessedWords = Listwords[index];


                char[] guess = GuessedWords.ToCharArray();

                for (int i = 0; i < guess.Length; i++)
                {
                    _guessProgress += "*";
                    Console.SetCursorPosition(0, 17);
                }

                while (_numberOfLives > 0)
                {

                    _renderer.Render(5, 5, _numberOfLives);

                    Console.SetCursorPosition(0, 17);

                    char playerguess = char.Parse(Console.ReadLine());


                    char[] guessProgressArray = _guessProgress.ToCharArray();
                    //Console.SetCursorPosition(0, 17);

                    bool correct = true;

                    for (int i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == playerguess)
                        {
                            guessProgressArray[i] = guess[i];
                            correct = true;
                        }
                    }
                    _guessProgress = new string(guessProgressArray);
                    Console.SetCursorPosition(0, 18);


                    Console.WriteLine(_guessProgress);

                    if (!correct)
                    {
                        _numberOfLives--;
                        _renderer.Render(5, 5, _numberOfLives);


                    }

                }


                Console.SetCursorPosition(2, 22);

                if (_numberOfLives == 0)
                {
                    Console.WriteLine($"you died.");
                }
                else
                {
                    Console.WriteLine($"you won with {_numberOfLives} left.");
                }
                Console.WriteLine("Thank you for playing");
            }



        }
    }

}

