using System;

namespace SalesSystemApi.Database.Domain
{
    interface RelationalDatabase
    {
        string server;
        string database;
        string user;
        string password;
        string port;
    }
}