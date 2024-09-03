namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameNamesList = new List<string>(){"Sonic the Hedgehog", "Mario Kart", "Montana '95", "Paperboy"};

            var sortingGameNames = videoGameNamesList.OrderBy(x => x.Length).ToList();
            
            Console.WriteLine("Here is a list of old school video games from the '90s, in order of title length:");

            foreach (var game in sortingGameNames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
