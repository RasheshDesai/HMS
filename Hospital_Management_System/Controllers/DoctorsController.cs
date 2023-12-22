using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.SQLOperation;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorService service;

        public DoctorsController(IDoctorService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowDoctors() 
        {
            var docList = service.GetDoctorsRecord();
            return View(docList);
        }

        [HttpGet]
        public IActionResult CreateDoctor() 
        {
            return View();        
        }

        [HttpPost]
        public IActionResult CreateDoctor(Doctor doctor)
        {
            Doctor addDoc = service.CreateDoctor(doctor);
            return RedirectToAction("ShowDoctors");
        }
    }
}
