using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        public readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service ;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // Get : Producer/Create
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(producer);
                return RedirectToAction("Index");
            }
            return View(producer);
        }

        //Get : Producer Details

        public async Task<IActionResult> Details(int id)
        {
            var ProducerDetails = await _service.GetByIdAsync(id);

            if (ProducerDetails == null) return View("NotFound");
            return View(ProducerDetails);
        }

        // Get: Producer Edit

        public async Task<IActionResult> Edit(int id)
        {
            var ProducerEdit = await _service.GetByIdAsync(id);
            if (ProducerEdit == null) return View("NotFound");
            return View(ProducerEdit);
        }

        //Post : Producer Edit
        [HttpPost]

        public async Task<IActionResult> Edit(int Id, [Bind("Id", "FullName,ProfilePictureURL,Bio")] Producer Producer)
        {
            if (!ModelState.IsValid)
            {
                return View(Producer);
            }
            await _service.UpdateAsync(Id, Producer);
            return RedirectToAction(nameof(Index));
        }

        // Get : Producer Delete
        public async Task<IActionResult> Delete(int Id)
        {
            var ProducerDelete = await _service.GetByIdAsync(Id);
            if (ProducerDelete == null) return View("NotFound");
            return View(ProducerDelete);
        }
        // Post: Cimema Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ProducerDelete = await _service.GetByIdAsync(id);
            if (ProducerDelete == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
