using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        const string FILE = "employees.txt";
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[100];
            int numberofEmployee = 0;
            String[] input;

            //try
            //{
            StreamReader employeereader = new StreamReader(FILE); 
                while (!employeereader.EndOfStream)
            {
                input = employeereader.ReadLine().Split(',');
                employee[numberofEmployee] = new Employee(input[0], Int32.Parse(input[1]), Decimal.Parse(input[2]), Double.Parse(input[3]));
                numberofEmployee++;
            }
            employeereader.Close();

            for (int i = 0; i < numberofEmployee; i++)
            {
                Console.WriteLine(employee[i]);
            }
            //  }
            // catch(IOException ex)
            // {

            // Console.WriteLine("Your file name doesn't match!. ");
            // }

            Console.WriteLine("Enter your choice: ");
            String option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(employee[i]);
                    }
                    break;
            }

        }

    }
}
