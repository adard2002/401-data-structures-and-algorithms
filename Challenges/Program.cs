using Challenges.ArrayChallenges;
using System;


namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Reverse:");
            
            int[] exampleArray1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] reversedArray1 = ArrayReverse.Reverse(exampleArray1);
            Console.WriteLine("Should be 6, 5, 4, 3, 2, 1: {0}", string.Join(", ", reversedArray1));


        }
    }
}