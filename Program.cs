using System;

namespace ClassMethod
{
    class Math
    {

        // Here Sum() method asks for two parameters from the user  
        // calculates the sum of these  
        // and finally returns the result. 
        static int Sum(int x, int y)
        {

            // there are two local variables, local variable bcs we takes varibale in method  
            int a = x;
            int b = y;

            // The local variable calculates the sum of 'a' and 'b' 
            // and returns the result 
            // which is of 'int' type. 
            int result = a + b;

            return result;
        }

        // Main Method 
        static void Main(string[] args)
        {
            int a = 12;
            int b = 23;

            // Method Sum() is invoked and  
            // the returned value is stored  
            // in the local variable say 'c' 
            int c = Sum(a, b);

            // Display Result 
            Console.WriteLine("The Value of the sum is " + c);
        }
    }
}
