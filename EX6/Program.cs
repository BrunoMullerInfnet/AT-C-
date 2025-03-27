using EX6;

class Progrma
{
    static void Main()
    {
        Aluno aluno = new Aluno();

        aluno.nome = "Bruno";
        aluno.curso = "Engenharia de Software";
        aluno.matricula = 12323;
        aluno.mediaDasNotas = 9;

        aluno.ExibirDados();

        string situação = aluno.VerificaAprovacao();
        Console.WriteLine(situação);    
    }
}