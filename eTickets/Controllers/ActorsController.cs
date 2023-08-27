using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.AddAsync(actor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            
            return View(actorDetails);
        }

        public async  Task<IActionResult> Edit(int id)
        {
            var values = await _actorsService.GetByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.UpdateAsync(id, actor);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");

            await _actorsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }





    }
}
