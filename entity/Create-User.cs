using System;

namespace Create.User
{
    public class User
    {
        public readonly Guid Id;
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Id = Guid.NewGuid(); // Corrigindo a geração do Guid
            Name = name;
            Email = email;
        }
    }
}
