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
        static void Case02_RegisterNewGuest()
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter check-in date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter number of nights: ");
            if (!int.TryParse(Console.ReadLine(), out int totalNights) || totalNights <= 0)
            {
                Console.WriteLine("Invalid number of nights. Must be a positive integer.");
                return;
            }

            string guestId = "G" + (guests.Count + 1).ToString("D3");

            Guest newGuest = new Guest(guestId, guestName, checkInDate, totalNights);
            guests.Add(newGuest);

            Console.WriteLine("Guest registered successfully!");
            Console.WriteLine($"Guest ID: {guestId} | Name: {guestName} | Check-in: {checkInDate} | Nights: {totalNights}");
        }
        static void Case03_BookRoom()
        {
            Console.Write("Enter guest ID: ");
            string guestId = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Error: Guest not found.");
                return;
            }

            Console.Write("Enter room number: ");
            if (!int.TryParse(Console.ReadLine(), out int roomNumber))
            {
                Console.WriteLine("Invalid room number.");
                return;
            }

            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Error: Room not found.");
                return;
            }

            if (!room.isAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            guest.roomNumber = room.roomNumber.ToString();
            room.isAvailable = false;

            double totalCost = guest.calculateTotalCost(room.pricePerNight);

            Console.WriteLine("Booking confirmed!");
            Console.WriteLine($"Guest: {guest.guestName} | Room: {room.roomNumber} | Type: {room.roomType}");
            Console.WriteLine($"Price/Night: {room.pricePerNight:F2} | Nights: {guest.totalNights} | Total Cost: {totalCost:F2}");
        }
        static void Case04_ViewAllRooms()
        {
            if (rooms.Count == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            var sortedRooms = rooms.OrderBy(r => r.roomNumber).Select(r => r);

            Console.WriteLine($"Total rooms: {rooms.Count()}");
            foreach (var room in sortedRooms)
            {
                string status = room.isAvailable ? "Available" : "Booked";
                Console.WriteLine($"Room {room.roomNumber} | Type: {room.roomType} | Price: {room.pricePerNight:F2} | Status: {status}");
            }
        }
        static void Case05_ViewAllGuests()
        {
            if (guests.Count == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            var sortedGuests = guests.OrderBy(g => g.guestName);

            Console.WriteLine($"Total guests: {guests.Count()}");
            foreach (var guest in sortedGuests)
            {
                Console.WriteLine($"ID: {guest.guestId} | Name: {guest.guestName} | Room: {guest.roomNumber} | Check-in: {guest.checkInDate} | Nights: {guest.totalNights}");
            }
        }
        static void Case06_SearchFilterRooms()
        {
            Console.WriteLine("--- Search & Filter Rooms ---");
            Console.WriteLine("1. Show all available rooms");
            Console.WriteLine("2. Filter by room type");
            Console.WriteLine("3. Filter by max price");
            Console.WriteLine("4. Room price statistics");
            Console.WriteLine("0. Back");
            Console.Write("Enter your choice: ");
            string subChoice = Console.ReadLine();

            switch (subChoice)
            {
                case "1":
                    var availableRooms = rooms.Where(r => r.isAvailable).OrderBy(r => r.pricePerNight).ToList();
                    if (!availableRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }
                    Console.WriteLine($"Available rooms: {availableRooms.Count}");
                    foreach (var r in availableRooms)
                        Console.WriteLine($"Room {r.roomNumber} | Type: {r.roomType} | Price: {r.pricePerNight:F2}");
                    break;

                case "2":
                    Console.Write("Enter room type: ");
                    string type = Console.ReadLine();
                    var typeRooms = rooms.Where(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (!typeRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }
                    Console.WriteLine($"Rooms of type '{type}': {typeRooms.Count}");
                    foreach (var r in typeRooms)
                        Console.WriteLine($"Room {r.roomNumber} | Price: {r.pricePerNight:F2} | Status: {(r.isAvailable ? "Available" : "Booked")}");
                    break;

                case "3":
                    Console.Write("Enter maximum price: ");
                    if (!double.TryParse(Console.ReadLine(), out double maxPrice))
                    {
                        Console.WriteLine("Invalid price.");
                        return;
                    }
                    var affordableRooms = rooms.Where(r => r.isAvailable && r.pricePerNight <= maxPrice)
                                                .OrderBy(r => r.pricePerNight).ToList();
                    if (!affordableRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }
                    Console.WriteLine($"Rooms at or below {maxPrice:F2}: {affordableRooms.Count}");
                    foreach (var r in affordableRooms)
                        Console.WriteLine($"Room {r.roomNumber} | Type: {r.roomType} | Price: {r.pricePerNight:F2}");
                    break;

                case "4":
                    if (!rooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria.");
                        return;
                    }
                    int totalRooms = rooms.Count();
                    int availableCount = rooms.Count(r => r.isAvailable);
                    double avgPrice = rooms.Average(r => r.pricePerNight);
                    double minPrice = rooms.Min(r => r.pricePerNight);
                    double maxPriceStat = rooms.Max(r => r.pricePerNight);

                    Console.WriteLine($"Total rooms: {totalRooms}");
                    Console.WriteLine($"Available rooms: {availableCount}");
                    Console.WriteLine($"Average price: {avgPrice:F2}");
                    Console.WriteLine($"Cheapest price: {minPrice:F2}");
                    Console.WriteLine($"Most expensive price: {maxPriceStat:F2}");
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        static void Case07_GuestBookingStatistics()
        {
            int totalGuests = guests.Count();
            int guestsWithRoom = guests.Count(g => g.roomNumber != "Not Assigned");

            int totalRooms = rooms.Count();
            int bookedRooms = rooms.Count(r => !r.isAvailable);

            Console.WriteLine($"Total guests: {totalGuests} | Guests with a room: {guestsWithRoom}");
            Console.WriteLine($"Total rooms: {totalRooms} | Booked rooms: {bookedRooms}");

            var activeGuests = guests.Where(g => g.roomNumber != "Not Assigned").ToList();

            if (!activeGuests.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            double avgNights = activeGuests.Average(g => g.totalNights);
            Console.WriteLine($"Average nights (active bookings): {avgNights:F2}");

            var topGuests = activeGuests
                .OrderByDescending(g => g.calculateTotalCost(GetRoomPrice(g.roomNumber)))
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 highest-spending guests:");
            foreach (var g in topGuests)
            {
                double cost = g.calculateTotalCost(GetRoomPrice(g.roomNumber));
                Console.WriteLine($"{g.guestName} | Room {g.roomNumber} | Total Cost: {cost:F2}");
            }

            Console.WriteLine("Booking summary:");
            var summaryLines = activeGuests.Select(g =>
                $"{g.guestName} — Room {g.roomNumber} — {g.totalNights} nights — OMR {g.calculateTotalCost(GetRoomPrice(g.roomNumber)):F2}");

            foreach (var line in summaryLines)
                Console.WriteLine(line);
        }

        static double GetRoomPrice(string roomNumber)
        {
            var room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == roomNumber);
            return room != null ? room.pricePerNight : 0;
        }
        static void Case08_UpdateRoomPrice()
        {
            Console.Write("Enter room number: ");
            if (!int.TryParse(Console.ReadLine(), out int roomNumber))
            {
                Console.WriteLine("Invalid room number.");
                return;
            }

            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Error: Room not found.");
                return;
            }

            Console.Write("Enter new price per night: ");
            if (!double.TryParse(Console.ReadLine(), out double newPrice) || newPrice <= 0)
            {
                Console.WriteLine("Invalid price. No change made.");
                return;
            }

            double oldPrice = room.pricePerNight;
            room.pricePerNight = newPrice;

            Console.WriteLine($"Price updated for Room {roomNumber}. Old price: {oldPrice:F2} | New price: {newPrice:F2}");
        }
        static void Case09_GuestLookupByName()
        {
            Console.Write("Enter name or partial name to search: ");
            string search = Console.ReadLine();

            var matches = guests.Where(g => g.guestName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!matches.Any())
            {
                Console.WriteLine("No guests matched that search.");
                return;
            }

            Console.WriteLine($"Matches found: {matches.Count}");
            foreach (var g in matches)
            {
                Console.WriteLine($"ID: {g.guestId} | Name: {g.guestName} | Room: {g.roomNumber}");
            }
        }
        static void Case10_RoomTypeBreakdown()
        {
            string[] types = { "Single", "Double", "Suite" };

            foreach (var type in types)
            {
                int count = rooms.Count(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase));
                string avgDisplay = count > 0
                    ? rooms.Where(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase)).Average(r => r.pricePerNight).ToString("F2")
                    : "N/A";

                Console.WriteLine($"{type}: {count} room(s) | Average price: {avgDisplay}");
            }

            if (rooms.Any())
            {
                double overallAvg = rooms.Average(r => r.pricePerNight);
                Console.WriteLine($"Overall average price: {overallAvg:F2}");
            }
            else
            {
                Console.WriteLine("Overall average price: N/A");
            }
        }
        static void Case11_CheckOutGuest()
        {
            Console.Write("Enter guest ID to check out: ");
            string guestId = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Error: Guest not found.");
                return;
            }

            if (guest.roomNumber == "Not Assigned")
            {
                Console.WriteLine("This guest has no active booking.");
                return;
            }

            Room room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == guest.roomNumber);
            if (room == null)
            {
                Console.WriteLine("Error: Linked room not found.");
                return;
            }

            double totalCost = guest.calculateTotalCost(room.pricePerNight);

            Console.WriteLine("----- Final Bill -----");
            Console.WriteLine($"Guest: {guest.guestName} | Room: {room.roomNumber} | Type: {room.roomType}");
            Console.WriteLine($"Check-in: {guest.checkInDate} | Nights: {guest.totalNights} | Price/Night: {room.pricePerNight:F2}");
            Console.WriteLine($"Total Cost: {totalCost:F2}");

            Console.Write("Confirm checkout? (Y/N): ");
            string confirm = Console.ReadLine();

            if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                room.isAvailable = true;
                guests.Remove(guest);

                Console.WriteLine("Checkout complete.");
                Console.WriteLine($"Remaining guests: {guests.Count} | Total rooms: {rooms.Count}");
                bool isNowAvailable = rooms.Any(r => r.roomNumber == room.roomNumber && r.isAvailable);
                Console.WriteLine($"Room {room.roomNumber} is now available: {isNowAvailable}");
            }
            else
            {
                Console.WriteLine("Checkout cancelled. No changes made.");
            }
        }
        static void Case12_RemoveUnavailableRooms()
        {
            var removableRooms = rooms
                .Where(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber.ToString()))
                .OrderBy(r => r.roomNumber)
                .ToList();

            if (!removableRooms.Any())
            {
                Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                return;
            }

            Console.WriteLine($"Removable rooms: {removableRooms.Count}");
            foreach (var r in removableRooms)
            {
                Console.WriteLine($"Room {r.roomNumber} | Type: {r.roomType} | Price: {r.pricePerNight:F2}");
            }

            Console.Write("Confirm removal? (Y/N): ");
            string confirm = Console.ReadLine();

            if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                rooms.RemoveAll(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber.ToString()));

                Console.WriteLine($"Removal complete. Total rooms now: {rooms.Count}");
                var remaining = rooms.Select(r => new { r.roomNumber, r.roomType });
                foreach (var r in remaining)
                    Console.WriteLine($"Room {r.roomNumber} | Type: {r.roomType}");
            }
            else
            {
                Console.WriteLine("Removal cancelled. No rooms were removed.");
            }
        }
        static void Case13_ExtendGuestStay()
        {
            Console.Write("Enter guest ID: ");
            string guestId = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Error: Guest not found.");
                return;
            }

            if (guest.roomNumber == "Not Assigned")
            {
                Console.WriteLine("This guest has no active booking to extend.");
                return;
            }

            Console.Write("Enter additional nights: ");
            if (!int.TryParse(Console.ReadLine(), out int additionalNights) || additionalNights <= 0)
            {
                Console.WriteLine("Invalid input. Additional nights must be a positive number. No change made.");
                return;
            }

            guest.totalNights += additionalNights;

            double roomPrice = GetRoomPrice(guest.roomNumber);
            double newTotalCost = guest.calculateTotalCost(roomPrice);

            Console.WriteLine($"Stay extended. New total nights: {guest.totalNights} | New total cost: {newTotalCost:F2}");
        }
        static void Case14_HighestRevenueBooking()
        {
            var activeGuests = guests.Where(g => g.roomNumber != "Not Assigned").ToList();

            if (!activeGuests.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            var topBooking = activeGuests
                .Select(g => new
                {
                    g.guestName,
                    g.roomNumber,
                    TotalCost = g.calculateTotalCost(GetRoomPrice(g.roomNumber))
                })
                .OrderByDescending(x => x.TotalCost)
                .Take(1)
                .First();

            Console.WriteLine("Highest revenue booking:");
            Console.WriteLine($"Guest: {topBooking.guestName} | Room: {topBooking.roomNumber} | Total Cost: {topBooking.TotalCost:F2}");
        }
        static void Case15_GuestPaginationViewer()
        {
            const int pageSize = 3;

            if (!guests.Any())
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            int totalPages = (int)Math.Ceiling(guests.Count / (double)pageSize);

            Console.Write($"Enter page number (1 to {totalPages}): ");
            if (!int.TryParse(Console.ReadLine(), out int pageNumber) || pageNumber < 1 || pageNumber > totalPages)
            {
                Console.WriteLine("That page does not exist.");
                return;
            }

            var pageGuests = guests
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            Console.WriteLine($"Page {pageNumber} of {totalPages}:");
            foreach (var g in pageGuests)
            {
                Console.WriteLine($"ID: {g.guestId} | Name: {g.guestName} | Room: {g.roomNumber}");
            }
        }
    }
}
