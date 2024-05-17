using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;  
using System.Threading.Tasks;

namespace Lista9_Ex2
{//Declaração da variáveis membro
    class Produto
    {
        private string nome;
        private float preco;
        private int quantidade;
        //Construtor com 2 parametros (sobrecarregado)
        public Produto(string n, float preco p)
        {
            nome = n;
            preco = p;
            quantidade = 0;
        }//Construtor com 3 parâmetros (sobrecarregado)
        public Produto (string n, float p, int q)
        {
            nome = n;
            preco = p;
            quantidade = q;
        }
        //Metodo setter para variável nome
        public void setNome(string n)
        {
            nome = n;
        }
        //Metodo getter para variável
        public string getNome()
        {
            return nome;
        }
        //Método setter para variável preço
        public void Setpreco(float preco)
        {
            preco = p;
        }
        //Metodo getter para variável
        public float getPreco()
        {
            return preco;
        }
        //Método setter para a avariável quantidade
        public void setquantidade(int q)
        {
            quantidade = q;
        }
        //Método getter para a avariável quantidade
        public int getQuantidade()
        {
            return quantidade;
        }
        public float ValorTotalProd()
        {
            return preco * quantidade;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string n;
            float p;
            int q;

            //Entradas de dados relativos ao segundo produto
            Console.WriteLine("Qual é o nome do primeiro produto?");
            n=Console.ReadLine();
            Console.WriteLine("Qual o preço do primeiro produto?");
            p=float.Parse(Console.ReadLine());

            //Instanciando o primeiro produto com o construtor de 2 parâmetros
            Produto prod1 = new Produto(n,p);

             //Entradas de dados relativos ao segundo produto
            Console.WriteLine("Qual é o nome do segundo produto?");
            n=Console.ReadLine();
            Console.WriteLine("Qual o preço do segundo produto?");
            p=float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de estoque do segundo produto?");
            q=int.Parse(Console.ReadLine());

            //Instanciando o segundo produto com o construtor de 2 parâmetros
            Produto prod2 = new Produto(n,p,q);

            //saida do programa
            Console.WriteLine("O produto" +prod1.getNome() + "custa R$" + prod1.getPreco() + "e está disponivel em estoque na seguinte quantidade:" +prod1.getQuantidade() + "unidades" + "sendo o valor armazenado em estoque o valor de R$" +prod1.ValorTotalProd());
            Console.WriteLine("O produto" +prod2.getNome() +" custa R$" + prod2.getPreco() + "e está disponivel em estoque na seguinte quantidade:" +prod2.getQuantidade() + "unidades" + "sendo o valor armazenado em estoque o valor de R$" +prod2.ValorTotalProd());
            
       }

    }
}
