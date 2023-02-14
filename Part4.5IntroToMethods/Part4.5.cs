namespace Part4AndAHalf
{
    public static class Part4AndAHalf
    {
        public static void introToMethods()
        {
            bool nonValidInput = false;
            bool returnToMainMenu = false;
            while(!returnToMainMenu)
            {
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write("Welcome to methods and programing to exit to home type home to end program type exit\nOptions:\nFrog:\nSpider:\nDeer:\nKnock Knock Joke:\n:");
                string navagation = Console.ReadLine();
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
                    case("frog"):
                        DrawFrog();
                        break;
                    case("deer"):
                        DrawDeer();
                        break;
                    case("spider"):
                        DrawSpider();
                        break;
                    case("knockknockjoke"):
                        KnockKnockJoke();
                        break;
                    default:
                        nonValidInput = true;
                        break;
                }
            }
        }
        static void DrawFrog()
        {   
             string[] frogAscii = {"        ()-()     "
                                       , "      .-(___)-."
                                       , "       _<   >_ "
                                       , "jgs    \\/   \\/  "};
            Console.Write("Please enter an x coordinate:");
            int xCoordinate = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter an y coordinate:");
            int yCorrdinate = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for(int lineNumber = 0; lineNumber != frogAscii.Length; lineNumber++)
            {
                Console.SetCursorPosition(xCoordinate, yCorrdinate + lineNumber);
                Console.WriteLine(frogAscii[lineNumber]);
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        static void DrawDeer()
        {
            string[] deerAcsii = {"\\|/    \\|/",
                                            "  \\    /", 
                                            "   \\_/  ___   ___",
                                            "   o o-\'   \'\'\'   \'",
                                            "    O -.         |\\",
                                            "        | |\'\'\'| |",
                                            "         ||   | |",
                                            "         ||    ||",
                                            "         \"     \""};
            Console.Write("Please enter an x coordinate:");
            int xCoordinate = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter an y coordinate:");
            int yCorrdinate = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for(int lineNumber = 0; lineNumber != deerAcsii.Length; lineNumber++)
            {
                Console.SetCursorPosition(xCoordinate, yCorrdinate + lineNumber);
                Console.WriteLine(deerAcsii[lineNumber]);
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        static void DrawSpider()
        {
             string[] spiderAscii = { "   / _ \\"
                                            ," \\_\\(_)/_/"
                                            ,"  _//o\\\\_ Max"
                                            ,"   /   \\"};
             Console.Write("Please enter an x coordinate:");
            int xCoordinate = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter an y coordinate:");
            int yCorrdinate = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for(int lineNumber = 0; lineNumber != spiderAscii.Length; lineNumber++)
            {
                Console.SetCursorPosition(xCoordinate, yCorrdinate + lineNumber);
                Console.WriteLine(spiderAscii[lineNumber]);
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        static void KnockKnockJoke()
        {
            Console.WriteLine("Knock, Knock");
            Thread.Sleep(500);
            Console.WriteLine("Who's there?");
            Thread.Sleep(1000);
            for(int wait = 0; wait != 3; wait++)
            {
                Console.Clear();
                Console.WriteLine(".");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("...");
                Thread.Sleep(500);
            }
            Console.WriteLine("Perl");

            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
    }
}