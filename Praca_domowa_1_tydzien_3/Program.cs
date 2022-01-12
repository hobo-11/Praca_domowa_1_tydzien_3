using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_domowa_1_tydzien_3
{
    class Program
    {
        private static int GetIntInput()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Spróbuj wprowadzić poprawną wartość jeszcze raz!");
                    continue;
                }
                return input;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź swoje imie: ");
            var name = Console.ReadLine();

            Console.WriteLine("Wprowadź swój rok urodzenia: ");
            var bornYear = GetIntInput();

            Console.WriteLine("Wprowdź miesiąc urodzenia: ");
            var bornMonth = GetIntInput();

            Console.WriteLine("Wprowadź dzień urodzenia: ");
            var bornDay = GetIntInput();

            Console.WriteLine("Wprowadź miejsce urodzenia: ");
            var bornPlace = Console.ReadLine();

            var years = DateTime.Now.Year - bornYear;
            var actualMonth = DateTime.Now.Month;
            var actualDay = DateTime.Now.Day;

            if ((actualMonth < bornMonth) || (actualMonth == bornMonth && actualDay < bornDay))
            {
                years--;
            }
            
            Console.WriteLine($"Cześć {name} urodziłeś się w {bornPlace} i masz {years} lat");
            Console.ReadLine();
        }
    }
}
