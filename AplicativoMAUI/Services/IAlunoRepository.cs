using AplicativoMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AplicativoMAUI.Services
{
    public interface IAlunoRepository
    {
     //   public Task<Aluno> ImprimirNotas(int id);
        public Task<Aluno> GetAluno(int id);
        
    }
}
