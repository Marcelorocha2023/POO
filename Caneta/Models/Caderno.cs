using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Caderno
    {
        private string marca;
        private int quantidadeMateria;
        private int quantidadeFolha;


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int QuantidadeMateria
        {
            get { return quantidadeMateria; }
            set { quantidadeMateria = value; }
        }

        public string QuantidadeFolha
        {
                get { return QuantidadeFolha; }
                set{QuantidadeFolha = value;}
        }

        public Caderno (string _marca="Timber")
        {
            marca = _marca;
            quantidadeMateria = 12;
            quantidadeFolha = 200;
        }

        public void ArrancarFolha()
        {
            if (quantidadeFolha > 0);
            {
                quantidadeFolha -= 1;
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Marca = " + marca);
            Console.WriteLine("Folhas = " + quantidadeFolha);
            Console.WriteLine("Materias = " + QuantidadeMateria);
        }
    }
}
