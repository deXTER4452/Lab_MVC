namespace Lab_MVC.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Client> Clients { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Hotel(string name, string address)
        {
            Name = name;
            Address = address;
            Clients = new List<Client>();
            Rooms = new List<Room>();
            Reservations = new List<Reservation>();
        }

        Client GetClient(int ClientID)
        {
            Client client = Clients.First(c => c.ClientId == ClientID);
            return client;
        }

        Reservation GetReservation(int ID)
        {
            Reservation reservation = Reservations.First(r => r.ReservationId == ID);
            return reservation;

        }

        Room GetRoom(string roomNumber)
        {
            Room room = Rooms.First(r => r.Number == roomNumber);
            return room;
        }

        List<Room> GetVacantRooms()
        {
            List<Room> rooms = Rooms.FindAll(r => r.Occupied == false);
            return rooms.ToList();
        }

      // topThreeClients
      //automaticReservation
      //

    }
}
