namespace Arquitectura.Cliente.Servidor
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User GetUserById(string id)
        {
            return _userRepository.GetUserById(id);
        }

        public void SaveUser(User user)
        {
            _userRepository.SaveUser(user);
        }
    }
}