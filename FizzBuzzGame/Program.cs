using System;

namespace FizzBuzzGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj serdecznie w grze FizzBuzz");
            var FizzBuzz = new FizzBuzz();


            while (true)
            {
                Console.WriteLine("Podaj dowolną liczbę: ");
                var number = GetNumber();
                Console.WriteLine(FizzBuzz.GetOut(number));
                Console.WriteLine();
            }

        }

        private static int GetNumber()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "Q")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(val, out int number))
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie - podaj dowolną liczbę: ");
                    continue;

                }
                return number;
            }
        }
    }
}
