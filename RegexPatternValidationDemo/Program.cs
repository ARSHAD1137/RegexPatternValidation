using System;

namespace RegexPatternValidationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            Console.WriteLine(pattern.validationPincode("400088"));
        }
    }
}
