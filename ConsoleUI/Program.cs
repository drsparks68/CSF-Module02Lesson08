using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            string addMore;
            int studentCount = 0;

            do
            {
                Console.WriteLine("Please enter student name: ");
                studentNames.Add(Console.ReadLine());
                
                Console.WriteLine("Do you have another name to add? (y/n)");
                string askMore = Console.ReadLine();
                addMore = askMore.ToLower();
                studentCount ++;
            } while (addMore == "y");

            Console.WriteLine($"Thanks.  There are { studentCount } students in this class");

            Console.ReadLine();
        }
    }
}
