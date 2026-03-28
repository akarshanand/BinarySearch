using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 0, upperBound = 100;
            int numOfIterations = 0;
            Console.Write("Enter the number you want to search: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n > upperBound || n < lowerBound)
            {
                Console.WriteLine("Input out of bounds");
                return;
            }
            int numUnderConsideration = (upperBound + lowerBound) / 2;
            while(numUnderConsideration != n)
            {
                if(n > numUnderConsideration)
                {
                    lowerBound = numUnderConsideration;
                    numUnderConsideration = (numUnderConsideration + upperBound) / 2;
                }
                else
                {
                    upperBound = numUnderConsideration;
                    numUnderConsideration = (numUnderConsideration + lowerBound) / 2;
                }
                numOfIterations++;
            }
            Console.WriteLine(numOfIterations);
        }
    }
}
