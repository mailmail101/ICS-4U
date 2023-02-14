namespace Part5
{
    public static class Part5
    {
        public static void DecisionStructures()
        {
             bool nonValidInput = false;
            bool returnToMainMenu = false;
            while(!returnToMainMenu)
            {
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write("Welcome to decision structures to exit to home type home to end program type exit:\nOptions:\nBank of Blorb:\nSam's Parking:\nHurricane Scale:\n:");
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
                    case("bankofblorb"):
                        BlorbBanking();
                        break;
                    case("samsparking"):
                        SamsParking();
                        break;
                    case("hurricanescale"):
                        HurricaneScale();
                        break;
                    default:
                        nonValidInput = true;
                        break;
                }
            }
        }
        public static void BlorbBanking()
        {
            Random random = new Random();
            double powerBill = (double)random.Next(30, 70);
            powerBill += Math.Round(random.NextDouble(), 2);
            double bankBalence = (double)random.Next(100, 149);
            bankBalence += Math.Round(random.NextDouble(), 2);
            bool nonValidInput = false;
            bool returnToMainMenu = false;
            while(!returnToMainMenu)
            {
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write("Welcome to Blorb Banking to exit to home type home to end program type exit you will be charged $0.75 for each transaction:\nOptions:\nDeposit:\nWithdrawal:\nBill payment:\nAccount Balance Update:\n:");
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

                    case("deposit"):
                        double amountToDeposit = 0;
                        bankBalence -= 0.75;
                        Console.Clear();
                        while(true)
                        {
                            Console.Write("Enter the amount to deposit:");
                            if(Double.TryParse(Console.ReadLine(), out amountToDeposit)){break;}
                            else{Console.Clear(); Console.WriteLine("Thats not a valid input");}
                        }
                        bankBalence += Math.Round(amountToDeposit);
                        Console.WriteLine($"Your new balance is ${bankBalence}");
                        Console.Write("press enter to contine:");
                        Console.ReadLine();
                        break;

                    case("withdrawal"):
                        double amountToWithdrawal = 0;
                        bankBalence -= 0.75;
                        Console.Clear();
                        while(true)
                        {
                            Console.Write("Enter the amount to withdrawal:");
                            if(Double.TryParse(Console.ReadLine(), out amountToWithdrawal))
                            {
                                if(amountToWithdrawal >= bankBalence)
                                {
                                    Console.Clear(); 
                                    bankBalence -= 0.75;
                                    Console.WriteLine($"You don\'t have ${Math.Round(amountToWithdrawal, 2)} and have been charged $0.75 for an invalid withdrawal");
                                }
                                else {break;}
                            }
                            else{Console.Clear(); Console.WriteLine("Thats not a valid input");}
                        }
                        bankBalence -= Math.Round(amountToWithdrawal, 2);
                        Console.WriteLine($"Your new balance is ${bankBalence}");
                        Console.Write("press enter to contine:");
                        Console.ReadLine();
                        break;

                    case("billpayment"):
                        bankBalence -= 0.75;
                        Console.WriteLine($"One bill found \nPower: ${powerBill}");
                        if(bankBalence >= powerBill)
                        {
                            bankBalence -= powerBill;
                            Console.WriteLine("Power bill paid");
                            powerBill = 0;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds");
                        }
                        Console.WriteLine($"Your new balance is ${bankBalence}");
                        Console.Write("press enter to contine:");
                        Console.ReadLine();
                        break;

                    case("accountbalanceupdate"):
                        bankBalence -= 0.75;
                        Console.WriteLine($"Your balance is ${bankBalence}");
                        Console.Write("press enter to contine:");
                        Console.ReadLine();
                        break;

                    default:
                        nonValidInput = true;
                        break;
                }
        }
        }
        public static void SamsParking()
        {
            Console.Clear();
            int timeParked = 0;
            int totalBill = 0;
            while(true)
            {
                Console.Write("Welcome to Sam\'s Parking please enter how long you have parked in minutes:");
                string userInputTimeParked = Console.ReadLine();
                if(Int32.TryParse(userInputTimeParked, out  timeParked)) {break;}
                else{Console.Clear();Console.WriteLine("Were sorry that was not a valid input please enter a whole number");}
            }
            timeParked = (timeParked + 59)/60;
            int originalTimeParked = timeParked;
            if(originalTimeParked > 8){originalTimeParked = 8;}
            if(timeParked > 0){totalBill += 4; timeParked -= 1;}
            totalBill += timeParked * 2;
            if(totalBill > 20){totalBill = 20;}
            Console.Clear();
            Console.WriteLine($"Your bill comes out to ${totalBill}.00 and you are being charged for {originalTimeParked} hours of parking");
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
        public static void HurricaneScale()
        {
            Console.Clear();
            int hurricaneCategory = 0;
            while(true)
            {
                Console.Write("Welcome to Saffir-Spmpson Hurricane Scale please enter the category of the hurricane:");
                string userInputHurricaneCategory = Console.ReadLine();
                if(Int32.TryParse(userInputHurricaneCategory, out  hurricaneCategory)){break;}
                else{Console.Clear();Console.WriteLine("Were sorry that was not a valid input please enter a whole number");}
            }
            Console.Clear();
            switch(hurricaneCategory)
            {
                case(1):
                    Console.WriteLine("74-95 mph / 64-82 kt / 119-153 km/h");
                    break;
                case(2):
                    Console.WriteLine("96-110 mph / 83-95 kt / 154-177 hm/h");
                    break;
                case(3):
                    Console.WriteLine("111-130 mph / 96-113 kt / 178-209 pm/h");
                    break;
                case(4):
                    Console.WriteLine("131-155 pmh / 114-135 kt / 210-249 km/h");
                    break;
                default:
                    if(hurricaneCategory > 4) {Console.WriteLine("Greater then 155 mph / 135 kt / 249 km/h"); break;}
                    Console.WriteLine($"Sorry there is no category {hurricaneCategory} in our database");
                    break;
            }
            Console.Write("press enter to contine:");
            Console.ReadLine();
        }
    }
}