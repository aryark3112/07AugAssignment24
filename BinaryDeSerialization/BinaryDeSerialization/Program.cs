using EmployeeLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDeSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream writer = new FileStream("D:\\07August\\Assignment24\\BinarySerialization\\BinarySerialization\\employee.bin", FileMode.Open))
            {
                Employee desEmployee = (Employee)formatter.Deserialize(writer);

                Console.WriteLine("Binary Deserialization");
                Console.WriteLine("Employee Id: " + desEmployee.Id);
                Console.WriteLine("Employee First Name: " + desEmployee.FirstName);
                Console.WriteLine("Employee Last Name: " + desEmployee.LastName);
                Console.WriteLine("Salary: " + desEmployee.Salary);
            }

            Console.WriteLine("\nBinary Deserialization Complete");
            Console.ReadKey();
        }
    }
}
