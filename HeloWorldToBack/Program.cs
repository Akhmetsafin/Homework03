using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloWorldToBack
{
    class Program
    {
        static void Main(string[] args)
        {
            string word= "Hello, world!";
            for (int i = word.Length-1; i > -1; i--)//цикл с конца строкм
            {
                Console.WriteLine(word[i]); // посимвольный вывод .
            }


        }
    }
}
