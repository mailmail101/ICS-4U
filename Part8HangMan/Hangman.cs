namespace Part8
{
    public static class HangMan
    {
        public static void Game()
        {

        }
        private static string RandomWord(int difficulty)
        {
            string word ="";
            Random random = new Random();
            
            return word;
        }
        public static void SortWordListIntoDifficulty()
        {
            int difficultyRateing;
            List<string> easyWords = new List<string>();
            List<string> normalWords = new List<string>();
            List<string> hardWords = new List<string>();
            List<string> impossibleWords = new List<string>();
            foreach(string line in File.ReadLines("Part8HangMan/WordListUnsorted.txt"))
            {
                difficultyRateing = 0;
                difficultyRateing += line.Length;
            }
            Console.Write("done");
        }
    }
}