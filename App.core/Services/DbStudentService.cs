using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class DbStudentService : IStudentService
    {
        string _conn;

        public DbStudentService(string conn)
        {
            _conn = conn;
        }

        public List<Student> GetAll()
        {
            List<Student> list = new List<Student>();

            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student();
                    s.Id = reader["Id"].ToString();
                    s.RollNo = reader["RollNo"].ToString();
                    s.FullName = reader["FullName"].ToString();
                    s.Program = reader["Program"].ToString();
                    s.ContactNo = reader["ContactNo"].ToString();  // ✅ ContactNo
                    list.Add(s);
                }
                reader.Close();
            }
            return list;
        }

        public Student GetById(string id)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Student s = new Student();
                    s.Id = reader["Id"].ToString();
                    s.RollNo = reader["RollNo"].ToString();
                    s.FullName = reader["FullName"].ToString();
                    s.Program = reader["Program"].ToString();
                    s.ContactNo = reader["ContactNo"].ToString();  // ✅ ContactNo
                    reader.Close();
                    return s;
                }
                reader.Close();
                return null;
            }
        }

        public Student Add(Student s)
        {
            s.Id = "STD_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Student (Id, RollNo, FullName, Program, ContactNo) VALUES (@id, @roll, @name, @prog, @contact)", con);
                cmd.Parameters.AddWithValue("@id", s.Id);
                cmd.Parameters.AddWithValue("@roll", s.RollNo);
                cmd.Parameters.AddWithValue("@name", s.FullName);
                cmd.Parameters.AddWithValue("@prog", s.Program);
                cmd.Parameters.AddWithValue("@contact", s.ContactNo);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) return s;
                return null;
            }
        }

        public bool Update(Student s)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Student SET RollNo=@roll, FullName=@name, Program=@prog, ContactNo=@contact WHERE Id=@id", con);
                cmd.Parameters.AddWithValue("@id", s.Id);
                cmd.Parameters.AddWithValue("@roll", s.RollNo);
                cmd.Parameters.AddWithValue("@name", s.FullName);
                cmd.Parameters.AddWithValue("@prog", s.Program);
                cmd.Parameters.AddWithValue("@contact", s.ContactNo);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool Delete(string id)
        {
            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public List<Student> Search(string keyword)
        {
            List<Student> list = new List<Student>();

            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE Name LIKE @key OR RollNo LIKE @key OR Program LIKE @key", con);
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student();
                    s.Id = reader["Id"].ToString();
                    s.RollNo = reader["RollNo"].ToString();
                    s.FullName = reader["FullName"].ToString();
                    s.Program = reader["Program"].ToString();
                    s.ContactNo = reader["ContactNo"].ToString();  // ✅ ContactNo
                    list.Add(s);
                }
                reader.Close();
            }
            return list;
        }

        public List<string> GetPrograms()
        {
            List<string> list = new List<string>();

            using (SqlConnection con = new SqlConnection(_conn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Program FROM Student", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader["Program"].ToString());
                }
                reader.Close();
            }
            return list;
        }
    }
}