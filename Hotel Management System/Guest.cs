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

        public Guest(string guestId, string guestName, string checkInDate, int totalNights, string roomNumber = "Not Assigned")
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }

        public void displayGuest()
        {
            Console.WriteLine($"ID: {guestId} | Name: {guestName} | Room: {roomNumber} | Check-in: {checkInDate} | Nights: {totalNights}");
        }

        public double calculateTotalCost(double pricePerNight)
        {
            return pricePerNight * totalNights;
        }
    }
}