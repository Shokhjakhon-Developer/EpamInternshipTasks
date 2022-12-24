// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.ComponentModel;

class Program
{

    static char ConvertChar(int num)
    {
        if (num >= 0 && num <= 9)
            return (char)(num + 48);
        else
            return (char)(num - 10 + 65);
    }

   
    static string ConverToNewBase(int baseNum, int inputNum)
    {
        string tempResult = string.Empty;

        while (inputNum > 0)
        {
            tempResult += ConvertChar((inputNum % baseNum));
            inputNum /= baseNum;
        }
        char[] result = tempResult.ToCharArray();

        Array.Reverse(result);
        return new string(result);
    }

    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        var inputNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your new base: ");
        var baseNum = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(inputNum +" in base " + baseNum + " is " + ConverToNewBase(baseNum, inputNum)  + ".");
    }
}
