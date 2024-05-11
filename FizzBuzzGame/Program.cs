using System;

namespace FizzBuzzGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj serdecznie w grze FizzBuzz");
            Console.WriteLine("\nW grze należy podać dowolną liczbę.");
            Console.WriteLine("\nJeżeli twoja liczba będzie podzielna przez 3 bez reszty, to otrzymasz wynik 'Fizz'.");
            Console.WriteLine("Jak będzie podzielna przez 5 bez reszty, to otrzymasz wynik 'Buzz'.");
            Console.WriteLine("W przypadku jak będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to otrzymasz wynik 'FizzBuzz'.");
            Console.WriteLine("Jeżeli jednak liczba nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy otrzymasz zwróconą liczbę.");
            Console.WriteLine("ZACZYNAMY!");
            var FizzBuzz = new FizzBuzz();


            while (true)
            {
                Console.WriteLine("\nPodaj dowolną liczbę: ");
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
