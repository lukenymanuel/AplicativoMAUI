﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoMAUI.Models;
public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Disciplina> Disciplinas { get; set; }
}
