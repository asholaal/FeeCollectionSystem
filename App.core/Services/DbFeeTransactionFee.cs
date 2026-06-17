using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class DbFeeTransactionService : IFeeTransactionService
    {
        private readonly string _connectionString;

        public DbFeeTransactionService(string connString)
        {
            _connectionString = connString;
        }

        public List<FeeTransaction> GetAll()
        {
            List<FeeTransaction> list = new List<FeeTransaction>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT ft.ReceiptNo, ft.StudentId, s.FullName as StudentName, 
                              ft.AmountPaid, ft.PaymentDate
                              FROM FeeTransaction ft
                              INNER JOIN Student s ON ft.StudentId = s.Id
                              ORDER BY ft.PaymentDate DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FeeTransaction txn = new FeeTransaction();
                        txn.ReceiptNo = reader["ReceiptNo"].ToString();
                        txn.StudentId = reader["StudentId"].ToString();
                        txn.StudentName = reader["StudentName"].ToString();
                        txn.AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                        txn.PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                        list.Add(txn);
                    }
                }
            }
            return list;
        }

        public FeeTransaction? GetById(string receiptNo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT ft.ReceiptNo, ft.StudentId, s.FullName as StudentName, 
                              ft.AmountPaid, ft.PaymentDate
                              FROM FeeTransaction ft
                              INNER JOIN Student s ON ft.StudentId = s.Id
                              WHERE ft.ReceiptNo = @ReceiptNo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FeeTransaction txn = new FeeTransaction();
                        txn.ReceiptNo = reader["ReceiptNo"].ToString();
                        txn.StudentId = reader["StudentId"].ToString();
                        txn.StudentName = reader["StudentName"].ToString();
                        txn.AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                        txn.PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                        return txn;
                    }
                }
            }
            return null;
        }

        public List<FeeTransaction> GetByStudentId(string studentId)
        {
            List<FeeTransaction> list = new List<FeeTransaction>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT ft.ReceiptNo, ft.StudentId, s.FullName as StudentName, 
                              ft.AmountPaid, ft.PaymentDate
                              FROM FeeTransaction ft
                              INNER JOIN Student s ON ft.StudentId = s.Id
                              WHERE ft.StudentId = @StudentId
                              ORDER BY ft.PaymentDate DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FeeTransaction txn = new FeeTransaction();
                        txn.ReceiptNo = reader["ReceiptNo"].ToString();
                        txn.StudentId = reader["StudentId"].ToString();
                        txn.StudentName = reader["StudentName"].ToString();
                        txn.AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                        txn.PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                        list.Add(txn);
                    }
                }
            }
            return list;
        }

        public List<FeeTransaction> Search(string query)
        {
            List<FeeTransaction> list = new List<FeeTransaction>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT ft.ReceiptNo, ft.StudentId, s.FullName as StudentName, 
                              ft.AmountPaid, ft.PaymentDate
                              FROM FeeTransaction ft
                              INNER JOIN Student s ON ft.StudentId = s.Id
                              WHERE s.FullName LIKE @query OR s.RollNo LIKE @query
                              ORDER BY ft.PaymentDate DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@query", "%" + query.Trim() + "%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FeeTransaction txn = new FeeTransaction();
                        txn.ReceiptNo = reader["ReceiptNo"].ToString();
                        txn.StudentId = reader["StudentId"].ToString();
                        txn.StudentName = reader["StudentName"].ToString();
                        txn.AmountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                        txn.PaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                        list.Add(txn);
                    }
                }
            }
            return list;
        }

        public FeeTransaction Add(FeeTransaction transaction)
        {
            transaction.ReceiptNo = "RCP_" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO FeeTransaction (ReceiptNo, StudentId, AmountPaid, PaymentDate) VALUES (@ReceiptNo, @StudentId, @AmountPaid, @PaymentDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReceiptNo", transaction.ReceiptNo);
                cmd.Parameters.AddWithValue("@StudentId", transaction.StudentId);
                cmd.Parameters.AddWithValue("@AmountPaid", transaction.AmountPaid);
                cmd.Parameters.AddWithValue("@PaymentDate", transaction.PaymentDate);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    return transaction;
                else
                    return null;
            }
        }

        public bool Delete(string receiptNo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM FeeTransaction WHERE ReceiptNo = @ReceiptNo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}