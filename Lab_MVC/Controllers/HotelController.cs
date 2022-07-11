using Lab_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_MVC.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllRooms()
        {
            return View();
        }

        public IActionResult AllRooms()
        {
             return View(Hotel.Rooms);  
        }

        public IActionResult TotalCapacity()
        {
            ViewBag.totalCapacity = Hotel.TotalCapacityRemaining();
            return View();
        }

        public IActionResult Room(int? guests)
        {
            Room room = Hotel.Rooms.First(r => r.Capacity >= guests);
            return View(room);
        }

    }
}

//couldn't figure out the errors
