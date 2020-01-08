using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using HRS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HRS.Controllers
{
    public class RolesController : Controller
    {
        string connection = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";
     
        public IActionResult Index()
        {
            var roles = new List<Models.Roles>();

            using (SqlConnection sqlconnection = new SqlConnection(connection))
            {
                sqlconnection.Open();

                string query = "SELECT * FROM Roles ORDER BY Id DESC";

                SqlCommand sqlCommand = new SqlCommand(query,sqlconnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        var role = new Roles();
                        role.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        role.Name = sqlDataReader["Name"].ToString();

                        roles.Add(role);
                    }
                }
            }
            var viewmodel = new HRS.ViewModel.RolesViewModel
            {
                Role = roles
            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Add(Models.Roles roles)
        {
            if (string.IsNullOrEmpty(roles.Name))
            {
                TempData["title"] = "Boş";
                return RedirectToAction("Index");
            }
            else
            {
                using (SqlConnection sqlconnection = new SqlConnection(connection))
                {
                    sqlconnection.Open();

                    var name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(roles.Name);

                    string query = "INSERT INTO Roles VALUES ('"+ name +"')";

                    SqlCommand sqlCommand = new SqlCommand(query,sqlconnection);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            TempData["title"] = "Başarılı";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            using (SqlConnection sqlconnection = new SqlConnection(connection))
            {
                sqlconnection.Open();

                string query = "DELETE FROM Roles WHERE Id = '"+id+"'";

                SqlCommand sqlCommand = new SqlCommand(query,sqlconnection);

                sqlCommand.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}