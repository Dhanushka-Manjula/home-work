using System.Text.RegularExpressions;

namespace RegularExpression;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Enter a regular expression(or press ENTER to use the default): ");
                string regExp = Console.ReadLine();

                if (regExp == null || regExp == "")
                {
                    regExp = "^[1-9]+$";
                }

                Regex r = new Regex(@regExp);

                Console.Write("Enter some input: ");
                string input = Console.ReadLine();

                Console.WriteLine( input + " matches " + regExp + "?: " + (r.IsMatch(input) ? "True" : "False"));

                Console.WriteLine("Press ESC to end or any key to try again.");
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid inputs");
            }

        }
    }
}

