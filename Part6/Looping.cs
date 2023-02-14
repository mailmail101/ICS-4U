namespace Part6
{
    public static class LoopingProblems
    {
        public static void LoopingMenu()
        {
            bool nonValidInput = false;
            bool returnToMainMenu = false;
            while(!returnToMainMenu)
            {
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write($"Welcome to looping problems to exit to home type home to end program type exit\nOptions:\nPrompter: \nPercent Passing: \nOdd Sum: \nRandom Numbers: \nDice Game: ");
                string navagation = Console.ReadLine();
                navagation = navagation.Replace("\'", "");
                navagation = navagation.Replace(" ", "");
                navagation = navagation.ToLower();
                switch(navagation)
                {
                    case("home"):
                        returnToMainMenu = true;
                        break;
                    case("exit"):
                        Environment.Exit(0);
                        break;
                    case("prompter"):
                        Prompter();
                        break;
                    case("percentpassing"):
                        PercentPassing();
                        break;
                    case("oddsum"):
                        OddSum();
                        break;
                    case("randomnumber"):
                        RandomNumbers();
                        break;
                    case("randomnumbers"):
                        RandomNumbers();
                        break;
                    case("dicegame"):
                        DiceGame();
                        break;
                    default:
                        nonValidInput = true;
                        break;
                }
            }
        }
        private static void Prompter()
        {
            Console.Clear();
             int lowerBound = 0;
            int upperBound = 0;
            int numberInbetweenBounds;
            bool minIsSmaller = false;
            bool withInRange = false;
            Random random = new Random();
            Console.Clear();
            while(!minIsSmaller)
            {
                Console.Clear();
                Console.Write("Please enter the lower bound of the range:");
                while(!Int32.TryParse(Console.ReadLine(), out lowerBound))
                {
                    Console.Clear();
                     Console.Write("Please enter the lower bound of the range:");
                }
                Console.Clear();
                Console.Write("Please enter the higher bound of the range:");
                while(!Int32.TryParse(Console.ReadLine(), out upperBound))
                {
                    Console.Clear();
                    Console.Write("Please enter the higher bound of the range:");
                }
                if (lowerBound < upperBound){minIsSmaller = true;}
            }
            while(!withInRange)
            {
                Console.Clear();
                Console.Write($"Please enter the a number between {lowerBound} and {upperBound}: ");
                while(!Int32.TryParse(Console.ReadLine(), out numberInbetweenBounds))
                {
                    Console.Clear();
                    Console.Write($"Please enter the a number between {lowerBound} and {upperBound}: ");
                }
                if(lowerBound <= numberInbetweenBounds && numberInbetweenBounds <= upperBound)
                {
                    Console.Clear();
                    Console.WriteLine($"{numberInbetweenBounds} is within {lowerBound} and {upperBound}");
                    withInRange = true;
                }
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        private static void PercentPassing()
        {
            int passingScores = 0;
            int failingScores = 0;
            int score;
            string userInput;

            while(true)
            {
                Console.Clear();
                Console.Write($"Please enter a score that a student got to stop enter done: ");
                userInput = Console.ReadLine();
                if(userInput.ToLower() == "done"){break;}
                if(Int32.TryParse(userInput, out score))
                {
                    if(score >= 70){passingScores ++;}
                    else{failingScores ++;}
                }
            }
            Console.Clear();
            Console.WriteLine($"{100 *passingScores / (failingScores + passingScores)}% of the {failingScores + passingScores} students have scores above 70%");
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        private static void OddSum()
        {
            int sum = 0;
            int numberToSumTo;
            Console.Clear();
            Console.Write("Please enter a number to sum all smaller odd numbers:");
            while(!Int32.TryParse(Console.ReadLine(), out numberToSumTo))
            {
                Console.Write("Please enter a number to sum all smaller odd numbers:");
            }
            for(int number = 1; number <= numberToSumTo; number += 2)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of all odd numbers up to {numberToSumTo} is {sum}");
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        private static void RandomNumbers()
        {
            int lowerBound = 0;
            int upperBound = 0;
            bool minIsSmaller = false;
            Random random = new Random();
            Console.Clear();
            while(!minIsSmaller)
            {
                Console.Clear();
                Console.Write("Please enter smallest number to generate:");
                while(!Int32.TryParse(Console.ReadLine(), out lowerBound))
                {
                    Console.Clear();
                     Console.Write("Please enter smallest number to generate:");
                }
                Console.Clear();
                Console.Write("Please enter the largest number to generate:");
                while(!Int32.TryParse(Console.ReadLine(), out upperBound))
                {
                    Console.Clear();
                    Console.Write("Please enter the largest number to generate:");
                }
                if (lowerBound < upperBound){minIsSmaller = true;}
            }
            for(int numOfNumbers = 0; numOfNumbers != 25; numOfNumbers++)
            {
                Console.Write($"   {random.Next(lowerBound, upperBound + 1)}");
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        private static void DiceGame()
        {
            Console.Clear();
             DiceGame.DiceGame game =  new DiceGame.DiceGame();
            game.GamblingGame();
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
    }
}