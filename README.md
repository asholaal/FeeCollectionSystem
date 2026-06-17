# Fee Collection System

## 📌 Project Overview

**Project Name:** Fee Collection System

**Purpose:** A Windows Forms-based fee collection management application for tracking students, fee structures, payments, and dashboard summary visualization.

**Description:** The system supports adding, editing, viewing, and deleting students, fee structures, and fee transactions. It also provides a dashboard with total students, collected amount, pending fee, cleared students, program-wise collection charts, and monthly collection trend charts.

**Technology Stack:**
- Language: C#
- Framework: .NET 10.0 / .NET 10.0-windows
- UI: Windows Forms
- Data access: ADO.NET using raw SQL queries via Microsoft.Data.SqlClient
- Charting: LiveChartsCore.SkiaSharpView.WinForms
- Configuration: System.Configuration.ConfigurationManager

---

## 🗄️ Database

**Database used:** Microsoft SQL Server (via SQL Server connection string and Microsoft.Data.SqlClient provider)

**Data access method:** ADO.NET with SqlConnection, SqlCommand, and SqlDataReader

**Connection string location:** `FeeCollectionApp/App.config` under `<connectionStrings>` with name `DefaultConnection`

---

## 📊 Database Tables / Models

The application defines four database tables and corresponding domain models.

### Student
**Columns:**
- `Id` NVARCHAR(50) PRIMARY KEY
- `RollNo` NVARCHAR(50) NOT NULL
- `FullName` NVARCHAR(100) NOT NULL
- `Program` NVARCHAR(50) NOT NULL
- `Contact` NVARCHAR(20) NULL

**Model:** `App.Core.Models.Student`
- `string Id`
- `string RollNo` (required)
- `string FullName` (required)
- `string Program` (required)
- `string? Contact`

---

### FeeStructure
**Columns:**
- `Id` NVARCHAR(50) PRIMARY KEY
- `Program` NVARCHAR(50) NOT NULL
- `TotalFee` DECIMAL(18,2) NOT NULL

**Model:** `App.Core.Models.FeeStructure`
- `string Id`
- `string Program` (required)
- `decimal TotalFee`

---

### StudentAccount
**Columns:**
- `Id` NVARCHAR(50) PRIMARY KEY
- `StudentId` NVARCHAR(50) NOT NULL
- `TotalFee` DECIMAL(18,2) NOT NULL
- `PaidFee` DECIMAL(18,2) NOT NULL DEFAULT 0

**Model:** `App.Core.Models.StudentAccount`
- `string Id`
- `string StudentId` (required)
- `decimal TotalFee`
- `decimal PaidFee`
- `decimal RemainingFee` (computed: TotalFee - PaidFee)
- `string Status` (computed: "Cleared" if RemainingFee <= 0 else "Pending")

---

### FeeTransaction
**Columns:**
- `ReceiptNo` NVARCHAR(50) PRIMARY KEY
- `StudentId` NVARCHAR(50) NOT NULL
- `AmountPaid` DECIMAL(18,2) NOT NULL
- `PaymentDate` DATETIME NOT NULL

**Model:** `App.Core.Models.FeeTransaction`
- `string ReceiptNo`
- `string StudentId` (required)
- `decimal AmountPaid`
- `DateTime PaymentDate`

---

## 🔗 Relationships

There are **no enforced foreign key relationships** in the database schema.

- `StudentAccount.StudentId` references `Student.Id` by convention
- `FeeTransaction.StudentId` references `Student.Id` by convention

---

## 🎯 Enums / Choices / Constants

The application uses simple enums to represent form mode states.

**FormMode (App.Core.Models)**
- `Add`
- `Edit`
- `View`

---

## 🧩 Core Functionalities

The project is structured into core services and Windows Forms UI views.

### Students Management
- Add new students
- Edit existing students
- View student details
- Delete students
- Search students by name, roll no, or program
- Filter students by program

### Fee Structure Management
- Add new fee structures
- Edit existing fee structures
- View fee structure details
- Delete fee structures
- Search fee structures by program

### Payments Management
- Add new payments
- View payment history
- Filter payments by status (Pending / Cleared)

### Dashboard Summary
- Total Students
- Total Collected Amount
- Total Pending Amount
- Cleared Students Count
- Program-wise Collection Chart (Bar Chart)
- Monthly Collection Trend Chart (Line Chart)

---

## 🏗️ Architecture

- **App.Core**: Business logic, Models, Contracts, and Services
- **App.WindowsApp**: User Interface (Windows Forms)

### Solution Structure
FeeCollectionSystem/
├── App.Core (Class Library)
│ ├── Models/
│ │ ├── Student.cs
│ │ ├── FeeStructure.cs
│ │ ├── StudentAccount.cs
│ │ └── FeeTransaction.cs
│ ├── Contracts/
│ │ ├── IStudentService.cs
│ │ ├── IFeeStructureService.cs
│ │ ├── IStudentAccountService.cs
│ │ └── IFeeTransactionService.cs
│ └── Services/
│ ├── DbStudentService.cs
│ ├── DbFeeStructureService.cs
│ ├── DbStudentAccountService.cs
│ └── DbFeeTransactionService.cs
│
└── FeeCollectionApp (Windows Forms)
├── Forms/
│ ├── MainForm.cs
│ ├── StudentForm.cs
│ ├── FeeForm.cs
│ └── PaymentForm.cs
├── Views/
│ ├── StudentView.cs
│ ├── FeeView.cs
│ ├── PaymentView.cs
│ └── DashboardView.cs
└── App.config

Third-Party Packages / Dependencies
App.Core
Microsoft.Data.SqlClient 7.0.1 — SQL Server client access for ADO.NET

FeeCollectionApp
LiveChartsCore.SkiaSharpView.WinForms 2.0.4 — WinForms chart controls for dashboard

Microsoft.Data.SqlClient 7.0.1 — SQL Server client access

System.Configuration.ConfigurationManager 10.0.8 — Reading App.config settings


🚀 How to Run
Clone the repository:

bash
git clone https://github.com/asholaal/FeeCollectionSystem.git
Open FeeCollectionSystem.sln in Visual Studio

Update the connection string in FeeCollectionApp/App.config

Run the SQL script to create the database and tables

Build the solution (Ctrl + Shift + B)

Run the project (F5)

👥 Group Members
Member 1: Ayesha Sadiqa(02044)

Member 2: Shamsa Kanwal(02040)

Member 3:Aliza Fatima(02052)

📅 Semester
Spring 2026 | Advanced Programming
