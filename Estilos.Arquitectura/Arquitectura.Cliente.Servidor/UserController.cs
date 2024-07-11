namespace Arquitectura.Cliente.Servidor
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public User GetUserById(string id)
        {
            return _userService.GetUserById(id);
        }

        public void SaveUser(User user)
        {
            _userService.SaveUser(user);
        }
    }
}