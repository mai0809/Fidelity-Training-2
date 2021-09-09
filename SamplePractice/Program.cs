using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePractice
{
    

namespace SampleTest
    {
        class NewClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Name please");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Age please");
                string age = Console.ReadLine();

                Console.WriteLine("Enter the salary");
                double salary = double.Parse(Console.ReadLine());

                Console.WriteLine("the name is {0} from age {1} whose qualification {2}", name, age, salary);
            }
        }
    }
}

