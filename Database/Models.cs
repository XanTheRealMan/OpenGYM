/*
 * Copyright (C) 2025  Anas Yusuf <me@anasov.ly>.
 * 
 * This software is proprietary and is not free or open-source.
 * It is a paid software, and any use, distribution, or modification without a valid license is strictly prohibited.
 * Unauthorized use will result in legal action, including but not limited to lawsuits.  
 * 
 * For licensing inquiries, please contact the software owner.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGYM.Database
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CustomerSearch
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
    }

    public class Membership
    {
        public int MembershipID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class Payment
    {
        public int PaymentID { get; set; }
        public int CustomerID { get; set; }
        public int MembershipID { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
    }
}
