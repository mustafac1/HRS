using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using HRS.Models;
using System;
using System.Collections.Generic;

namespace HRS.Controllers
{
    public class ClinicController : Controller
    {
        private string _connection = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";

        HRS.DataContext.HrsContext hrsContext = new DataContext.HrsContext();
        public IActionResult Index()
        {
            var viewmodel = new HRS.ViewModel.ClinicViewModel
            {
                Clinics = hrsContext.GetClinics()
            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Add(Models.Clinic clinic)
        {
            if (string.IsNullOrEmpty(clinic.Name))
            {
                TempData["title"] = "Boş";
                return RedirectToAction("Index");
            }
            else
            {
                using (SqlConnection sqlconnection = new SqlConnection(_connection))
                {
                    sqlconnection.Open();

                    string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(clinic.Name);

                    string query = "INSERT INTO Clinic VALUES ('" + name + "')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "DELETE FROM Clinic WHERE Id = '" + id + "'";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                sqlCommand.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}