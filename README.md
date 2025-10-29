Hospital Management System (WinForms, C#)

A Windows Forms (WinForms) application built in Visual Studio 2022 that provides a simple, role-based system for hospital staff to manage patients, appointments, diagnoses, staff accounts (for admin). 



✨ Features
- Authentication & Security
- Login screen with role-based access (Admin or Staff)
- Password change flow
- Admin Portal
  - Create new staff accounts
  - View and manage existing staff
- Staff Portal
  - Create and manage patient appointments
  - Record diagnoses & lab results
  - Browse patient list and medical history
  - View upcoming appointments

Forms visible in the codebase include:
Login, PasswordChange, AdminHome, AdminNewStaff, AdminViewStaff, StaffHome, StaffCreateAppointment, StaffViewAppointments, StaffViewPatients, StaffViewPatientMedicalHistory, StaffDiagnosisForm, StaffLabResult.



🧱 Tech Stack
- Language: C#
- UI: WinForms
- IDE: Visual Studio 2022
- Project Type: .sln + .csproj (classic .NET project)
- NuGet: packages.config (package-based restores)

The repository is 100% C# and targets WinForms via a standard .csproj and solution layout. 



🧭 Roadmap
- Login System
  - Create a login form that verifies username and password.
  - Store user roles (Admin or Staff).
  - Show error messages for invalid credentials.

- After successful login:
  - If Admin, open the Admin Dashboard.
  - If Staff, open the Staff Dashboard.
  
- Admin Dashboard
  - View all staff accounts.
  - Add new staff members.
  - Edit or delete staff profiles.
  - (Optional) Reset staff passwords.

- Staff Dashboard
  - Create new patient appointments.
  - View and manage existing appointments.
  - Record diagnoses and lab results.
  - View patient history and details.
 
- Database Integration
  - Connect all forms (Login, Admin, Staff) to a shared database.
  - Tables: Accounts, Patients, PatientMedicalHistory, LabTest, Diagnosis, Appointments, Staff.
  - Validation & Error Handling
  - Validate all input fields before saving to the database.
  - Add clear error messages and confirmation dialogs.
    
- UI Polish & Navigation
  - Ensure consistent layout, colors, and navigation between forms.
  - Add “Logout” and “Exit” buttons in dashboards.
 
How to run the program:
-Copy repo
-Run Hospital Management.exe
-Logins are: staff.admin1 / staff.doctor2 / staff.nurse3 / staff.receptionist4
-Password: 12345678



🙌 Acknowledgments
- Built as a learning project to practice WinForms, multi-form app structure, and role-based UX.
