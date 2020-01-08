using HRS.ComplexType;
using HRS.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace HRS.DataContext
{
    public class HrsContext
    {
        private string _connection = @"Data Source = HP\SQLEXPRESS; Initial Catalog = HRS; User ID = sa; Password = 123456; Integrated Security = True";

        public List<WokerAndRoles> GetWokerAndRoles()
        {
            var workersAndRoles = new List<ComplexType.WokerAndRoles>();
            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "SELECT R.Id,R.Name,W.Id,W.Name,W.Surname,W.Gender,W.TcNo,W.DateOfBirth,W.Tel,W.Mail,W.UserName,W.Password FROM Roles AS R  INNER JOIN Workers AS W On (R.Id=W.RoleId) ORDER BY W.Id DESC";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        var workerAndRole = new ComplexType.WokerAndRoles();

                        workerAndRole.RolId = Convert.ToInt32(sqlDataReader[0].ToString());
                        workerAndRole.RolName = sqlDataReader[1].ToString();
                        workerAndRole.Id = Convert.ToInt32(sqlDataReader[2].ToString());
                        workerAndRole.Name = sqlDataReader[3].ToString();
                        workerAndRole.Surname = sqlDataReader[4].ToString();
                        workerAndRole.Gender = sqlDataReader[5].ToString();
                        workerAndRole.TcNo = sqlDataReader[6].ToString();
                        workerAndRole.DateOfBirth = Convert.ToDateTime(sqlDataReader[7]);
                        workerAndRole.Tel = sqlDataReader[8].ToString();
                        workerAndRole.Mail = sqlDataReader[9].ToString();
                        workerAndRole.UserName = sqlDataReader[10].ToString();
                        workerAndRole.Password = sqlDataReader[11].ToString();

                        workersAndRoles.Add(workerAndRole);
                    }
                }
                sqlconnection.Close();
                return workersAndRoles;
            }
        }

        public List<WorkerAndDoctor> GetDoctors()
        {
            var workeranddoctor = new List<ComplexType.WorkerAndDoctor>();
            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();

                //string query = "SELECT D.WorkerId,D.ClinicId,D.Status,W.Id,W.RoleId,W.Name,W.Surname,W.Gender,W.TcNo,W.DateOfBirth,W.Tel,W.Mail,W.UserName,W.Password FROM Doctors AS D  INNER JOIN Workers AS W On (D.WorkerId=W.Id)";

                string query = "SELECT W.Id,W.Name,W.Surname,D.WorkerId FROM Workers AS W INNER JOIN Doctors AS D ON W.Id=D.WorkerId WHERE W.RoleId=" + (int)Enums.Enum.Doctor + "";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        var WorkerAndDoctor = new ComplexType.WorkerAndDoctor();

                        WorkerAndDoctor.Id = Convert.ToInt32(sqlDataReader[0].ToString());
                        WorkerAndDoctor.Name = sqlDataReader[1].ToString();
                        WorkerAndDoctor.Surname = sqlDataReader[2].ToString();

                        workeranddoctor.Add(WorkerAndDoctor);

                    }
                }
                sqlConnection.Close();
                return workeranddoctor;
            }
        }

        public List<Clinic> GetClinics()
        {
            var clinics = new List<Models.Clinic>();

            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "SELECT * FROM Clinic ORDER BY Id DESC";

                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        var clinic = new Clinic();

                        clinic.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        clinic.Name = sqlDataReader["Name"].ToString();

                        clinics.Add(clinic);
                    }
                }
            }
            return clinics;
        }

        public List<Times> GetTimes()
        {
            var times = new List<Models.Times>();
            using (SqlConnection sqlconnection = new SqlConnection(_connection))
            {
                sqlconnection.Open();

                string query = "SELECT * FROM Times";

                SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);

                //TODO : 1. yapılacak iş
                using (SqlDataReader sqldatareader = sqlcommand.ExecuteReader())
                {
                    while (sqldatareader.Read())
                    {
                        var time = new Times();

                        time.Id = Convert.ToInt32(sqldatareader["Id"]);
                        time.StartTime = TimeSpan.Parse(sqldatareader["StartTime"].ToString());
                        time.EndTime = TimeSpan.Parse(sqldatareader["EndTime"].ToString());

                        times.Add(time);
                    }
                }
            }
            return times;
        }

        public List<Dtos.DoctorDto> GetDoctorList(int id)
        {
            var dtoDoctors = new List<Dtos.DoctorDto>();

            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();

                string query = "SELECT W.Id,W.Name,W.Surname,D.WorkerId,D.ClinicId FROM Workers AS W INNER JOIN Doctors AS D ON W.Id=D.WorkerId WHERE D.ClinicId= " + id + "";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        var doctor = new Dtos.DoctorDto
                        {
                            Id = Convert.ToInt32(sqlDataReader[0].ToString()),
                            Name = sqlDataReader[1].ToString(),
                            SurName = sqlDataReader[2].ToString()
                        };
                        dtoDoctors.Add(doctor);
                    }
                }
                return dtoDoctors;
            }
        }

        public List<HRS.Dtos.TimesDto> GetTime(int id)
        {
            var times = new List<HRS.Dtos.TimesDto>();

            using (SqlConnection sqlConnection = new SqlConnection(_connection))
            {
                sqlConnection.Open();

                string query = "SELECT T.Id,T.StartTime,T.EndTime FROM DoctorAppointment AS DA INNER JOIN Times AS T ON DA.TimeId= T.Id WHERE DA.DoctorId= "+id+"";

                SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        var time = new HRS.Dtos.TimesDto();

                        time.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        time.StartTime = sqlDataReader["StartTime"].ToString();
                        time.EndTime = sqlDataReader["EndTime"].ToString();

                        times.Add(time);
                    }
                }
                return times;
            }
        }

    }
}
