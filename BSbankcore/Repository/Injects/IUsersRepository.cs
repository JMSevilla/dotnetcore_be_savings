using BSbankcore.Model;

namespace BSbankcore.Repository.Injects
{
    public interface IUsersRepository
    {
        Task<Users> createUser(Users user);
    }
}
