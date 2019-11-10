using System;

namespace Accenture
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Program();
            Console.WriteLine("Welcome, please write aa sentence for me to reverse");
            string userInput = Console.ReadLine();
            Console.WriteLine(Reverse(userInput));
        }

        #region Functions
        private static string Reverse(string sentence)
        {
            try
            {
                string tmp = sentence.Trim();
                string[] words = tmp.Split(' ');
                Array.Reverse(words);
                string output = string.Join(" ", words);
                return output;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

    }
}
