using System.Data.SqlTypes;

namespace Models
{
    public class Caneta
    {
        public string Cor;
        public double Tamanho;
        public double Peso;
        public bool Tampada;
        public bool Caida;
        public bool Estourada;
        public int PercentualCarga;
        public string Marca;
        public string Material;
        public double Ponta;
        public string TipoPonta;

        public Caneta(string _cor, double _tamanho, double _peso, 
                        string _marca, string _material, double _ponta, string _tipoPonta)
        {
            Cor = _cor;
            Tamanho = _tamanho;
            Peso = _peso;
            Marca = _marca;
            Material = _material;
            Ponta = _ponta;
            TipoPonta = _tipoPonta;
            PercentualCarga = 100;
        }

        public void Exibir()
        {
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tamaho: " + Tamanho);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Tampada: " + Convert.ToString(Tampada));
            Console.WriteLine("Caida: " + Convert.ToString(Caida));
            Console.WriteLine("Estourada: " + Convert.ToString(Estourada));
            Console.WriteLine("% de carga: " + PercentualCarga);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Ponta: " + Ponta);
            Console.WriteLine("tipo de ponta: " + TipoPonta);


        }

        public void Cair()
        {
            Caida = true;
        }
        public void PegarDoChao ()
        {
            Caida = false;
        }
        public void Tampar ()
        {
            Tampada = true;
        }
        public void Destampar()
        {
            Tampada = false;
        }

        public void Escrever (string _Texto)
        {
            if (Tampada == true)
            {
                Console.WriteLine("Não é possível escrever com a caneta tampada ! ");
                return;
            }
            if (Caida == true)
            {
                Console.WriteLine("Pegue a caneta do chão.");
                return;
            }
            if(PercentualCarga == 0)
            {
                Console.WriteLine("A caneta está sem tinta.");
                return;
            }
            if(Estourada == true)
            {
                Console.WriteLine("A caneta está estourada");
                return;
            }

            Console.WriteLine( _Texto );
            PercentualCarga -= 10;

        }

    }
}