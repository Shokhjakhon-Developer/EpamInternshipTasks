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

        private static string ConsecutiveElement(string str)
        {
            if(str == "")
            {
                return "No arguments.";
            }
            int count = 0;
            int localCount = 0;
            string result = str[0].ToString();
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i+ 1; j < str.Length; j++)
                {
                    if(str[j] == str[i])
                    {
                        localCount++;
                    }
                }
                if(localCount > count)
                {
                    count = localCount;
                    result = str[i].ToString();

                }
            }
          
            return "The most repeated character is \"" + result + "\".";
        }

       
    }

}
