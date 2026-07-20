using System;

namespace HotelManagementSystem
{
    class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public void displayRoom()
        {
            string status = isAvailable ? "Available" : "Booked";
            Console.WriteLine("Room #" + roomNumber + " | " + roomType + " | OMR " + pricePerNight.ToString("F2") + "/night | " + status);
        }
    }
}