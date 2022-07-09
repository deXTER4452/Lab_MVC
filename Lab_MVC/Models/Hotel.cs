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

       List<Client> TopThreeClients()
        {
            List<Client> topClients = new List<Client>();

            //foreach (Reservation r in Reservations.OrderByDescending(x => x.)
            //{
            //    topClients.Add(client);
            //}
            return topClients.ToList();

            //Couldn't figure out the algorithm


        }

        Reservation AutomaticReservation(int clientID, int occupants, DateTime date)
        {
            Reservation reservation = null;
            Client client = null;

            Room room = Rooms.First(r => r.Occupied == false && r.Capacity >= occupants);

            if (room.Reservations.Any(room => room.Date == date)) // check if already reserved for that time
                                                                  // took from a example from stack overflow
            {
                return null;

            }

            //if such room exists, make a reservation

            if(room != null)
            {
                reservation = new Reservation();
                reservation.Occupants = occupants;
                client = GetClient(clientID);
                reservation.Client = client;
            }

            room.Reservations.Add(reservation);
            client.Reservations.Add(reservation);

            return reservation;
        }
    }  
}
