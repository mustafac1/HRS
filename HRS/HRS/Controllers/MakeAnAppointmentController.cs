using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRS.Models;
using Microsoft.Data.SqlClient;

namespace HRS.Controllers
{
    public class MakeAnAppointmentController : Controller
    {
        private string _connection = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";
        HRS.DataContext.HrsContext hrsContext = new DataContext.HrsContext();

        public IActionResult Index()
        {
            var viewmodel = new HRS.ViewModel.MakeAnAppointmentViewModel
            {
                clinics = hrsContext.GetClinics()
            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Clinic(int id)
        {
            var doctors = hrsContext.GetDoctorList(id);
            return Json(doctors);
        }

        [HttpPost]
        public IActionResult Appointment(int id)
        {
            var times = hrsContext.GetTime(id);
            return Json(times);
        }

        [HttpPost]
        public IActionResult Add(HRS.ViewModel.MakeAnAppointmentViewModel makeAnAppointment)
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();

                

                string query = "INSERT INTO PatientAppointments(ClinicId,DoctorId,TimeId,TransactionDate) VALUES (@p1,@p2,@p3,@p4)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@p1", makeAnAppointment.ClinicId);
                sqlCommand.Parameters.AddWithValue("@p2", makeAnAppointment.DoctorId);
                sqlCommand.Parameters.AddWithValue("@p3", makeAnAppointment.TimeId);
                sqlCommand.Parameters.AddWithValue("@p4", makeAnAppointment.TransactionDate);

                sqlCommand.ExecuteNonQuery();
            }
            return RedirectToAction("Index");

        }
    }
}