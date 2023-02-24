using System;

namespace Variables_Rowland_Ethan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            // Bolleans intialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            // Declared random float variable
            float myFloat;
            // Assigning the favoriteNumber to 6
            favoriteNumber = 6;
            // Assigning myFloat to 54.65
            myFloat = 54.65f;
            // Intializing constant finalGrade to 90
            const double finalGrade = 90.0;

            // Prints all variables to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
