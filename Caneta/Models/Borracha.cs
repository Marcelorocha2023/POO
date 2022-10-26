using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Borracha
    {
        private string marca;
        private string cor;
        private string tamanho;
        private int duracao;


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Cor
        {
            get { return Cor; }
            set { Cor = value; }
        }
        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        public Borracha (string _marca="luter")
        {
            marca = _marca;
            cor = "Azul";
            tamanho = "5cm";
            duracao = 100;
        }

        public void Apagar ()
        {
            if (duracao < 5);
            {
                Console.WriteLine("Por favor compra outra borracha !");
            }
            
            duracao -= 5;
          
        }

        public void Exibir()
        {
            Console.WriteLine("Marca = " + marca);
            Console.WriteLine("Cor = " + cor);
            Console.WriteLine("Durabilidade = " + duracao);
        }


    }
}
