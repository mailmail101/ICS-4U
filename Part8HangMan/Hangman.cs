namespace Part8
{
public static class HangMan
{
    public static void MainGameLoop()
    {
        bool nonValidInput = false;
        SortWordListIntoDifficulty();
        while(true)
            {
                Console.Clear();
                if(nonValidInput){Console.WriteLine("sorry that was not a valid input");nonValidInput = false;}
                Console.Write($"Welcome to hangman to exit to home type home to end program type exit\nTo Add more words to game open word list unsorted and add each word on a separate line\nPlease enter what difficulty you would like to play \nEasy:\nNormal:\nHard:\nImpossible:\nCustom: ");
                string navagation = Console.ReadLine();
                navagation = navagation.Replace("\'", "");
                navagation = navagation.Replace(" ", "");
                navagation = navagation.ToLower();
                switch(navagation)
                {
                    case("home"):
                        return;
                    case("exit"):
                        Environment.Exit(0);
                        break;
                    case("easy"):
                        Game(RandomWord(0));
                        break;
                    case("normal"):
                        Game(RandomWord(1));
                        break;
                    case("hard"):
                        Game(RandomWord(2));
                        break;
                    case("impossible"):
                        Game(RandomWord(3));
                        break;
                    case("custom"):
                        Console.Clear();
                        Console.Write("Please enter the hang man word: ");
                        string secretWord = null;
                        while (true)
                        {
                            var key = System.Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Enter)
                                break;
                            secretWord += key.KeyChar;
                        }
                        Game(secretWord);
                        break;
                    default:
                        nonValidInput = true;
                        break;
                }
            }
    }
    public static void Game(string secretWord)
    {
        secretWord = secretWord.Replace(" ", "");
        secretWord = secretWord.Replace("   ", "");
        int numberOfIncorrectGuesses = 0;
        string displayWord = new String('_' , secretWord.Length);
        List<string> gussedLetters = new List<string>();
        string currentGuess = "";
        while (numberOfIncorrectGuesses != 7)
        {
            currentGuess = "";
            while(!(currentGuess.Length == 1 && !gussedLetters.Contains(currentGuess)))
            {
                Console.Clear();
                if(gussedLetters.Contains(currentGuess)){Console.WriteLine($"You allready guessed {currentGuess}");}
                DrawHangMan(numberOfIncorrectGuesses);
                Console.Write($"You have {7 - numberOfIncorrectGuesses} gueses left and have guessed: ");
                foreach(string letter in gussedLetters) {Console.Write($" {letter}");}
                Console.Write("\n    ");
                foreach(char letter in displayWord) {Console.Write($" {letter}");}
                Console.Write("\nPlease enter a single letter to guess: ");
                currentGuess = Console.ReadLine();
            }
            if(secretWord.Contains(currentGuess)) 
            {
                for (int index = 0; index < secretWord.Length; index++)
                {
                    if (secretWord[index] == currentGuess[0]) {displayWord = displayWord.Remove(index, 1).Insert(index, currentGuess);}
                } 
            }
            if(secretWord == displayWord)
            {
                Console.Clear();
                DrawHangMan(numberOfIncorrectGuesses);
                Console.Write($"You have {7 - numberOfIncorrectGuesses} gueses left and have guessed: ");
                foreach(string letter in gussedLetters) {Console.Write($" {letter}");}
                Console.Write("\nThe word was ");
                Console.Write(secretWord);
                Console.WriteLine("\nGood job you lived to see another day");
                Console.Write("press enter to contine:");
                Console.ReadLine();
                return;
            }
            else{numberOfIncorrectGuesses ++;}
            gussedLetters.Add(currentGuess);
        }
        Console.WriteLine("Sorry you died");
        Console.WriteLine($"The answer is {secretWord}");
        Console.Write("press enter to contine:");
        Console.ReadLine();
    }
    private static string RandomWord(int difficulty)
    {
        List<string> words = new List<string>();
        Random random = new Random();
        switch(difficulty)
        {
            case(0):
                words = File.ReadAllLines("Part8HangMan/WordListEasy.txt").ToList<string>();             
                return words[random.Next(0, words.Count)];
            case(1):
                words = File.ReadAllLines("Part8HangMan/WordListNormal.txt").ToList<string>();             
                return words[random.Next(0, words.Count)]; 
            case(2):
                words = File.ReadAllLines("Part8HangMan/WordListHard.txt").ToList<string>();             
                return words[random.Next(0, words.Count)];   
            case(3):
                words = File.ReadAllLines("Part8HangMan/WordListImpossible.txt").ToList<string>();             
                return words[random.Next(0, words.Count)];   
            default:
                throw new Exception($"Difficulty {difficulty} does not exist");

                
        }
    }
    public static void SortWordListIntoDifficulty()
    {
        double difficultyRating = 0;
        int wordNumber = 0;
        List<string> easyWords = new List<string>();
        List<string> normalWords = new List<string>();
        List<string> hardWords = new List<string>();
        List<string> impossibleWords = new List<string>();
        foreach(string line in File.ReadLines("Part8HangMan/WordListUnsorted.txt"))
        {
            wordNumber += 1;
            difficultyRating = 0;
            foreach(char character in line)
            {
                difficultyRating += LetterScorer(char.ToString(character));
            }
            difficultyRating *= 0.5 + line.Length * 0.1;
            if(difficultyRating <= 60){easyWords.Add(line);}
            else if(difficultyRating <= 100){normalWords.Add(line);}
            else if(difficultyRating <= 160){hardWords.Add(line);}
            else{impossibleWords.Add(line);}
        }
        File.WriteAllLines("Part8HangMan/WordListEasy.txt", easyWords);
        File.WriteAllLines("Part8HangMan/WordListNormal.txt", normalWords);
        File.WriteAllLines("Part8HangMan/WordListHard.txt", hardWords);
        File.WriteAllLines("Part8HangMan/WordListImpossible.txt", impossibleWords);
    }
    private static double LetterScorer(string letter)
    {
        switch(letter)
        {
            case("q"):
                return 56.88;
            case("j"):
                return 43.31;
            case("z"):
                return 38.64;
            case("x"):
                return 38.45;
            case("v"):
                return 36.51;
            case("k"):
                return 35.43;
            case("w"):
                return 33.92;
            case("y"):
                return 29.23;
            case("f"):
                return 27.98;
            case("b"):
                return 23.13;
            case("g"):
                return 18.51;
            case("h"):
                return 17.25;
            case("m"):
                return 16.14;
            case("p"):
                return 15.36;
            case("d"):
                return 15.31;
            case("u"):
                return 12.59;
            case("c"):
                return 10.56;
            case("l"):
                return 9.24;
            case("s"):
                return 9.06;
            case("n"):
                return 6.57;
            case("t"):
                return 5.61;
            case("o"):
                return 5.13;
            case("i"):
                return 1.48;
            case("r"):
                return 1.39;
            case("a"):
                return 1.00;
            case("e"):
                return 1.00;
            case("alex"):
                return 1;
            default:
                return 0;
        }
    }
    private static void DrawHangMan(int numberOfIncorrectGuesses)
    {
        switch(numberOfIncorrectGuesses)
        {
            case(0):
                Console.WriteLine("      +---+");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(1):
                Console.WriteLine("      +---+");
                Console.WriteLine("      |   |");
                Console.WriteLine("      O   |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(2):
                Console.WriteLine("      +---+");
                Console.WriteLine("      |   |");
                Console.WriteLine("      O   |");
                Console.WriteLine("      |   |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(3):
                Console.WriteLine("      +---+");
                Console.WriteLine("      |   |");
                Console.WriteLine("      O   |");
                Console.WriteLine("     /|   |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(4):
                Console.WriteLine("      +---+");
                Console.WriteLine("      |   |");
                Console.WriteLine("      O   |");
                Console.WriteLine("     /|\\  |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(5):
                Console.WriteLine("      +---+");
                Console.WriteLine("      |   |");
                Console.WriteLine("      O   |");
                Console.WriteLine("     /|\\  |");
                Console.WriteLine("     /    |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(6):
                Console.WriteLine("      +---+");
                Console.WriteLine("      |   |");
                Console.WriteLine("      O   |");
                Console.WriteLine("     /|\\  |");
                Console.WriteLine("     / \\  |");
                Console.WriteLine("          |");
                Console.WriteLine("    =========");
                break;
            case(7):
                Console.WriteLine("      +---+");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("     \\O/  |");
                Console.WriteLine("      |   |");
                Console.WriteLine("     / \\  |");
                Console.WriteLine("    =========");
                break;
            default:
                throw new Exception($"No art for {numberOfIncorrectGuesses} incorrect guesses");
        }
    }
}
}