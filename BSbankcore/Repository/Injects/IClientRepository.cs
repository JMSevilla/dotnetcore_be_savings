using BSbankcore.Model;

namespace BSbankcore.Repository.Injects
{
    public interface IClientRepository
    {
        Task<Client> openAccount(Client client);
    }
}
