using System;
using SalesSystemApi.Database.Domain;
using SalesSystemApi.Constants.Configuration;
namespace SalesSystemApi.Database.Domain.MSSql
{
    public class MsSqlRelationalDatabase : RelationalDatabase
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }

        public string Password { get; set; }

        public string Port { get; set; }
        public MsSqlRelationalDatabase()
        {
            this.Server = Constants.Configuration.Constants.MSSQL_SERVER;
            this.Database = Constants.Configuration.Constants.MSSQL_DATABASE;
            this.User = Constants.Configuration.Constants.MSSQL_USER;
            this.Password = Constants.Configuration.Constants.MSSQL_PASSWORD;
            this.Port = Constants.Configuration.Constants.MSSQL_PORT;
        }
    }
}