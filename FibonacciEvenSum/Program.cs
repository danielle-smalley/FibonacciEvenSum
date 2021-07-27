using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
     * Each new term in the Fibonacci sequence is generated
        by adding the previous two terms. By starting with
        1 and 2, the first 10 terms will be:

        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

        By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

        Remember to commit changes to the repository. Submit your repo url to this assignment.*/

            int n1 = 1; //first fibo number
            int n2 = 1; //second fibo number
            int n3 = 0; //result, starting this at 0 and adding math below to increase each time
            int sum = 0; //start counter for sum at 0

            //for (int i = 2; i < 4000000; i++)
            //{

            //}
            while (n3 < 4000000) //so while result number is less than 4mil, do this:
            {
                n3 = n1 + n2; //calculation to get fibonacci numbers while less than 4mil
                //n1 = n2;
                //n2 = n3;
                if (n3 % 2 == 0) //if n3 (result) is divisible by 2 (even), then add to sum counter
                {
                    sum += n3; //add the sums for even numbers
                }
                n1 = n2; //the 1st fibo number becomes the 2nd fibo number
                n2 = n3;//the 2nd fibo number becomes the result number, so these are 'resetting' things in a way
            }
            Console.WriteLine(sum); //display the sum

        }
    }
}
