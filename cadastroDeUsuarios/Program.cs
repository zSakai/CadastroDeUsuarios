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
            // Criar uma instância da classe Usuario
            User user = new User("Lucas", "numsei@gmail.com", 16, "03Lu..17");

            // Chamar o método DisplayInformation para exibir as informações
            user.DisplayInformation();
        }
    }
}
