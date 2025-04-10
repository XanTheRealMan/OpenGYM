-- Users (System Operators)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE,
    PasswordHash NVARCHAR(255),
    FullName NVARCHAR(100),
    Role NVARCHAR(50), -- e.g., Admin, Receptionist, Manager
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Sample User
INSERT INTO [dbo].[Users] (
    [Username],
    [PasswordHash],
    [FullName],
    [Role]
) VALUES (
    'admin',
    'XohImNooBHFR0OVhgG2v9Z3rj3sC2Jp2kF+zPfb1Q5o=',
    'OpenGYM Admin',
    'admin'
)

-- Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100),
    Gender NVARCHAR(10),
    DateOfBirth DATE,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Memberships
CREATE TABLE Memberships (
    MembershipID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    StartDate DATE,
    EndDate DATE,
    IsActive BIT
);

-- Payments
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    Amount DECIMAL(10, 2),
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod NVARCHAR(50),
    Notes NVARCHAR(255)
);
