using System;

class Program
    {
        void sum(int a, int b)
        {
            Console.WriteLine("Sum of integers a+b= " + (a + b));
        }
        void sum(float a, float b)
        {
            Console.WriteLine("Sum of decimals a+b= " + (a + b));
        }
        static void Main(string[] args)
        {
            Program myobj = new Program();
            myobj.sum(1, 2);
            myobj.sum(1.2F, 3.1F);
        }
    }