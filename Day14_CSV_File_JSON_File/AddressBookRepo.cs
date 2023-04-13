using CsvHelper;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Day14_CSV_File_JSON_File
{
    public class AddressBookRepo
    {
        public static void AddContact()
        {
            string filePath = @"E:\BridgeLabz\RFP 267\Day14_CSV_File_JSON_File\Day14_CSV_File_JSON_File\CSV_File\AddressBook1.csv";
            AddressBook contact = new AddressBook();
            StreamWriter streamWriter = new StreamWriter(filePath,append: true);
            CsvWriter csvwriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
            Console.WriteLine("Enter First name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address");
            contact.Email = Console.ReadLine();

            List<AddressBook> contacts = new List<AddressBook>();
            contacts.Add(contact);
            csvwriter.WriteRecords(contacts);
            streamWriter.Flush();

        }

        public static void ReadDataFromCSVFile()
        {
            string filePath = @"E:\BridgeLabz\RFP 267\Day14_CSV_File_JSON_File\Day14_CSV_File_JSON_File\CSV_File\AddressBook1.csv";
            StreamReader streamReader = new StreamReader(filePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            List<AddressBook> addressBooks = csvReader.GetRecords<AddressBook>().ToList();
            
                foreach (var contact in addressBooks)
                {
                    Console.WriteLine("FirstName " + contact.FirstName + "\nLastName " + contact.LastName + "\nAddress " + contact.Address + "\nCity " + contact.City + "\nZip " + contact.Zip + "\nPhoneNumber " + contact.PhoneNumber + "\nEmail " + contact.Email);
                } 
        }
        public static void WriteDataIntoJSONFile()
        {
            AddressBook contact=new AddressBook();
            Console.WriteLine("Enter First name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address");
            contact.Email = Console.ReadLine();
        
            string filePath = @"E:\BridgeLabz\RFP 267\Day14_CSV_File_JSON_File\Day14_CSV_File_JSON_File\Contact.json";
            //string json = new JavaScriptSerializer().Serialize(contact);
            //string json = JsonSerializer.Serialize(contact);
            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(filePath, json);
        }

        public static void ReadDataFromJSONFile()
        {
            string filePath = @"E:\BridgeLabz\RFP 267\Day14_CSV_File_JSON_File\Day14_CSV_File_JSON_File\Contact.json";
            string json = File.ReadAllText(filePath);
           // var contact = JsonSerializer.Deserialize<AddressBook>(json);
            var contact = JsonConvert.DeserializeObject(json);
            Console.WriteLine(contact);
        }
    }
}
