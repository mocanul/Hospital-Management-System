using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class GlobalUserId
{
    public static string userId;
}

public static class ConnectionString
{
    public static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HospitalDB.db");
    public static string connectionString = $"Data Source={dbPath};Version=3;Foreign Keys=True;";
}
