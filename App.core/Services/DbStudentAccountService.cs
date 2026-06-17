using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class DbStudentAccountService : IStudentAccountService
    {
        private readonly string _connectionString;

        public DbStudentAccountService(string connString)
        {
            _connectionString = connString;
        }

        public List<StudentAccount> GetAll()
        {
            List<StudentAccount> list = new List<StudentAccount>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT sa.Id, sa.StudentId, s.RollNo, s.FullName as StudentName, 
                              s.Program, sa.TotalFee, sa.PaidFee
                              FROM StudentAccount sa
                              INNER JOIN Student s ON sa.StudentId = s.Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentAccount acc = new StudentAccount();
                        acc.Id = reader["Id"].ToString();
                        acc.StudentId = reader["StudentId"].ToString();
                        acc.RollNo = reader["RollNo"].ToString();
                        acc.StudentName = reader["StudentName"].ToString();
                        acc.Program = reader["Program"].ToString();
                        acc.TotalFee = Convert.ToDecimal(reader["TotalFee"]);
                        acc.PaidFee = Convert.ToDecimal(reader["PaidFee"]);
                        list.Add(acc);
                    }
                }
            }
            return list;
        }

        public StudentAccount? GetByStudentId(string studentId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT sa.Id, sa.StudentId, s.RollNo, s.FullName as StudentName, 
                              s.Program, sa.TotalFee, sa.PaidFee
                              FROM StudentAccount sa
                              INNER JOIN Student s ON sa.StudentId = s.Id
                              WHERE sa.StudentId = @StudentId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        StudentAccount acc = new StudentAccount();
                        acc.Id = reader["Id"].ToString();
                        acc.StudentId = reader["StudentId"].ToString();
                        acc.RollNo = reader["RollNo"].ToString();
                        acc.StudentName = reader["StudentName"].ToString();
                        acc.Program = reader["Program"].ToString();
                        acc.TotalFee = Convert.ToDecimal(reader["TotalFee"]);
                        acc.PaidFee = Convert.ToDecimal(reader["PaidFee"]);
                        return acc;
                    }
                }
            }
            return null;
        }

        public StudentAccount CreateAccount(string studentId, decimal totalFee)
        {
            string accountId = "SA_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO StudentAccount (Id, StudentId, TotalFee, PaidFee) VALUES (@Id, @StudentId, @TotalFee, 0)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", accountId);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@TotalFee", totalFee);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    return GetByStudentId(studentId);
                else
                    return null;
            }
        }

        public bool UpdatePaidFee(string studentId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE StudentAccount SET PaidFee = PaidFee + @Amount WHERE StudentId = @StudentId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@Amount", amount);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}