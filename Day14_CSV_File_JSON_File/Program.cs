using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_CSV_File_JSON_File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 14 Practice Problem CSV file JSON file ");
            Console.WriteLine("Select option for\n" +
                "1. For Write data into CSV file\n" +
                "2. For Read data from CSV file");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    AddressBookRepo.AddContact();
                    break;
                case 2:
                    AddressBookRepo.ReadDataFromCSVFile();
                    break;
                default:
                    Console.WriteLine("Select Correct Option");
                    break;
            }
        }
    }
}
