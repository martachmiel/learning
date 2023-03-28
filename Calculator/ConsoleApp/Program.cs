namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Wyświetlenie jakiegoś nagłówka - opis aplikacji
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");

            while (true)
            {
                try
                {
                    //2. Prośba o podanie 1 liczby
                    Console.WriteLine("Wpisz proszę 1 liczbę:");

                    //3. Pobranie liczby od użytkownika
                    var number1 = GetInput();

                    //4. Prośba o podanie działania
                    Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");

                    //5. Pobranie wybranego działania od użytkownika + dodanie do zmiennej
                    var operation = Console.ReadLine();

                    //6. Prośba o podanie 2 liczby
                    Console.WriteLine("Wpisz proszę 2 liczbę:");

                    //7. Pobranie liczby od użytkownika
                    var number2 = GetInput();

                    var result = Calculate(number1, number2, operation);   //8. Wykonanie obliczeń

                    //9. Wyświetlenie wyniku użytkownikowi
                    Console.WriteLine($"Wynik Twojego działania to: {Math.Round(result, 2)}.");
                }
                catch (Exception ex)
                {
                    //logowanie do pliku
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartość nie jest liczbą.");

            return input;
        }

        private static double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
        }
    }
}