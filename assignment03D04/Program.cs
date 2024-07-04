namespace assignment03D04
{
    internal class Program
    {
        //value type passing by value in Q01 
        static void swap(int num1,int num2)
        {
            int temp =num1;
            num1 = num2;
            num2 = temp;
        }
        //value type passing by reference in Q01 
        static void swapp(ref int num1,ref  int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {
            #region Q01
            /*1-Explain the difference between passing (Value type parameters) 
             * by value and by reference then write a suitable c# example.
             Answer: 
            *****in passing by value When a parameter is passed by value, the method receives a copy of the argument. 
            Changes made to the parameter inside the method do not affect the original argument.
            *****in passing by reference he method receives a reference to the argument. 
            *Changes made to the parameter inside the method will affect the original argument.
             */
            int number1 = 5, number2 = 3;
            //passing by value 
            Console.WriteLine("passing by value");
            Console.WriteLine($"number1 before swapping :{number1}");
            Console.WriteLine($"number2 before swapping :{number2}");
            swap(number1,number2);
            Console.WriteLine($"number1 after swapping :{number1}");
            Console.WriteLine($"number2 after  swapping :{number2}");
            Console.WriteLine( "****************************************************");
            //passing by reference 
            Console.WriteLine("passing by reference");
            Console.WriteLine($"number1 before swapping :{number1}");
            Console.WriteLine($"number2 before swapping :{number2}");
            swapp(ref number1,ref  number2);
            Console.WriteLine($"number1 after swapping :{number1}");
            Console.WriteLine($"number2 after  swapping :{number2}");
            #endregion
        }
    }
}
