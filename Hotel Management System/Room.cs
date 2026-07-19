using System;

namespace HotelManagementSystem
{
    class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable = true)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }

        public void displayRoom()
        {
            string status = isAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room {roomNumber} | Type: {roomType} | Price: {pricePerNight:F2} | Status: {status}");
        }
    }
}