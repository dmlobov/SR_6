using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            string resultString2 = "";
            foreach (string s in stringArray)
            {
                resultString = String.Join("",stringArray);
            }
            foreach(char c in resultString)
            {
                resultString2 = c + resultString2;
            }
            Console.WriteLine(resultString);
            Console.WriteLine(resultString2);
            if (resultString == resultString2)
                Console.WriteLine("Строка является палиндромом");
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey(); 
        }
    }
}
