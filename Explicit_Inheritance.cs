using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    interface I1
    {
        void myMethod();
    }
    interface I2
    {
        void myMethod();
    }
    class MultipleInhertance:I1,I2
    {
        void I1.myMethod()
        {
            Console.WriteLine("Hello I am Interface-1 Method");
        }
        void I2.myMethod()
        {
            Console.WriteLine("Hello I am Interface-2 Method");
        }
    }
    public class Client
    {
        public static void Main()
        {
            MultipleInhertance Obj1 = new MultipleInhertance();

 

            I1 Interface1 = Obj1;
            Interface1.myMethod();

 

            //
            I2 Interface2 = Obj1;
            Interface2.myMethod();

 

            Console.ReadLine();
        }
       
    }
}