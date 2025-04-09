using static System.Net.Mime.MediaTypeNames;

namespace N9__YP__Task_3_09._04._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "Text.txt";
            if (!File.Exists(FilePath))
            {
                Console.Write("file not found");
                return;
            }
            
            string text = File.ReadAllText(FilePath);
            int punCount = 0;

            foreach (char c in text)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                { punCount++; }
            }
            Console.WriteLine($"знаков пунктуации :{punCount}");
        }
    }
}
