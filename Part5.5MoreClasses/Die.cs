namespace DiceGame
{
     public class Die
    {
            private Random _random;
            private int _roll;

            public Die()
            {
                _random = new Random();
                _roll = _random.Next(1, 7);
            }

            public Die(int roll)
            {
                _random = new Random();
                // Ensures a valid roll
                if (roll < 1)
                    _roll = 1;
                else if (roll > 6)
                    _roll = 6;
                else
                    _roll = roll;
            }

            public int Roll { get { return _roll; } }

            public void RollDie()
            {
                _roll = _random.Next(1, 7);
            }

            public override string ToString()
            {
                return _roll.ToString();
            }

            public void DrawRoll()
            {
                switch (_roll)
                {
                    case 1:
                        Console.WriteLine(" ---");
                        Console.WriteLine("|   |");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|   |");
                        Console.WriteLine(" ---");
                        break;
                    case 2:
                        Console.WriteLine(" ---");
                        Console.WriteLine("|o  |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|  o|");
                        Console.WriteLine(" ---");
                        break;
                    case 3:
                        Console.WriteLine(" ---");
                        Console.WriteLine("|o  |");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|  o|");
                        Console.WriteLine(" ---");
                        break;
                    case 4:
                        Console.WriteLine(" ---");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|o o|");
                        Console.WriteLine(" ---");
                        break;
                    case 5:
                        Console.WriteLine(" ---");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("| o |");
                        Console.WriteLine("|o o|");
                        Console.WriteLine(" ---");
                        break;
                    case 6:
                        Console.WriteLine(" ---");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|o o|");
                        Console.WriteLine("|o o|");
                        Console.WriteLine(" ---");
                        break;
                }
            }
    }
}