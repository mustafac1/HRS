using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using HRS.Models;
using System.Globalization;

namespace HRS.Controllers
{
    public class WorkersController : Controller
    {
        private string _connection = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";

        HRS.DataContext.HrsContext hrsContext = new DataContext.HrsContext();
        public IActionResult Index()
        {
            var viewmodel = new HRS.ViewModel.WorkersViewModel
            {
                WokerAndRoles = hrsContext.GetWokerAndRoles()
            };
            return View(viewmodel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = new ViewModel.WorkersViewModel
            {
                Roles = Roles()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(Models.Workers worker, string confirmPassword)
        {

            AddEdit(null, worker, confirmPassword);

            return RedirectToAction("Index");
        }

        private bool IsPasswordConfirm(string password1, string password2)
        {
            if (password1 != password2)
            {
                TempData["title"] = "Şifre Eşleşmiyor";
                return false;
            }
            else if (password1 == password2)
            {
                if (password1.Length < 6)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private List<Roles> Roles()
        {
            var roles = new List<Models.Roles>();

            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "SELECT * FROM Roles";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

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
                sqlconnection.Close();
            }
            return roles;
        }

        private Workers AddEdit(int? id, Models.Workers worker, string confirmPassword)
        {
            string query;

            if (id.HasValue)
            { 
                //Düzenle
                query = "UPDATE Workers SET RoleId=@p1,Name=@p2,Surname=@p3,Gender=@p4,TcNo=@p5,DateOfBirth=@p6,Tel=@p7,Mail=@p8,UserName=@p9,Password=@p10 WHERE Id = " + id.Value + "";
            }
            else
            {
                //Ekleme
                query = "INSERT INTO Workers(RoleId,Name,Surname,Gender,TcNo,DateOfBirth,Tel,Mail,UserName,Password) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            }

            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                var pass = IsPasswordConfirm(worker.Password, confirmPassword);

                var name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(worker.Name);
                var surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(worker.Surname);

                if (pass)
                {
                    sqlconnection.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                    sqlCommand.Parameters.AddWithValue("@p1", worker.RoleId);
                    sqlCommand.Parameters.AddWithValue("@p2", name);
                    sqlCommand.Parameters.AddWithValue("@p3", surname);
                    sqlCommand.Parameters.AddWithValue("@p4", worker.Gender);
                    sqlCommand.Parameters.AddWithValue("@p5", worker.TcNo);
                    sqlCommand.Parameters.AddWithValue("@p6", worker.DateOfBirth);
                    sqlCommand.Parameters.AddWithValue("@p7", worker.Tel);
                    sqlCommand.Parameters.AddWithValue("@p8", worker.Mail);
                    sqlCommand.Parameters.AddWithValue("@p9", worker.UserName);
                    sqlCommand.Parameters.AddWithValue("@p10", worker.Password);

                    sqlCommand.ExecuteNonQuery();
                    sqlconnection.Close();
                }

            }
            return worker;
        }

        public IActionResult Delete(int id)
        {
            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "DELETE FROM Workers WHERE Id = '" + id + "'";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(string workerid)
        {
            var viewModels = new ViewModel.WorkersViewModel
            {
                Roles = Roles()
            };

            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "SELECT R.Id,R.Name,W.Id,W.Name,W.Surname,W.Gender,W.TcNo,W.DateOfBirth,W.Tel,W.Mail,W.UserName,W.Password FROM Roles AS R  INNER JOIN Workers AS W On (R.Id=W.RoleId) WHERE W.Id = '" + workerid + "'";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    sqlDataReader.Read();
                    viewModels.RoleId = Convert.ToInt32(sqlDataReader[0].ToString());
                    viewModels.Id = Convert.ToInt32(sqlDataReader[2].ToString());
                    viewModels.Name = sqlDataReader[3].ToString();
                    viewModels.Surname = sqlDataReader[4].ToString();
                    viewModels.Gender = sqlDataReader[5].ToString();
                    viewModels.TcNo = sqlDataReader[6].ToString();
                    viewModels.DateOfBirth = DateTime.Parse(sqlDataReader[7].ToString());
                    viewModels.Tel = sqlDataReader[8].ToString();
                    viewModels.Mail = sqlDataReader[9].ToString();
                    viewModels.UserName = sqlDataReader[10].ToString();
                    viewModels.Password = sqlDataReader[11].ToString();
                }

                return View(viewModels);
            }
        }


        [HttpPost]
        public IActionResult Edit(Models.Workers worker, string confirmPassword)
        {
            AddEdit(worker.Id, worker, confirmPassword);

            return RedirectToAction("Index");
        }
    }
}