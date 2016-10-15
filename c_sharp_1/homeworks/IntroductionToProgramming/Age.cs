using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Age
{
    class Age
    {
        static void Main()
        {
            string born;
            string pattern = "MM.dd.yyyy";
            DateTime dBorn;
            Regex pCheck = new Regex(@"^\d{2}.\d{2}.\d{4}");
            born = Console.ReadLine();

            if (pCheck.IsMatch(born) == false) Environment.Exit(0);

            DateTime.TryParseExact(born, pattern, null, DateTimeStyles.None, out dBorn);

            if (dBorn.Year >= 2017) Environment.Exit(0);
            if (dBorn.Month < DateTime.Now.Month || (dBorn.Month == DateTime.Now.Month && dBorn.Day <= DateTime.Now.Day))
            {
                if (dBorn.Year == DateTime.Now.Year)
                {
                    Console.WriteLine(0);
                    Console.WriteLine(10);
                }
                else
                {
                    Console.WriteLine(DateTime.Now.Year - dBorn.Year);
                    Console.WriteLine(DateTime.Now.Year - dBorn.Year + 10);
                }

            }
            else
            if (dBorn.Month > DateTime.Now.Month || (dBorn.Month == DateTime.Now.Month && dBorn.Day > DateTime.Now.Day))
            {
                if (dBorn.Year == DateTime.Now.Year)
                {
                    Console.WriteLine(0);
                    Console.WriteLine(9);
                }
                else
                {
                    Console.WriteLine(DateTime.Now.Year - dBorn.Year - 1);
                    Console.WriteLine(DateTime.Now.Year - dBorn.Year + 9);
                }
            }
        }
    }
}
