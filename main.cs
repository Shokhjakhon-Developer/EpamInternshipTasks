//Create a program that takes a sequence of symbols (string) as arguments from the command line and prints the maximum number of unequal consecutive characters per line to the console.
using System;
namespace PracticalTasks
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Enter some text: ");
            string str = Console.ReadLine();
            Console.WriteLine(ConsecutiveElement(str));
        }

        private static string ConsecutiveElement(string setOfCharacters)
        {
            if(setOfCharacters == "")
            {
                return "No arguments.";
            }
            int count = 0;
            int localCount = 0;
            string result = setOfCharacters[0].ToString();
            for(int i = 0; i < setOfCharacters.Length; i++)
            {
                for(int j = i+ 1; j < setOfCharacters.Length; j++)
                {
                    if(setOfCharacters[j] == setOfCharacters[i])
                    {
                        localCount++;
                    }
                }
                if(localCount > count)
                {
                    count = localCount;
                    result = setOfCharacters[i].ToString();

                }
            }
          
            return $"The most repeated character is {result}.";
        }

       
    }

}
