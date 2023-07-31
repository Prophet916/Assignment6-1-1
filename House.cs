using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1_1
{
    internal class House
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }
        public House Next { get; set; }

        public House(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
            Next = null;
        }
    }

    class HouseLinkedList
    {
        private House head;

        public HouseLinkedList()
        {
            head = null;
        }

        public void AddHouse(int houseNumber, string address, string houseType)
        {
            House newHouse = new House(houseNumber, address, houseType);
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                House current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHouse;
            }
        }

        public House SearchHouse(int houseNumber)
        {
            House current = head;
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
    }
}
