using BSbankcore.DB;
using BSbankcore.Model;
using BSbankcore.Repository.Injects;

namespace BSbankcore.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApiDbContext _apiDbContext;
        public ClientRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext ??
                throw new ArgumentNullException(nameof(apiDbContext));
        }

        public async Task<Client> openAccount(Client client)
        {
            _apiDbContext.Clients.Add(client);
            await _apiDbContext.SaveChangesAsync();
            return client;
        }
    }
}
