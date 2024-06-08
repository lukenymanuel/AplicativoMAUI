using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoMAUI.Models
{
    public class Aluno
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        
        public Curso Curso { get; set; }
        
        public List<Nota> Notas { get; set; }
        
        public int Cargo {  get; set; } = 0;
        
        public Turma Turma { get; set; }
    }
}
