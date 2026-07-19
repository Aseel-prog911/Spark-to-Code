using System;
using System.Linq;
using System.Collections.Generic;

namespace Hotel_Management_System
{
    class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        static void Main(string[] args)
        {
            SeedRooms();

            bool running = true;
            while (running)
            {
                PrintMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Case01_AddNewRoom(); break;
                    case "2": Case02_RegisterNewGuest(); break;
                    case "3": Case03_BookRoom(); break;
                    case "4": Case04_ViewAllRooms(); break;
                    case "5": Case05_ViewAllGuests(); break;
                    case "6": Case06_SearchFilterRooms(); break;
                    case "7": Case07_GuestBookingStatistics(); break;
                    case "8": Case08_UpdateRoomPrice(); break;
                    case "9": Case09_GuestLookupByName(); break;
                    case "10": Case10_RoomTypeBreakdown(); break;
                    case "11": Case11_CheckOutGuest(); break;
                    case "12": Case12_RemoveUnavailableRooms(); break;
                    case "13": Case13_ExtendGuestStay(); break;
                    case "14": Case14_HighestRevenueBooking(); break;
                    case "15": Case15_GuestPaginationViewer(); break;
                    case "0": running = false; Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
                Console.WriteLine();
            }
        }

        static void SeedRooms()
        {
            rooms.Add(new Room(101, "Single", 25.000));
            rooms.Add(new Room(102, "Single", 25.000));
            rooms.Add(new Room(201, "Double", 40.000));
            rooms.Add(new Room(202, "Double", 42.500));
            rooms.Add(new Room(301, "Suite", 80.000));
            rooms.Add(new Room(302, "Suite", 95.000));
        }

        static void PrintMenu()
        {
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
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("================================================");
            Console.Write("Enter your choice: ");
        }

        static void Case01_AddNewRoom()
        {
            Console.Write("Enter room number: ");
            if (!int.TryParse(Console.ReadLine(), out int roomNumber) || roomNumber <= 0)
            {
                Console.WriteLine("Invalid room number. Must be a positive number.");
                return;
            }

            if (rooms.Any(r => r.roomNumber == roomNumber))
            {
                Console.WriteLine("Error: A room with this number already exists.");
                return;
            }

            Console.Write("Enter room type (Single/Double/Suite): ");
            string roomType = Console.ReadLine();

            Console.Write("Enter price per night: ");
            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
            {
                Console.WriteLine("Invalid price. Must be a positive number.");
                return;
            }

            Room newRoom = new Room(roomNumber, roomType, price);
            rooms.Add(newRoom);

            Console.WriteLine("Room added successfully!");
            Console.WriteLine($"Room {roomNumber} | Type: {roomType} | Price: {price:F2}");
            Console.WriteLine($"Total rooms now: {rooms.Count}");
        }
        static void Case02_RegisterNewGuest() { }
        static void Case03_BookRoom() { }
        static void Case04_ViewAllRooms() { }
        static void Case05_ViewAllGuests() { }
        static void Case06_SearchFilterRooms() { }
        static void Case07_GuestBookingStatistics() { }
        static void Case08_UpdateRoomPrice() { }
        static void Case09_GuestLookupByName() { }
        static void Case10_RoomTypeBreakdown() { }
        static void Case11_CheckOutGuest() { }
        static void Case12_RemoveUnavailableRooms() { }
        static void Case13_ExtendGuestStay() { }
        static void Case14_HighestRevenueBooking() { }
        static void Case15_GuestPaginationViewer() { }
    }
}
