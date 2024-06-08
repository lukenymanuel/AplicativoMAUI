using AplicativoMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoMAUI.Services
{
    public interface ILoginRepository
    {
        public Task<Aluno> Login(string username, string password);
        
    
    }
}
