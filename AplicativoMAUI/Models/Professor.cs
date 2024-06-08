﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoMAUI.Models;

public class Professor 
{   
    public int Id { get; set; }
    public string Username { get; set; }

    public string Password { get; set; }
   
    public List<Turma> Turmas { get; set; }


    public int Cargo { get; set; } = 1;

    public List<Nota> Notas { get; set; }
}
