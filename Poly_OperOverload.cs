using System;

class Class1
    {
        //Properties
        int a, b;
        
	//Constructor
        Class1(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        
	//Operator Overloading
        public static Class1 operator*(Class1 _obj1, Class1 _obj2)
        {
            Class1 _obj3 = new Class1(0, 0);
            _obj3.a = _obj1.a * _obj2.a;
            _obj3.b = _obj1.b * _obj2.b;
            return _obj3;
        }
        
	//Print Values
        public static void Showresults(Class1 _obj)
        {
            Console.WriteLine("a = " + _obj.a);
            Console.WriteLine("b = " + _obj.b);
        }
        
	//Main Function
        public static void Main()
        {
            Class1 obj1 = new Class1(2, 4);
            Class1 obj2 = new Class1(3, 5);
            Class1 obj3 = new Class1(0, 0);
            obj3 = obj1 * obj2;
            Class1.Showresults(obj3);
        }
    }