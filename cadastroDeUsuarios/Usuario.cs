using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace cadastroDeUsuarios
{
    class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public int Age { get; set; }
        public string password { get; set; }

        public User(string name, string email, int age, string password)
        {
            this.name = name;
            this.email = email;
            this.Age = age;
            this.password = password;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Idade: {Age}");
            Console.WriteLine($"Senha: {password}");
        }

        // Propriedade para 'name'
        public string Name
        {
            get => name;  // Retorna o valor de 'name'
            set => name = value;  // Altera o valor de 'name'
        }

        // Propriedade para 'email'
        public string Email
        {
            get => email;  // Retorna o valor de 'email'
            set => email = value;  // Altera o valor de 'email'
        }
        
    }

}




