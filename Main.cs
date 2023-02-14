namespace Entry
{
    class Entry
    {
         static void Main (string[] args)
            {
            bool nonValidInput = false;
            while(true)
            {
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write("Please select the part you would like to run simply typing the part number or exit:");
                string part = Console.ReadLine();
                part = part.Replace(",", ".");
                part = part.ToLower();
                switch(part)
                {
                    case("exit"):
                        Environment.Exit(0);
                        break;
                    case("1"):
                        Part1.Part1.FirstNameAndMovie();
                        break;
                    case("3"):
                        Part3.Part3.KeyboardInput();
                        break;
                    case("4"):
                        Part4.Part4.RandomNumbers();
                        break;
                    case("4.5"):
                        Part4AndAHalf.Part4AndAHalf.introToMethods();
                        break;
                    case("5"):
                        Part5.Part5.DecisionStructures();
                        break;
                    case("5.5"):
                        DiceGame.DiceGame game =  new DiceGame.DiceGame();
                        game.GamblingGame();
                        break;
                    case("6"):
                        Part6.LoopingProblems.LoopingMenu();
                        break;
                    case("8"):
                        Part8.HangMan.Game();
                        break;
                    default:
                        nonValidInput = true;
                        break;
                }            
            }
            }
    }
}