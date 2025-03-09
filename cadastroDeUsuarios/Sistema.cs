using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace cadastroDeUsuarios
{
    class system
    {
        string User;
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
       
        public void ShowUsers()
        {
            foreach (var user in users)
            {
                user.DisplayInformation();  // Exibe as informações de cada 'user'
                Console.WriteLine("-------------------------");
            }
        }

        public void UpdateUsers(string email, string newName, int newAge, string newPassword)
        {
            // Encontra o usuário pelo email
            var user = users.Find(u => u.Email == email);

            if (user != null)
            {
                // Atualiza as informações do usuário
                user.Name = newName;
                user.Age = newAge;
                user.password = newPassword;
            }
            else
            {
                Console.WriteLine("Usuário não encontrado!");
            }
        }

    }   

    
}
