using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{

    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        // Get : Cinemas/Create
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo", "Name", "Decription")] Cinema Cinema)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(Cinema);
                return RedirectToAction("Index");
            }
            return View(Cinema);
        }

        //Get : Cinemas Details

        public async Task<IActionResult> Details(int id)
        {
            var CinemaDetails = await _service.GetByIdAsync(id);

            if (CinemaDetails == null) return View("NotFound");
            return View(CinemaDetails);
        }

        // Get: Cinema Edit

        public async Task<IActionResult> Edit(int id)
        {
            var CinemaEdit =await _service.GetByIdAsync(id);
            if (CinemaEdit == null) return View("NotFound");
            return View(CinemaEdit);
        }

        //Post : Cinemas Edit
        [HttpPost]
        
        public async Task<IActionResult> Edit(int Id, [Bind("Id","Logo", "Name", "Decription")]Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(Id, cinema);
            return RedirectToAction(nameof(Index));
        }

        // Get : Cinema Delete
        public async Task<IActionResult> Delete(int Id)
        {
            var CinemaDelete = await _service.GetByIdAsync(Id);
            if (CinemaDelete == null) return View("NotFound");
            return View(CinemaDelete);
        }
        // Post: Cimema Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var CinemaDelete = await _service.GetByIdAsync(id);
            if (CinemaDelete == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
