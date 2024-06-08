using AplicativoAPI.Data;
using AplicativoAPI.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoMAUI.DAL
{
        public class CRepository : IRepository
        {
            private readonly AppDbContext _appDbContext;
            private readonly IMapper mapper;
        
            CRepository(AppDbContext appDbContext, IMapper map) 
            { 
            _appDbContext = appDbContext;
            mapper = map;
            }
            
        public async Task<Aluno> Login(string username, string password) 
        {
            var Aluno = await _appDbContext.Aluno.Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync();
            if (Aluno == null) {
                throw new Exception($"Aluno não encontrado");

            }
            var AlunoDto = mapper.Map<Aluno>(Aluno);
            return AlunoDto;
        }
        }
}
