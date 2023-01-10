using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesSystemApi.Clients.Domain;
using SalesSystemApi.Clients.Infrastructure.MSSql;
using Microsoft.EntityFrameworkCore.Storage;

namespace SalesSystemApi.Clients.Infrastructure.MSSql
{
    public class MSSqlClientRepository : ClientRepository
    {
        private ClientContext clientContext;

        public MSSqlClientRepository(DbContext context)
        {
            this.clientContext = (ClientContext)context;
            this.clientContext.Database.EnsureCreated();
        }
        public Client Find(int id)
        {
            return Task.Run( () => {return this.clientContext.Clients.FirstOrDefaultAsync(x => x.Id == id); }).Result;
        }

        public List<Client> Find()
        {
            return Task.Run( () => {return this.clientContext.Clients.ToListAsync(); }).Result;
        }

        public  Client Save(Client client)
        {
           this.clientContext.Clients.Add(client);

           this.clientContext.SaveChanges();

           return client;
        }
    }
}