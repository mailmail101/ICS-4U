namespace Part8
{
public static class HangMan
{
    public static void Game()
    {
        
    }
    private static string RandomWord(int difficulty)
    {
        List<string> words = new List<string>();
        Random random = new Random();
        switch(difficulty)
        {
            case(0):
                words = File.ReadAllLines("WordListEasy.txt").ToList<string>();             
                return words[random.Next(0, words.Count)];
            case(1):
                words = File.ReadAllLines("WordListNormal.txt").ToList<string>();             
                return words[random.Next(0, words.Count)]; 
            case(2):
                words = File.ReadAllLines("WordListHard.txt").ToList<string>();             
                return words[random.Next(0, words.Count)];   
            case(3):
                words = File.ReadAllLines("WordListImpossible.txt").ToList<string>();             
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