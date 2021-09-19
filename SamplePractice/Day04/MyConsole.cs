using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePractice.Day04
{
    static class MyConsole
    {
        public static uint GetNumber(string question)
        {
            uint res;
        LABEL:
            Console.WriteLine(question); if (!uint.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Invalid Number, Enter a whole number");
                goto LABEL;
            }
            return res;
        }
        public static double GetDouble(string question)
        {
            double res;
        LABEL:
            Console.WriteLine(question); if (!double.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Invalid Number, Enter a decimal number");
                goto LABEL;
            }
            return res;
        }
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static DateTime GetDate(string question)
        {
            DateTime res;
        LABEL:
            Console.WriteLine(question); if (!DateTime.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("given date is not a valid date");
                goto LABEL;
            }
            return res;
        }

        internal static object GetBook()
        {
            throw new NotImplementedException();
        }
    }
}