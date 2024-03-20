using Akog_Assignment2;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize variables to store sums
            int evenSum = 0;
            int oddSum = 0;

            // Create NumberChecker object
            var numberEven = new NumberChecker();


            for (int num = 0; num < 10; num++)
            {
                if (numberEven.IsEven(num))
                {
                    Console.WriteLine($"{num} is an even number.");
                    evenSum += num;
                }
                else
                {
                    Console.WriteLine($"{num} is an odd number.");
                    oddSum += num;
                }
            }


            Console.WriteLine($"Total of even numbers : {evenSum}");
            Console.WriteLine($"Total of odd numbers : {oddSum}");
        }
    }
}
