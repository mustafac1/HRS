using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRS.Models;
using Microsoft.Data.SqlClient;

namespace HRS.Controllers
{
    public class DoctorsController : Controller
    {
        HRS.DataContext.HrsContext hrsContext = new DataContext.HrsContext();
        public IActionResult Index()
        {
            var viewmodel = new HRS.ViewModel.DoktorsViewModel
            {
                workerAndDoctors = hrsContext.GetDoctors(),
                Clinics = hrsContext.GetClinics()
            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Add(Models.Doctors doctors)
        {
            string con = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";

            using (SqlConnection sqlconnection = new SqlConnection(con))
            {
                sqlconnection.Open();

                string query = "INSERT INTO Doctors VALUES ('" + doctors.WorkerId + "','" + doctors.ClinicId+ "','" + doctors.Rank+ "','"+doctors.Status+"')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                sqlCommand.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}