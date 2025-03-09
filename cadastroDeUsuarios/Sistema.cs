using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace cadastroDeUsuarios
{
    class System
    {
        private string email {  get; set; }
        private List<User> users = new List<User>();

        public void Menu()
        {
            string option;

            do
            {
                Console.WriteLine("1 - Adicionar novo usuário");
                Console.WriteLine("2 - Exibir todos os usuários");
                Console.WriteLine("3 - Atualizar dados de um usuário");
                Console.WriteLine("4 - Remover um usuário");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Adicionar novo usuário
                        AddUser();
                        break;

                    case "2":
                        // Exibir todos os usuários
                        ShowUsers();
                        break;

                    case "3":
                        // Atualizar dados de um usuário
                        UpdateUser();
                        break;

                    case "4":
                        // Remover um usuário
                        RemoveUser();
                        break;

                    case "5":
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

            } while (option != "5");
        }

        public void AddUser()
        {
            // Solicita os dados para criar um novo usuário
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Idade: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Idade inválida. Tente novamente.");
            }

            Console.Write("Senha: ");
            string password = Console.ReadLine();

            // Cria um novo usuário
            User newUser = new User(name, email, age, password);

            // Adiciona o novo usuário à lista de usuários
            users.Add(newUser);
            Console.WriteLine("Usuário adicionado com sucesso!");
        }

        public void ShowUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            Console.WriteLine("Usuários cadastrados:");
            foreach (var user in users)
            {
                Console.WriteLine($"Nome: {user.Name}, Email: {user.Email}, Idade: {user.Age}");
            }
        }

        public void UpdateUser()
        {
            Console.WriteLine("Digite o email do usuário");
            string email = Console.ReadLine(); // Armazena o email inserido pelo usuário

            // Busca o usuário pela variável 'email'
            User user = users.Find(u => u.Email == email);

            if (user != null) // Se o usuário existir
            {
                Console.Write("Novo Nome: ");
                user.Name = Console.ReadLine();

                Console.Write("Nova Idade: ");
                user.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Usuário atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        public void RemoveUser()
        {
            Console.WriteLine("Digite o email do usuário");
            string email = Console.ReadLine(); // Armazena o email inserido pelo usuário

            // Busca o usuário pela variável 'email'
            User user = users.Find(u => u.Email == email);

            if (user != null) // Se o usuário existir
            {
                users.Remove(user); // Remove da lista
                Console.WriteLine("Usuário removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }

        }
    }
}   

     

    

