namespace The_long_game
{
    using System;
    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            // this step one intro of the user
            Console.WriteLine("Welcome, user enter your name!");
            String username = Console.ReadLine();

            String userUnique = username + ".txt";

            //Console.WriteLine(username);
            // this is step 2 keeping track of the user score which will start at 0 unless they have a file already
            int userScore = 0;
            
            // checks if the user already exist
            if (File.Exists(userUnique))
            {
                using (StreamReader sr = File.OpenText(userUnique))
                {
                    userScore = int.Parse(File.ReadAllText(userUnique));
                    Console.WriteLine("Welcome back, " + username + ". You have a score of " + userScore);
                }
            }

            while (true)
            {
                var pressKey = Console.ReadKey(true);
                if (pressKey.Key == ConsoleKey.Enter)
                {
                    break;
                }
                userScore++;
                Console.WriteLine("Current Score: " + userScore);
            }

            //save the score
            File.WriteAllText(userUnique, userScore.ToString());
            Console.WriteLine("Nice try! Your final score is " + userScore + " !");
        }
    }
}
