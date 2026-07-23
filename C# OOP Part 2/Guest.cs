using System;

namespace HotelManagementSystem
{
    class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;
        public double pricePerNight;

        public void displayGuest()
        {
            Console.WriteLine(guestId + " | " + guestName + " | Room: " + roomNumber + " | Check-in: " + checkInDate + " | Nights: " + totalNights);
        }

        public double calculateTotalCost()
        {
            return totalNights * pricePerNight;
        }
    }
}