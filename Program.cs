using System;
using CreatingRepositoryInMemory;
using CreateUserUseCase;
using Create.User;

namespace SeuNamespace
{
    class Program
    {
        static void Main()
        {
            var userRepository = new UserCreateRepository(10); // Tamanho máximo do array
            var userUseCase = new UserUseCase(userRepository);

            // Criar alguns usuários para testar
            var usuario1 = userUseCase.CreateUser("Joao Silva", "joao.silva@example.com");
            var usuario2 = userUseCase.CreateUser("Maria Oliveira", "maria.oliveira@example.com");

            // Exibir detalhes de todos os usuários
            ExibirDetalhesUsuarios(userRepository.GetAllUsers());
        }

        static void ExibirDetalhesUsuarios(User[] usuarios)
        {
            Console.WriteLine("Detalhes dos Usuários:");
            foreach (var usuario in usuarios)
            {
                if (usuario != null)
                {
                    Console.WriteLine($"ID: {usuario.Id}, Nome: {usuario.Name}, Email: {usuario.Email}");
                }
            }
        }
    }
}
