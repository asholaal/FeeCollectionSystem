using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class DbFeeStructureService : IFeeStructureService
    {
        private readonly string _connectionString;

        public DbFeeStructureService(string connString)
        {
            _connectionString = connString;
        }

        public List<FeeStructure> GetAll()
        {
            List<FeeStructure> list = new List<FeeStructure>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM FeeStructure", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FeeStructure fs = new FeeStructure();
                        fs.Id = reader["Id"].ToString();
                        fs.Program = reader["Program"].ToString();
                        fs.TotalFee = Convert.ToDecimal(reader["TotalFee"]);
                        list.Add(fs);
                    }
                }
            }
            return list;
        }

        public FeeStructure? GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM FeeStructure WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FeeStructure fs = new FeeStructure();
                        fs.Id = reader["Id"].ToString();
                        fs.Program = reader["Program"].ToString();
                        fs.TotalFee = Convert.ToDecimal(reader["TotalFee"]);
                        return fs;
                    }
                }
            }
            return null;
        }

        public FeeStructure? GetByProgram(string program)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM FeeStructure WHERE Program = @Program";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Program", program);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FeeStructure fs = new FeeStructure();
                        fs.Id = reader["Id"].ToString();
                        fs.Program = reader["Program"].ToString();
                        fs.TotalFee = Convert.ToDecimal(reader["TotalFee"]);
                        return fs;
                    }
                }
            }
            return null;
        }

        public FeeStructure Add(FeeStructure feeStructure)
        {
            feeStructure.Id = "FS_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO FeeStructure (Id, Program, TotalFee) VALUES (@Id, @Program, @TotalFee)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", feeStructure.Id);
                cmd.Parameters.AddWithValue("@Program", feeStructure.Program);
                cmd.Parameters.AddWithValue("@TotalFee", feeStructure.TotalFee);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    return feeStructure;
                else
                    return null;
            }
        }

        public bool Update(FeeStructure feeStructure)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE FeeStructure SET Program = @Program, TotalFee = @TotalFee WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", feeStructure.Id);
                cmd.Parameters.AddWithValue("@Program", feeStructure.Program);
                cmd.Parameters.AddWithValue("@TotalFee", feeStructure.TotalFee);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM FeeStructure WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public List<FeeStructure> Search(string keyword)
        {
            List<FeeStructure> list = new List<FeeStructure>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM FeeStructure WHERE Program LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FeeStructure fs = new FeeStructure();
                        fs.Id = reader["Id"].ToString();
                        fs.Program = reader["Program"].ToString();
                        fs.TotalFee = Convert.ToDecimal(reader["TotalFee"]);
                        list.Add(fs);
                    }
                }
            }
            return list;
        }
    }
}