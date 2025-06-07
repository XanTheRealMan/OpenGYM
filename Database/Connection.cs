/*
 * This file is part of OpenGYM.
 * Copyright (C) 2025  Anas Yusuf <itz.anasov@gmail.com>.
 *
 * OpenGYM is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * OpenGYM is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with OpenGYM. If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace OpenGYM.Database
{
    internal class Connection
    {
        // database connection string
        private static readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=OpenGYM;Integrated Security=True;TrustServerCertificate=True";

        // Get the last inserted IDs for Customers, Memberships, and Payments

        public static async Task<Customer> GetLastCustomerID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT TOP 1 CustomerID FROM Customers ORDER BY CustomerID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        return new Customer { CustomerID = (int)result };
                    }
                }
            }
            return null;
        }

        public static async Task<Membership> GetLastMembershipID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT TOP 1 MembershipID FROM Memberships ORDER BY MembershipID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        return new Membership { MembershipID = (int)result };
                    }
                }
            }
            return null;
        }

        public static async Task<Payment> GetLastPaymentID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT TOP 1 PaymentID FROM Payments ORDER BY PaymentID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        return new Payment { PaymentID = (int)result };
                    }
                }
            }
            return null;
        }

        // user functions
        public static async Task<User> GetUserAsync(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT * FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", password);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            };
                        }
                    }
                }
            }

            return null;
        }

        // customer functions
        public static bool IsCustomerExists(string FullName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Customers WHERE FullName = '@FullName'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", FullName);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static async Task<List<CustomerSearch>> SearchCustomerByName(string Name)
        {
            List<CustomerSearch> customers = new List<CustomerSearch>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Customers WHERE FullName LIKE @Name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", "%" + Name + "%");
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            customers.Add(new CustomerSearch
                            {
                                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName"))
                            });
                        }
                    }
                }
            }
            return customers;
        }

        public static async Task<Customer> LoadCustomerByName(string FullName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Customers WHERE FullName = @FullName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", FullName);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Customer
                            {
                                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static async Task<Customer> LoadCustomerByID(int CustomerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new Customer
                            {
                                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static async Task<Customer> SaveCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "INSERT INTO Customers (FullName, Gender, DateOfBirth, Phone, Email, Address) " +
                               "OUTPUT INSERTED.CustomerID VALUES (@FullName, @Gender, @DateOfBirth, @Phone, @Email, @Address)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", customer.FullName);
                    command.Parameters.AddWithValue("@Gender", customer.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                    command.Parameters.AddWithValue("@Phone", customer.Phone);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@Address", customer.Address);

                    object result = await command.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        customer.CustomerID = (int)result;
                    }
                    else
                    {
                        throw new InvalidOperationException("Failed to insert customer.");
                    }
                }
            }
            return customer;
        }

        public static async Task<Customer> EditCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "UPDATE Customers SET FullName = @FullName, Gender = @Gender, DateOfBirth = @DateOfBirth, " +
                               "Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    command.Parameters.AddWithValue("@FullName", customer.FullName);
                    command.Parameters.AddWithValue("@Gender", customer.Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                    command.Parameters.AddWithValue("@Phone", customer.Phone);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@Address", customer.Address);

                    await command.ExecuteNonQueryAsync();
                }
            }
            return customer;
        }

        public static bool DeleteCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // membership functions

        // payment functions

    }
}
