using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldStop = false;
            Console.WriteLine("Witaj w aplikacji do generowania haseł.");

            while (!shouldStop)
            {
                Console.WriteLine("Komenda 'gen', wypisuje hasło. Dostępne parametry to: '-n'");

                var command = Console.ReadLine();

                string randomPassword = "Ups..";

                if (command != "exit")
                    randomPassword = command == "gen"
                        ? RandomStringGenerator.RandomString(8)
                        : RandomStringGenerator.RandomNumberString(8);
                else
                    shouldStop = true;

                Console.WriteLine("Hasło to:" + randomPassword);
            }
            
            Console.ReadKey();
        }
    }
}
