using AplicativoAPI.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoMAUI.DAL
{
    public interface IRepository
    {
        public Task<Aluno> Login(string username, string password);

    }
}
