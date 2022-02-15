using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Variables";

            char letter; letter = 'A';  //Declared then initialized
            int number; number = 100;   //Declared then initialized
            float body = 98.6f;         //Declared AND initialized
            double pi = 3.14159;         //Decalred AND initialized
            decimal sum = 1000.00m;     //Decalred AND initialized
            bool flag = false;          //Decalred AND initialized
            string text = "C# is fun!"; //Decalred AND initialized

            Console.WriteLine("char letter:\t" + letter);
            Console.WriteLine("int number:\t" + number);
            Console.WriteLine("float body:\t" + body);
            Console.WriteLine("double pi:\t" + pi);
            Console.WriteLine("decimal sum:\t" + sum);
            Console.WriteLine("bool flag:\t" + flag);
            Console.WriteLine("string text:\t" + text);
            Console.ReadKey();
        }
    }
   
}

