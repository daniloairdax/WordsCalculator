using Entities.TextEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WordsCalculatorManager.Factory;
using WordsCalculatorManager.Factory.Base;
using WordsCalculatorManager.Helpers;

namespace WordsCalculatorManager
{
    public class WordsCalculatorManager
    {
        static void Main(string[] args)
        {
            TextModel textModel = null;
            TextHelperFactory factory = null;
            var inputChoise = string.Empty;
            var inputText = string.Empty;
            var answer = string.Empty;
            var path = string.Empty;
            int count = 0;
            bool endOfSession = false;

            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("\n" + 
                "How do you want to load text? \n" +
                "1. First record from database. \n" +
                "2. Manual input. \n" +
                "3. From txt file. \n");

                do
                {
                    Console.WriteLine("You must enter number from 1 to 3:");
                    inputChoise = Console.ReadLine();
                } while (!Regex.IsMatch(inputChoise, @"^[1-3]{1}$"));

                switch (inputChoise)
                {
                    case "1":
                        textModel = DBTextHelper.GetWordsCountFromDB();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine($"Text from database is:\n{textModel.Text}");
                        count = textModel.WordsCount;
                        break;
                    case "2":
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Enter your text:");
                        inputText = Console.ReadLine();
                        factory = new ClientTextHelperFactory();
                        Console.WriteLine($"\nText from {factory.GetTextHelper().TextHelperType} is:\n{inputText}");
                        count = factory.GetTextHelper().GetWordsCountFromClient(inputText);
                        break;
                    case "3":                                              
                        do
                        {
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Please enter full valid destination path of text file like example below and make sure your file is not protected.");
                            Console.WriteLine(@"C:\Temp\Data\Example.txt");
                            path = Console.ReadLine();
                        } while (!File.Exists(path));

                        inputText = File.ReadAllText(path);                       
                        factory = new FileTextHelperFactory();
                        Console.WriteLine($"\nText from {factory.GetTextHelper().TextHelperType} is:\n{inputText}");
                        count = factory.GetTextHelper().GetWordsCountFromClient(inputText);
                        break;
                }

                Console.WriteLine($"\nNumber of words in text is: {count}");
                Console.WriteLine("---------------------------");
                Console.WriteLine("\nDo you want to start new session?");

                do
                {                   
                    Console.WriteLine("Please enter YES or NO:");
                    answer = Console.ReadLine().ToLower();
                } while (!(answer == "yes" || answer == "no"));

                if (answer == "no") endOfSession = true;

            } while (!endOfSession);           
        }       
    }
}
