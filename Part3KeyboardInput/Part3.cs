namespace Part3
{
    public static class Part3
    {
        public static void KeyboardInput()
        {
            //greetings
            int currentYear = Convert.ToInt16(DateTime.Now.ToString("yyyy"));
            Console.Write("Please enter your name:");
            string userName = Console.ReadLine();
            Console.Write("Pleaase enter your age in years:");
            int userAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {userName} since your {userAge} years old and the year is {currentYear} that means you were born in {currentYear - userAge}");
            
            // adder
            int sum = 0;
            for(int number = 0; number != 3; number++)
            {
                Console.Write("Please enter a number to add:");
                sum += Int32.Parse(Console.ReadLine());
                Console.WriteLine($"The current sum is {sum}");
            }
            Console.WriteLine($"The total comes out to {sum}");

            // distance

            float totalDistance = 0;
             for(int number = 0; number != 3; number++)
            {
                Console.Write("Please enter a distance to average");
                totalDistance += float.Parse(Console.ReadLine());
            }
            totalDistance /= 3;
            Console.WriteLine($"The average distance of the three is {Math.Round(totalDistance, 2)}");
            
            // hypotenuse
            double sumOfSideABSquared = 0;
            for(int arm = 0; arm != 2; arm++)
            {
                Console.Write("Please enter an arm of a right triangle:");
                sumOfSideABSquared += Math.Pow(double.Parse(Console.ReadLine()), 2);
            }
            Console.WriteLine($"The hypotenuse is {Math.Sqrt(sumOfSideABSquared)} long");
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
    }
}