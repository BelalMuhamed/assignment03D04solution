using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Text;

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
        //reference type passing by value 
        static void  PassByValue(int[] arr)
        {
            arr = new int[]{ 5, 7, 8 };
        }
        //reference type passing by reference 
        static void PassByReference(ref int[] arr)
        {
            arr = new int[] { 5, 7, 8 };
        }
        //q03 function pass by out 
        #region Q03
        /*3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers*/
        static void SumSubtract(int num1,int num2,out int sum,out int subtract)
        {
            sum = num1 + num2;
            subtract = num1 - num2;
        }
        #endregion
        // Function to calculate the sum of the individual digits of a given number
        #region Q04
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10; 
                number /= 10;       
            }
            return sum;
        }

        #endregion
        //is prime function 
        static bool IsPrime(int number)
        {
            int counter = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number%i==0)
                {
                    counter ++;
                }
            }
            if(counter == 2)
                return true;
            else 
                return false;

        }
        //maxmin values in array 
        #region Q06
        /*6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters */
        static void maxmin(ref int[]arr,out int max,out int min)
        {
            Array.Sort(arr);
            min = arr[0];
            max = arr[arr.Length - 1];
        }
        #endregion
        //factorial
        #region Q07
        /*7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter*/
        static long factorial(int num)
        {
            long fact = 1;

            if (num > 0)
            {
                for (int i = num; i > 0; i--)
                    fact *= i;
                return fact;

            }
            else
                return 0;
        }
        #endregion

        #region Q08
        /*8-	Create a function named "ChangeChar" to modify a letter in a certain position 
         * (0 based) of a string, replacing it with a different letter*/
       static string ChangeChar(string str ,int position,char NewChar)
        {
            if(position<0 || position>=str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }
            else
            {
                char[] newstring = str.ToCharArray();
                newstring[position]= NewChar;
                return new string(newstring);

            }
        }
        #endregion

        #region Q09
        /*Write a program that prints an identity matrix using for loop
         *in other words takes a value n from the user and shows the identity table of size n * n.*/
        static void printarray( int number)
        {
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (i == j)
                            Console.Write(" 1 ");
                        else
                            Console.Write(" 0 ");
                    }
                    Console.WriteLine();
                }
            }
        }
        #endregion

        #region Q10
        /*10-Write a program in C# Sharp to find the sum of all elements of the array.*/
        static int sumOfArray (int[] array)
        {
            int sum = 0;
            for(int i =0;i < array.Length;i++)
            {
                sum += array[i];
            }
            return sum;
        }
        #endregion  

        #region Q11
        /*11-	 Write a program in C# Sharp to count the frequency of each element of an array*/
        static void frequency(int[]arr)
        {
            int counter = 0;
            
            for(int i =0; i < arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i] == arr[j] && j<i)
                    {
                        break;
                        
                    }
                    else if (arr[i] == arr[j] && j>=i)
                    {
                        counter++;
                    }
                   
                }
                if (counter > 0)
                {
                    Console.WriteLine($"{arr[i]} is repeated  {counter}");
                    counter = 0;
                }
            }
        }
        #endregion
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
            swap(number1, number2);
            Console.WriteLine($"number1 after swapping :{number1}");
            Console.WriteLine($"number2 after  swapping :{number2}");
            Console.WriteLine("****************************************************");
            //passing by reference 
            Console.WriteLine("passing by reference");
            Console.WriteLine($"number1 before swapping :{number1}");
            Console.WriteLine($"number2 before swapping :{number2}");
            swapp(ref number1, ref number2);
            Console.WriteLine($"number1 after swapping :{number1}");
            Console.WriteLine($"number2 after  swapping :{number2}");
            #endregion

            #region Q02
            /*2-Explain the difference between passing (Reference type parameters)
             * by value and by reference then write a suitable c# example.*/
            /*answer:
             *******************passing by value :When a reference type parameter is passed by value, 
             *the method receives a copy of the reference to the object. The reference itself is copied, 
             *not the object. This means that while the method can modify the object's data 
             *(since both the original reference and the copied reference point to the same object), 
             *it cannot change the original reference to point to a new object.
             ********************passing by reference :When a reference type parameter is passed by reference, 
             *the method receives a reference to the reference.This allows the method to modify the object's data
             *and also change the reference to point to a new object.
             */
            int[] arra = { 1, 2, 3 };
            Console.WriteLine("**************************************************************");
            //passing by value 
            PassByValue(arra);
            Console.WriteLine($"the first element of the array will not be change {arra[0]}");
            Console.WriteLine("**************************************************************");
            //passing by value 
            PassByReference(ref arra);
            Console.WriteLine($"the first element of the array will  change {arra[0]}");
            #endregion

            #region Q03Test
            Console.Clear();
            int num1 = 10, num2 = 7, sum, subtract;
            SumSubtract(num1, num2, out sum, out subtract);
            Console.WriteLine($"the sum of {num1}and {num2} is : {sum}");
            Console.WriteLine($"the subtract of {num1}and {num2} is : {subtract}");

            #endregion

            #region Q04test
            Console.Clear();
            int number;
            Console.WriteLine("Enter number you want to calculate sum of it's digits ");
            int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine(SumOfDigits(number));
            #endregion

            #region Q05test
            Console.Clear();
            int numbeer;
            Console.WriteLine("Enter number : ");
            int.TryParse(Console.ReadLine(), out numbeer);
            Console.WriteLine(IsPrime(numbeer));
            #endregion

            #region Q06test
            Console.WriteLine("********************************************************");
            int[] array1 = { 5, 8, 9, 7, 6, 3, 2, 1 };
            int MaxValue;
            int MinValue;
            maxmin(ref array1, out MaxValue, out MinValue);
            Console.WriteLine($"Max value of the array is {MaxValue}");
            Console.WriteLine($"Min value of the array is {MinValue}");

            #endregion

            #region Q07test 
            Console.Clear();
            Console.WriteLine("enter your number ");
            int.TryParse(Console.ReadLine(), out int NumberFact);
            long result = factorial(NumberFact);
            Console.WriteLine($"the factorial of {NumberFact} is : {result} ");
            #endregion

            #region Q08test

            string str = "Belal";
            int post = 1;
            char ch = 'i';

            Console.WriteLine(ChangeChar(str, post, ch));
            #endregion

            #region Q09test
            Console.Clear();
            Console.WriteLine("enter number ");
            int.TryParse(Console.ReadLine(), out int num);
            printarray(num);
            #endregion

            #region Q10test
            Console.Clear();
            int[] arr = { 1, 5, 6, 8, 9 };
            Console.WriteLine(sumOfArray(arr));
            #endregion
           
            #region Q11test
            int[] arrafreq = { 4, 3, 2, 1, 8, 9, 7, 5, 2, 1, 6, 7, 8, 7, 2, 5 };
            Console.WriteLine(arr.Length);
            frequency(arrafreq);
            #endregion
            
            #region Q12
            /*12-Write a program in C# Sharp to find maximum and minimum element in an array*/
            Console.Clear();
            int[] arraQ12 = { 4, 3, 2, 5, 8, 9, 10,1 };
            int maxvalu = arraQ12[0];
            int samll = arraQ12[0];
            for(int i= 1;i<arraQ12.Length;i++)
            {
                if (MaxValue < arraQ12[i])
                {
                    maxvalu = arraQ12[i];
                }
                if (samll > arraQ12[i])
                {
                    samll = arraQ12[i];
                }
            }
            
            Console.WriteLine(maxvalu);
            Console.WriteLine(samll);
            #endregion

            #region Q13
            /*Write a program in C# Sharp to find the second largest element in an array.*/
            int[] arrQ13 = { 5, 8, 9, 7, 10, 20, 89, 65, 23 };
            int[] cpy=new int[arrQ13.Length];
            Array.Copy(arrQ13, cpy, arrQ13.Length);
            Array.Sort(cpy);
            int SecondLargest = cpy[cpy.Length-2];
            Console.WriteLine(SecondLargest);


            #endregion
        }
    }
}
