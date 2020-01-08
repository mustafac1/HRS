using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HRS.Controllers
{
    public class AppointmentController : Controller
    {

        private string _connection = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";

        HRS.DataContext.HrsContext _hrsContext = new DataContext.HrsContext();

        public IActionResult Index()
        {
            var viewModel = new ViewModel.AppointmentViewModel
            {
                GetDoctors = _hrsContext.GetDoctors(),
                GetTimes = _hrsContext.GetTimes()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(List<int> TimeId,int DoctorId)
        {
            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                for (int i = 0; i < TimeId.Count; i++)
                {

                    string query = "INSERT INTO DoctorAppointment VALUES('" + DoctorId + "','" + TimeId[i] + "')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                    sqlCommand.ExecuteNonQuery();
                }

            }
            return RedirectToAction("Index");
        }
    }
}