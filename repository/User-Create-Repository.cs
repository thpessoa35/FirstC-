using System;
using CreatingInterfaceIUserRepository;
using Create.User;

namespace CreatingRepositoryInMemory
{
    public class UserCreateRepository : IUserRepository
    {
        private User[] usersArray;
        private int currentIndex;

        public UserCreateRepository(int maxSize)
        {
            usersArray = new User[maxSize];
            currentIndex = 0;
        }

        public void Create(User data)
        {
            if (currentIndex < usersArray.Length)
            {
                usersArray[currentIndex] = data;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Limite máximo de usuários atingido");
            }
        }

        public User[] GetAllUsers()
        {
            return usersArray;
        }
    }
}
