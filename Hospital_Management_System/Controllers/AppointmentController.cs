using Hospital_Management_System.Models.BusinessLayer;
using Hospital_Management_System.Models.SQLOperation;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService service;
        

        public AppointmentController(IAppointmentService service) 
        {
            this.service = service;
        }

        public IActionResult ShowAppointments() 
        {
            List<Appointment> appointments = service.GetAllAppointments();
            return View(appointments);
                       
        }

        [HttpGet]
        public IActionResult CreateAppointment()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateAppointment(int patientId, int doctorId,Appointment appointment) 
        {
            //var newAppointment = 
            service.CreateAppointment(patientId, doctorId, appointment);

            return RedirectToAction("ShowAppointments");
        
        }

        public IActionResult DeleteAppointment()
        {
            return View();

        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
