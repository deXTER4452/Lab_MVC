namespace Lab_MVC.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime Date { get; set; }
        public int Occupants { get; set; }
        public bool IsCurrent { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }


        // CONSTRUCTORS
        public Reservation() { }
        public Reservation(int id, int occupants, Client client, Room room)
        {
            ReservationId = id;
            Date = DateTime.Now;
            Occupants = occupants;
            IsCurrent = true;
            Client = client;
            Room = room;
        }
    }
}
