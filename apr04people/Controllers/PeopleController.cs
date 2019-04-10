using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apr04people.Models;
using apr04people.Models.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apr04people.Controllers
{
    public class PeopleController : Controller
    {
        PersonsService service;
        public PeopleController(PersonsService service)
        {
            this.service = service;
        }
        //[Route ("/")]
        public IActionResult Index()
        {
            return View(service.GetAllPeople());
        }
        //[Route("~/People/Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("~/People/Create")]
        [HttpPost]
        public async Task <IActionResult> Create(Contact person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            };
            await service.AddPerson(person);
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult Create(Contact person)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(person);
        //    };
        //    service.AddPerson(person);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
