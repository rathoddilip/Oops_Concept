using System;

namespace Polymorphism
{
    public class Cal
    {
       //Method overloading by changing the number of arguments and data types
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static float add(float a, float b)
        {
            return a + b;
        }
    }
    public class TestMemberOverloading
    {
        public static void Main()
        {
            Console.WriteLine("Int calculation = " +Cal.add(12, 23));
            Console.WriteLine("Int calculation = " +Cal.add(12, 23, 25));
            Console.WriteLine("Float calcuation = " +Cal.add(21.3f, 19.9f));
        }
    }
}
