namespace OOP_LAB_4
{
    internal class Program
    {
        static int vowels, consonant;
        static List<char> vowelsList     = new List<char>() { 'A', 'E', 'I', 'O', 'U' };
        static List<char> consonantsList = new List<char>() { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

        static void Count(string text) {
            foreach (char symbol in text) {
                if (vowelsList.Contains(symbol)) {
                    vowels++;
                } else if (consonantsList.Contains(symbol)) {
                    consonant++;
                }
            }
        }
        static void Main(string[] args) {
            string text;
            string filename;
            if (args.Length == 0) {
                filename = "input.txt";
            } else {
                filename = args[0];
            }

            try {
                text = File.ReadAllText($@"{Environment.CurrentDirectory}\{filename}");
            } catch {
                Console.WriteLine("File does not exist!");
                return;
            }
            text = text.ToUpper();

            vowels = 0;
            consonant = 0;

            Count(text);

            Console.WriteLine($"Vowels: {vowels}\nConsonants: {consonant}");
        }
    }
}