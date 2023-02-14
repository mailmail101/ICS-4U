namespace Part4
{
    public static class Part4
    {

        public static void RandomNumbers()
        {
            // random integers
            int lowerBound = 0;
            int upperBound = 0;
            bool minIsSmaller = false;
            Random random = new Random();
            while(!minIsSmaller)
            {
                Console.Write("Please enter smallest number to generate:");
                lowerBound = Int32.Parse(Console.ReadLine());
                Console.Write("Please enter the largest number to generate:");
                upperBound = Int32.Parse(Console.ReadLine());
                if (lowerBound < upperBound){minIsSmaller = true;}
            }

            for(int numOfNumbers = 0; numOfNumbers != 5; numOfNumbers++)
            {
                Console.Write($"   {random.Next(lowerBound, upperBound + 1)}");
            }
            // dice roller
            Console.WriteLine();
            int sumOfDice = 0;
            int diceRoll;
            for(int amountOfRolls = 0; amountOfRolls != 2; amountOfRolls++)
            {
                diceRoll = random.Next(1, 7);
                sumOfDice += diceRoll;
                Console.WriteLine($"The dice roll was {diceRoll} the total sum of rolls is {sumOfDice}");
            }
            // random decimal numbers
            Console.Write("Do you want to change your min max generate values including decimals y/n:");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                double lowerBoundDouble = 0.0;
                double upperBoundDouble = 0.0;
                double randomNumberWithDecimal = 0.0;
                minIsSmaller = false;
                while(!minIsSmaller)
                {
                    Console.Write("Please enter smallest number to generate:");
                    lowerBoundDouble = Double.Parse(Console.ReadLine());
                    Console.Write("Please enter the largest number to generate:");
                    upperBoundDouble= Double.Parse(Console.ReadLine());
                    if(lowerBoundDouble < upperBoundDouble){minIsSmaller = true;}
                }
                Console.Write("Please enter how many decimals to round the random number to:");
                int numberOfDecimalsPlaces = Int32.Parse(Console.ReadLine());
                for(int numOfNumbers = 0; numOfNumbers != 10; numOfNumbers++)
                {
                    int x = random.Next((int)Math.Floor(lowerBoundDouble), (int)Math.Floor(upperBoundDouble) + 1);
                    do
                    {
                        randomNumberWithDecimal = (double)x + random.NextDouble();
                    } while(!(lowerBoundDouble < randomNumberWithDecimal && randomNumberWithDecimal < upperBoundDouble));
                Console.Write($"{Math.Round(randomNumberWithDecimal, numberOfDecimalsPlaces)}        ");

                }
            }
            else
            {
                Console.Write("Please enter how many decimals to round the random number to:");
                int numberOfDecimalsPlaces = Int32.Parse(Console.ReadLine());
                for(int numOfNumbers = 0; numOfNumbers != 3; numOfNumbers++)
                {
                    int x = random.Next(lowerBound, upperBound);
                    Console.Write($"   {Math.Round(x + (random.NextDouble()), numberOfDecimalsPlaces)}");
                }
            }
            Console.Write("\npress enter to contine:");
            Console.ReadLine();




        }
    }
}