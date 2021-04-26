using System;

class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string a = Console.ReadLine();
            string b = "";
            for (int i=0; i<a.Length; i++)
            {
                if (b.Contains(a[i]))
                {
                   //no actions
                }
                else
                {
                    b = b + a[i];
                }
            }
            Console.WriteLine("The Resultant String is : {0}",b);
        }
    }