using System.Collections.Generic;
using SalesSystemApi.Clients.Domain;

namespace SalesSystemApi.Clients.Infrastructure
{
    public interface ClientRepository
    {
        Client Save(Client client);

        List<Client> Find();

        Client Find(int id);


    }
}