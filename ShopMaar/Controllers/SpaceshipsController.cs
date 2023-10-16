using Microsoft.AspNetCore.Mvc;
using ShopMaar.Data;
using ShopMaar.Models;
using ShopMaar.Models.Spaceship;

namespace ShopMaar.Controllers
{
    public class SpaceshipsController : Controller
    {
        private readonly ShopMaarContext _context;
        public SpaceshipsController(ShopMaarContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.spaceships
                .OrderBy(x => x.CreatedAt)
                .Select(x => new SpaceshipIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.Type,
                    PassengerCount = x.PassengerCount,
                    EnginePower = x.EnginePower,
                });
            return View(result);
        }
        public IActionResult Add()
        {
            return View("Edit");
        }
    }
}