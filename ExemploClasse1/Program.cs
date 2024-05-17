using System;
namespace ExemploClasse1
{
    class Aluno
    {
        string nome;
        // Criando o método construtor
        public Aluno(string n)
        {
            nome = n;
        }
        //Método setNome: Coloca valor no atributo nome
        public void setNome(string n)
        {
            nome = n;
        }
        //Método getNome: Retorna o valor do atributo nome
        public string getNome()
        {
            return nome;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string pNome, sNome;
            //Cria o objeto "alu" que é a instância da classe "Aluno"
            Console.WriteLine("Qual é o primeiro nome do aluno?");
            pNome = Console.ReadLine();
            Console.WriteLine("Qual é o sobrenome do aluno?");
            sNome = Console.ReadLine();
            Aluno alu = new Aluno(pNome+" "+sNome);
            Console.WriteLine("O nome do aluno é " + alu.getNome());
            alu.setNome(pNome);
            Console.WriteLine("O primeiro nome do aluno é " + alu.getNome());
        }
    }
}
