namespace Part1
{
public static class Part1
{
    public static void FirstNameAndMovie ()
    {
        //part 1 
        string firstName = "Liam";
        string favMovie = "The Matrix";
        Console.WriteLine($"hi {firstName.ToLower()} hope you have a good day");
        Console.WriteLine("hi " + firstName.ToLower() + " hope you have a good day");
        favMovie = favMovie.ToUpper();

        Console.WriteLine(favMovie);
        if (favMovie.Contains("THE"))
        {
            Console.WriteLine("True"); 
        }
        else
        {
            Console.WriteLine("False");
        }

        favMovie = favMovie.Replace("A", "@");
        favMovie =  favMovie.Replace("E", "3");
        Console.WriteLine(favMovie);

        //part 2
        string favQuote = "if you know the enemy and know yourself, you need not fear the result of a hundred battles.";
        string[] vowels = {"a", "e", "i", "o","u"};
        foreach (string vowel in vowels)
        {
                favQuote = favQuote.Replace(vowel, "");
        }
        Console.WriteLine(favQuote);

        //part 3
        string[] frogAscii = {"        ()-()     "
                                       , "      .-(___)-."
                                       , "       _<   >_ "
                                       , "jgs    \\/   \\/  "};
        string[] spiderAscii = { "/ _ \\"
                                            ," \\_\\(_)/_/"
                                            ,"  _//o\\\\_ Max"
                                            ,"  /   \\"};

        for(int line = 0; line < frogAscii.Length; line++)
        {
            Console.WriteLine($"{frogAscii[line]}          {spiderAscii[line]}");
        }
        Console.Write("press enter to contine:");
        Console.ReadLine();
    }
}
}