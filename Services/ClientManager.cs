using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShopStorege.DataBase;
using TopShopStorege.Models.Base;

using TopShopStorege.Services.Interface;

namespace TopShopStorege.Services
{
    public class ClientManager : IClient 
    {
        private readonly StoregShopContext context;

        Client clientRepository =new Client(); 
        
        public ClientManager()
        {
            Console.WriteLine("Indicati numele: ");
            clientRepository.Name = Console.ReadLine();
            Console.WriteLine("Inticati telefonul: ");
            clientRepository.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dati si emailu: ");
            clientRepository.Email = Console.ReadLine();

        }

      

        public void Add_Client()
        {
              
            
                context.Add(clientRepository);
                context.SaveChanges();
                //return clientRepository;
            
         }
    }
}
