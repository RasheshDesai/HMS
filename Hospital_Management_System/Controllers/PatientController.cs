using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.SQLOperation;
using Hospital_Management_System.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class PatientController : Controller
    {
        //public readonly PatientService operation;

        public readonly IPatientService service;
        public PatientController(IPatientService operation) 
        {
            service = operation;
            
        }  

        public IActionResult ShowPatients()
        {
            var list = service.GetPatientsRecords();
            return View(list);
        }
        [HttpGet]
        public IActionResult CreatePatient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePatient(Patient patient)
        {
            Patient p = service.AddPatient(patient);
            return RedirectToAction("ShowPatients");
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
