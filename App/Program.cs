using System;

namespace App
{
    public class Program
    {

        public static int Add(int a, int b) => a+b;
        
        public static int NotTestedMethodThatShouldDecreaseCoverage(int a, int b) => a-b;

        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
