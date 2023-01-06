using System;
namespace SalesSystemApi.Constants.Configuration
{
    public static class Constants
    {

        public static string MSSQL_SERVER = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_SERVER")) ? "mssql" : Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_SERVER");

        public static string MSSQL_DATABASE = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_DATABASE")) ? "SalesSystem" : Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_DATABASE");

        public static string MSSQL_USER = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_USER")) ? "sa" : Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_USER");

        public static string MSSQL_PASSWORD = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_PASSWORD")) ? "MyPass@word" : Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_PASSWORD");

        public static string MSSQL_PORT = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_PORT")) ? "1433" : Environment.GetEnvironmentVariable("ASPNETCORE_MSSQL_PORT");

        public static string ENVIRONMENT = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    }
}