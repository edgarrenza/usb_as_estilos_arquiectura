namespace Arquitectura.Cliente.Servidor
{
    public class UserRepository
    {
        private readonly Dictionary<string, User> _userDatabase = new();

        public User GetUserById(string id)
        {
            _userDatabase.TryGetValue(id, out var user);
            return user;
        }

        public void SaveUser(User user)
        {
            _userDatabase[user.Id] = user;
        }
    }
}