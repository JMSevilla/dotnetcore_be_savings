using BSbankcore.DB;
using BSbankcore.Model;
using BSbankcore.Repository.Injects;

namespace BSbankcore.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApiDbContext _apiDbContext;
        public UsersRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext ??
                throw new ArgumentNullException(nameof(apiDbContext)); ;
        }

        public async Task<Users> createUser(Users user)
        {
            user.usertype = "1";
            user.accountlock = "1";
            user.verified = "0";
            string hashpass = BCrypt.Net.BCrypt.HashPassword(user.password);
            user.password = hashpass;
            _apiDbContext.Users.Add(user);
            await _apiDbContext.SaveChangesAsync();
            return user;
        }
    }
}
