using AplicativoAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace AplicativoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; } 
        public DbSet<Professor> Professor {  get; set; } 
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Nota> Notas { get; set; }
    }
}
