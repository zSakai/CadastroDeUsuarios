using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroDeUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cria uma instância do sistema de usuários
            System System = new System();

            // Criar uma instância da classe Usuario
            User user = new User("Lucas", "numsei@gmail.com", 16, "password123");


            // Chama o método de exibição do menu
            System.Menu();
        }
    }





}
    

