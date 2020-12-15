using System;
namespace Exercício_2___Produtos.Classes
{
    public class Produto
    {
        public string Nome {get; set;}
        public int Codigo {get; set;}
        public string Descricao {get; set;}
        public int Estoque {get; set;}

        public Produto(){

        }
        public Produto(string nome, int codigo, string descricao, int estoque){

            if(codigo >= 10){
                Console.WriteLine("Valor inválido");
            }else{
            Nome = nome;
            Codigo = codigo;
            Descricao = descricao;
            Estoque = estoque;

            Console.WriteLine($"Nome do produto cadastrado {Nome ?? "Sem nome"} - Código do produto {Codigo} - Descrição do produto {Descricao} - Estoque do produto {Estoque}");
            }
        } // fim de método construtor

        public Produto(int estoque){
            if( estoque >=15){
                Estoque = estoque;
                Console.WriteLine("Estoque dentro do padrão");
            }else{
                Console.WriteLine("Estoque reduzido");
            }
            
        }

    }
}