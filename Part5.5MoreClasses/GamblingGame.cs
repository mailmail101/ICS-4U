namespace DiceGame
{
    public class DiceGame
    {
        private Die _die1;
        private Die _die2;
        public DiceGame()
        {
            _die1 = new Die();
            _die2 = new Die();
        }
        public void GamblingGame()
        {
            double bank = 100;
            double bet;
            bool nonValidInput = false;
            while(true)
            {
                 if(bank <= 0)
                    {
                        Console.WriteLine("You have run out of money get out and come back with more");
                        Console.Write("press enter to contine:");
                        Console.ReadLine();
                        return;
                    }
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write($"Welcome to Ivana Philomela's online casino to exit to home type home to end program type exit you currently have ${bank} \nPossible bets:\nBet doubles to win twice your bet if two dice are the same: \nBet not double to win half your bet if two dice are not the same:\nBet even sum to win your bet if the sum of two dice is even:\nBet odd sum to win your bet if the sum of two dice is odd:");
                string navagation = Console.ReadLine();
                navagation = navagation.Replace("\'", "");
                navagation = navagation.Replace(" ", "");
                navagation = navagation.ToLower();

                Console.Clear();
                Console.Write("Enter the amount to bet:");
                if(Double.TryParse(Console.ReadLine(), out bet)){}
                else{bet = 0;}
                if(bet < 0){bet = 0;}
                if(bet > bank){bet = bank;}

                Console.Clear();
                _die1.RollDie();
                _die2.RollDie();
                _die1.DrawRoll();
                _die2.DrawRoll();

                switch(navagation)
                {
                    case("home"):
                        return;
                    case("exit"):
                        Environment.Exit(0);
                        break;
                    case("double"):
                        bank = DoubleBet(bank, bet);
                        break;
                    case("doubles"):
                        bank = DoubleBet(bank, bet);
                        break;
                    case("notdouble"):
                        bank = NotDoubleBet(bank, bet);
                        break;
                    case("notdoubles"):
                        bank = NotDoubleBet(bank, bet);
                        break;
                    case("evensum"):
                        bank = EvenSumBet(bank, bet);
                        break;
                    case("oddsum"):
                        bank = OddSumBet(bank, bet);
                        break;
                    default:
                        nonValidInput = true;
                        break;
                }
            }
        }
         private double DoubleBet(double bank, double bet)
        {
            if(_die1.Roll == _die2.Roll) 
            {
                bank += Math.Round(bet * 2, 2);
                Console.WriteLine($"You have won ${Math.Round(bet * 2, 2)} and you have ${bank} now");
            }
            else
            {

                bank -=Math.Round(bet, 2);
                Console.WriteLine($"You have lost ${Math.Round(bet)} and you have ${bank} now");
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
            return bank;
        }
        private double NotDoubleBet(double bank, double bet)
        {
            if(_die1.Roll != _die2.Roll) 
            {
                bank += Math.Round(bet * 0.5, 2);
                Console.WriteLine($"You have won ${Math.Round(bet * 0.5, 2)} and you have ${bank} now");
            }
            else
            {

                bank -=Math.Round(bet, 2);
                Console.WriteLine($"You have lost ${Math.Round(bet)} and you have ${bank} now");
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
            return bank;
        }
        private double EvenSumBet(double bank, double bet)
        {
            if(0 == ((_die1.Roll + _die2.Roll) % 2)) 
            {
                bank += Math.Round(bet, 2);
                Console.WriteLine($"You have won ${Math.Round(bet, 2)} and you have ${bank} now");
            }
            else
            {

                bank -=Math.Round(bet, 2);
                Console.WriteLine($"You have lost ${Math.Round(bet)} and you have ${bank} now");
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
            return bank;
        }
        private double OddSumBet(double bank, double bet)
        {
            if(1 == ((_die1.Roll + _die2.Roll) % 2)) 
            {
                bank += Math.Round(bet, 2);
                Console.WriteLine($"You have won ${Math.Round(bet, 2)} and you have ${bank} now");
            }
            else
            {

                bank -=Math.Round(bet, 2);
                Console.WriteLine($"You have lost ${Math.Round(bet)} and you have ${bank} now");
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
            return bank;
        }
   
}
}