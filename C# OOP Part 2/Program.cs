using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room { roomNumber = 101, roomType = "Single", pricePerNight = 20.000, isAvailable = true });
            rooms.Add(new Room { roomNumber = 102, roomType = "Single", pricePerNight = 22.000, isAvailable = true });
            rooms.Add(new Room { roomNumber = 201, roomType = "Double", pricePerNight = 35.000, isAvailable = true });
            rooms.Add(new Room { roomNumber = 202, roomType = "Double", pricePerNight = 38.000, isAvailable = true });
            rooms.Add(new Room { roomNumber = 301, roomType = "Suite", pricePerNight = 60.000, isAvailable = true });
            rooms.Add(new Room { roomNumber = 302, roomType = "Suite", pricePerNight = 65.000, isAvailable = true });

            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine();
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("16. Exit");
                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        {
                            // Case 01 Add New Room
                            Console.Write("Enter room number: ");
                            int newRoomNumber;
                            if (!int.TryParse(Console.ReadLine(), out newRoomNumber) || newRoomNumber <= 0)
                            {
                                Console.WriteLine("Room number must be a positive number.");
                                break;
                            }

                            Console.Write("Enter room type (Single/Double/Suite): ");
                            string newRoomType = Console.ReadLine();

                            Console.Write("Enter price per night: ");
                            double newPrice;
                            if (!double.TryParse(Console.ReadLine(), out newPrice) || newPrice <= 0)
                            {
                                Console.WriteLine("Price per night must be a positive number.");
                                break;
                            }

                            if (rooms.Any(r => r.roomNumber == newRoomNumber))
                            {
                                Console.WriteLine("Error: A room with this number already exists.");
                                break;
                            }

                            Room newRoom = new Room { roomNumber = newRoomNumber, roomType = newRoomType, pricePerNight = newPrice, isAvailable = true };
                            rooms.Add(newRoom);

                            Console.WriteLine("Room added successfully!");
                            Console.WriteLine("Room #" + newRoomNumber + " | " + newRoomType + " | OMR " + newPrice.ToString("F2") + "/night");
                            Console.WriteLine("Total rooms: " + rooms.Count);
                            break;
                        }
                    case 2:
                        {
                            // Case 02 Register New Guest
                            Console.Write("Enter guest name: ");
                            string newGuestName = Console.ReadLine();

                            Console.Write("Enter check-in date: ");
                            string newCheckInDate = Console.ReadLine();

                            Console.Write("Enter number of nights: ");
                            int newTotalNights;
                            if (!int.TryParse(Console.ReadLine(), out newTotalNights) || newTotalNights <= 0)
                            {
                                Console.WriteLine("Number of nights must be a positive number.");
                                break;
                            }

                            string newGuestId = "G" + (guests.Count + 1).ToString("D3");

                            Guest newGuest = new Guest
                            {
                                guestId = newGuestId,
                                guestName = newGuestName,
                                roomNumber = "Not Assigned",
                                checkInDate = newCheckInDate,
                                totalNights = newTotalNights
                            };
                            guests.Add(newGuest);

                            Console.WriteLine("Guest registered successfully!");
                            Console.WriteLine(newGuestId + " | " + newGuestName + " | Check-in: " + newCheckInDate + " | Nights: " + newTotalNights);
                            break;
                        }
                    case 3:
                        {
                            // Case 03 Book a Room for a Guest 
                            Console.Write("Enter guest ID: ");
                            string bookGuestId = Console.ReadLine();

                            Console.Write("Enter room number: ");
                            int bookRoomNumber;
                            if (!int.TryParse(Console.ReadLine(), out bookRoomNumber))
                            {
                                Console.WriteLine("Invalid room number.");
                                break;
                            }

                            Guest bookGuest = guests.FirstOrDefault(g => g.guestId == bookGuestId);
                            if (bookGuest == null)
                            {
                                Console.WriteLine("Error: Guest not found.");
                                break;
                            }

                            Room bookRoom = rooms.FirstOrDefault(r => r.roomNumber == bookRoomNumber);
                            if (bookRoom == null)
                            {
                                Console.WriteLine("Error: Room not found.");
                                break;
                            }

                            if (!bookRoom.isAvailable)
                            {
                                Console.WriteLine("Room is already booked.");
                                break;
                            }

                            bookGuest.roomNumber = bookRoom.roomNumber.ToString();
                            bookGuest.pricePerNight = bookRoom.pricePerNight;
                            bookRoom.isAvailable = false;

                            Console.WriteLine("Booking confirmed!");
                            Console.WriteLine("Guest: " + bookGuest.guestName);
                            Console.WriteLine("Room: " + bookRoom.roomNumber + " (" + bookRoom.roomType + ")");
                            Console.WriteLine("Price per night: OMR " + bookRoom.pricePerNight.ToString("F2"));
                            Console.WriteLine("Total nights: " + bookGuest.totalNights);
                            Console.WriteLine("Total cost: OMR " + bookGuest.calculateTotalCost().ToString("F2"));
                            break;
                        }
                    case 4:
                        {
                            // Case 04 View All Rooms 
                            Console.WriteLine("Total rooms: " + rooms.Count());
                            if (!rooms.Any())
                            {
                                Console.WriteLine("No rooms have been added yet.");
                                break;
                            }

                            var sortedRooms = rooms.OrderBy(r => r.roomNumber);
                            foreach (Room r in sortedRooms)
                            {
                                r.displayRoom();
                            }
                            break;
                        }
                    case 5:
                        {
                            // Case 05 View All Guests
                            Console.WriteLine("Total guests: " + guests.Count());
                            if (!guests.Any())
                            {
                                Console.WriteLine("No guests have been registered yet.");
                                break;
                            }

                            var sortedGuests = guests.OrderBy(g => g.guestName);
                            foreach (Guest g in sortedGuests)
                            {
                                g.displayGuest();
                            }
                            break;
                        }
                    case 6:
                        Console.WriteLine("Case 6");
                        break;
                    case 7:
                        Console.WriteLine("Case 7");
                        break;
                    case 8:
                        Console.WriteLine("Case 8");
                        break;
                    case 9:
                        Console.WriteLine("Case 9");
                        break;
                    case 10:
                        Console.WriteLine("Case 10");
                        break;
                    case 11:
                        Console.WriteLine("Case 11");
                        break;
                    case 12:
                        Console.WriteLine("Case 12");
                        break;
                    case 13:
                        Console.WriteLine("Case 13");
                        break;
                    case 14:
                        Console.WriteLine("Case 14");
                        break;
                    case 15:
                        Console.WriteLine("Case 15");
                        break;
                    case 16:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 0 and 15.");
                        break;
                }
            }
        }
    }
}