﻿namespace AplicativoAPI.Models;

public class Disciplina
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public Curso? Curso { get; set; }
    public List<Turma>? Turmas { get; set; }
    public string? MatrizProva
        { get; set; }
}