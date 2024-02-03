using System;
using CreatingInterfaceIUserRepository;
using Create.User;

namespace CreateUserUseCase
{
    public class UserUseCase
    {
        private readonly IUserRepository _userRepository;

        public UserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateUser(string name, string email) // Corrigido o nome do método
        {
            var newUser = new User(name, email);
            _userRepository.Create(newUser);
            return newUser;
        }
    }
}
