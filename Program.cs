using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseLinkedList houseList = new HouseLinkedList();

            houseList.AddHouse(1, "123 Main Street", "Colonial");
            houseList.AddHouse(2, "456 Oak Avenue", "Ranch");
            houseList.AddHouse(3, "789 Elm Road", "Cottage");

            Console.Write("Enter the house number to search: ");
            int searchHouseNumber = int.Parse(Console.ReadLine());

            House foundHouse = houseList.SearchHouse(searchHouseNumber);
            if (foundHouse != null)
            {
                Console.WriteLine("\nHouse Details:");
                Console.WriteLine("House Number: " + foundHouse.HouseNumber);
                Console.WriteLine("Address: " + foundHouse.Address);
                Console.WriteLine("House Type: " + foundHouse.HouseType);
            }
            else
            {
                Console.WriteLine("\nHouse with number " + searchHouseNumber + " not found.");
            }
            Console.ReadKey();
        }
    }
}
