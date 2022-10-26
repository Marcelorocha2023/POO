using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Apontador
    {
        private string marca;
        private string cor;
        private int duracao;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        public Apontador(string _marca = "Fabe")
        {
            marca = _marca;
            cor = "Vermelho";
            duracao = 100;
        }

        public void Apontar ()
        {
            if (duracao < 5) ;
            {
                Console.WriteLine("Por favor comprar outro apontador !");
            }
            duracao -= 5;
        }

        public void Exibir()
        {
            Console.WriteLine("Marca = " + marca);
            Console.WriteLine("Cor = " + cor);  
            Console.WriteLine("Duração = " + duracao);
        }

    }
}
