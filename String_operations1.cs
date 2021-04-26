using System;


class Class1
    {
        static void Main()
        {
            string a = "It is a Bad Color";
            char[] arr;
            arr = a.ToCharArray();
            Console.WriteLine("Your string is : " +a);
          
            if (a.Contains("is"))
            {
                Console.WriteLine("Yes! 'is' is there in the string ");
            }
            else
            {
                Console.WriteLine("No! 'is' is not there in the string ");
            }

            for (int i=0; i<a.Length; i++ )
            {
                if (Char.IsLower(arr[i]))
                {
                    Console.Write(Char.ToUpper(arr[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(arr[i]));
                }
            }
            
        }
        
    }