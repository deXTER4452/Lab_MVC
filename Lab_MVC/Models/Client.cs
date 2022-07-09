namespace Lab_MVC.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int CreditCard { get; set; }
        public List<Reservation> Reservations { get; set; }
       

        public Client()
        {
            Reservations = new List<Reservation>();
            
        }

        public Client(int id, string name, int creditCard)
        {
            ClientId = id;
            Name = name;
            CreditCard = creditCard;
            Reservations = new List<Reservation>();
           
        }
    }
}
