
using AplicativoMAUI.Models;


namespace AplicativoMAUI.Views;

public partial class AlunoView : ContentPage
{
	public AlunoView(Aluno dados)
	{
		InitializeComponent();
		var _aluno = dados;
        
        Label[] disciplinaLabels = {
                Disciplina1, Disciplina2,Disciplina3,Disciplina4,Disciplina5,Disciplina6,Disciplina7,Disciplina8,Disciplina9,Disciplina10,Disciplina11 , Disciplina12
            };
        Label[] notaP1Labels = {
    NotaP1Disciplina1, NotaP1Disciplina2, NotaP1Disciplina3, NotaP1Disciplina4,
    NotaP1Disciplina5, NotaP1Disciplina6, NotaP1Disciplina7, NotaP1Disciplina8,
    NotaP1Disciplina9, NotaP1Disciplina10, NotaP1Disciplina11, NotaP1Disciplina12
        };
        Label[] notaP2Labels = {
    NotaP2Disciplina1, NotaP2Disciplina2, NotaP2Disciplina3, NotaP2Disciplina4,
    NotaP2Disciplina5, NotaP2Disciplina6, NotaP2Disciplina7, NotaP2Disciplina8,
    NotaP2Disciplina9, NotaP2Disciplina10, NotaP2Disciplina11, NotaP2Disciplina12
};
        Label[] notaPTLabels = {
    NotaProvaTrimestralDisciplina1, NotaProvaTrimestralDisciplina2,
    NotaProvaTrimestralDisciplina3, NotaProvaTrimestralDisciplina4,
    NotaProvaTrimestralDisciplina5, NotaProvaTrimestralDisciplina6,
    NotaProvaTrimestralDisciplina7, NotaProvaTrimestralDisciplina8,
    NotaProvaTrimestralDisciplina9, NotaProvaTrimestralDisciplina10,
    NotaProvaTrimestralDisciplina11, NotaProvaTrimestralDisciplina12
};
        Label[] mediaLabels = {
    MediaDisciplina1, MediaDisciplina2, MediaDisciplina3, MediaDisciplina4,
    MediaDisciplina5, MediaDisciplina6, MediaDisciplina7, MediaDisciplina8,
    MediaDisciplina9, MediaDisciplina10, MediaDisciplina11, MediaDisciplina12 };


        for (int i = 0; i < _aluno.Curso.Disciplinas.Count; i++)
        {
            disciplinaLabels[i].Text = _aluno.Curso.Disciplinas[i].Nome;
        }

        foreach (var nota in _aluno.Notas)
        {
            switch (nota.Prova)
            {
                case "P1":
                    notaP1Labels[nota.Disciplina.Id - 1].Text = nota.Valor.ToString(); // Ajuste conforme sua estrutura de dados
                    break;
                case "P2":
                    notaP2Labels[nota.Disciplina.Id - 1].Text = nota.Valor.ToString(); // Ajuste conforme sua estrutura de dados
                    break;
                    
                case "PT":
                    notaPTLabels[nota.Disciplina.Id - 1].Text = nota.Valor.ToString(); // Ajuste conforme sua estrutura de dados
                    break;
                
            }
        }
        for (int i = 0; i < disciplinaLabels.Length; i++)
        {
            double media =Convert.ToInt32( (notaP1Labels[i].Text + notaP2Labels[i].Text + notaPTLabels[i].Text)) / 3;
            mediaLabels[i].Text = media.ToString("F2"); // Exibe a média com 2 casas decimais
        }


    }
}