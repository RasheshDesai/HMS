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

        [HttpPost]
        public IActionResult GetDoctorBySpeciality(Speciality speciality)
        {
            var doctor = service.GetDoctorBySpeciality(speciality);
            return View(doctor);
        }

        [HttpPost]
        public IActionResult GetDoctorByName(string name)
        {
            var doctorname = service.GetDoctorByName(name);
            return View(doctorname);
        }

        public IActionResult DeleteDoctor(int id)
        {
            ViewData["Done"] = service.DeleteDoctor(id);
            return RedirectToAction("ShowDoctors");
        }

        [HttpGet]
        public ActionResult EditDoctor()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult EditDoctor(Doctor update)
        {
            service.UpdateDoctor(update);

			return RedirectToAction("ShowDoctors");
		}

    }
}
