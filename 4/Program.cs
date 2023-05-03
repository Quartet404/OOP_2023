namespace OOP_LAB_4
{
    internal class Program
    {
        static void Main(string[] args) {
            string text;
            string filename;
            if (args.Length == 0) {
                filename = "input.txt";
            } else
            {
                filename = args[0];  
            }
            
            try {
                text = File.ReadAllText($@"{Environment.CurrentDirectory}\{filename}");
            } catch {
                Console.WriteLine("File does not exist!");
                return;
            }
            char[] symbols = text.ToLower().ToCharArray(); // convert to char array

            int vowels = 0, consonant = 0;
            foreach (char symbol in symbols) {
                if (Char.IsLetter(symbol)) {
                    if ("aeiou".IndexOf(symbol) != -1) {
                        vowels++;
                    }
                    else {
                        consonant++;
                    }
                }
            }

            Console.WriteLine($"Vowels: {vowels}\nConsonants: {consonant}");
        }
    }
}