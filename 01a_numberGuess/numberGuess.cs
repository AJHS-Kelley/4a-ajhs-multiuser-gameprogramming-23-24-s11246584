// Takiyah Travis, Program Template, v0.01
/*
Generate secret number from a defined range of numbers (i.e. 0-10, 0-50, 0-100)
Print name instructions including range and num. of guesses allowed.
    MATCH == first player to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts
Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not.
    If guess is correct {
        Tell them they have guessed correctly.
        Award the player a point.
    } else {
        Tell them they are wrong.
        Tell player if guess is too high or too low.
        Check to see if they have guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
                CPU wins the round.

    }    


*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numberGuesses = 0; // Number of guesses player is ALLOWED.
            int numAttempts = 0; //Number of guesses TAKEN.
            int playerGuess = 0;
            int PlayerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            ing rangeMax = -1;

            Console.WriteLine("Welcome to the Number Guessing Game!\nYou will select a difficulty next.\n");
            Console.WriteLine("Easy Mode: Range is 0 - 20 with 4 guesses.\nNormal Mode: Range is 0 - 50 with 3 guesses.\nHard Mode: Range is 0 - 100 with 2 guesses")

            // DIFFICULTY SELECTION
            Console.WriteLine("Please type Easy, Normal, or Hard and press ENTER.")
            difficulty = Console.WriteLine();
            // Console.WriteLine() will save to STRING by default.
            Console.WriteLine("You have selected " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 20
                numGuesses = 4;

            } else if (NORMAL MODE) {
                // Code to run
            } else if (HARD MODE) {
                // Code to run
            } else {
                // Code to run if no difficulty is selected.
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine{"Maximum: " + rangeMax};
            Console.WriteLine("Num. Guesses: " + numGuesses);








            START THE MATCH!
            while (playerScore != 3 && cpuScore != 3) {
                //  Any code you want to run BEFORE each round goes here.
                // GENERATE SECRET NUMBER
                Random rndNum = new Random ();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                 Console.WriteLine(secretNumber); // REMOVE AFTER TESTING
                 Console.WriteLine("Player Score: " + playScore + "\n");
                 Console.WriteLine("CPU Score: " + cpuScore + "\n");
                //START EACH ROUND
                for (int i = 0; i < numGuesses ; i++) {
                    // Code to guess number goes here.
                     Console.WriteLine("You have used  " + numAttempts + " this round.\n");
                      Console.WriteLine("You must guess between " + rangeMin + "and " + rangeMax + ".\n");
                      playerGuess = System.Convert.ToInt32(Console.ReadLine());
                      if (playerGuess == sectretNumber) {
                          // Print a success message!
                          ("Wow, thats awsome!");
                          playerScore++:
                          break;
                        } else {
                            if (playerGuess > secretNumber) {
                                 Console.WriteLine("Your guess is too high!\n");
                            } else {
                                 Console.WriteLine("Your guess is too low!\n")
                            }
                            numAttempts++;
                        }
                        if (playerGuess != secretNumber) {
                            cpuScore++;
                            // Print a round lost message to the console.
                        }
                }
                if (playerScore >= 3) {
                     Console.WriteLine("You have won the game!\n");
                } else {
                     Console.WriteLine("You have lost the game!\n");
                }
            }
        }    
    }    
}    