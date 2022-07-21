using System;

namespace TryCatchAndFinallyChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = 19;
            int int2 = 0;

            try
            {
                int divide = int1 / int2;
                Console.WriteLine($"int1 {int1} divided by int2 {int2}: {divide}");
            }

            catch (Exception)
            {
                Console.WriteLine("You can't divide by 0");
            }
            
        }
    }
}
