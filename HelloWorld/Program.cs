using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write 2 numbers");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            Console.WriteLine(number1 + " " + number2);
        }
    }
}
