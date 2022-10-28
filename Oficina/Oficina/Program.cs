

using Models;

namespace Oficina
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Pneu pneuMichelan = new Pneu(16, "Michelan");

            Carro poxer = new Carro("Ferrari", "Esportivo");
            poxer.LigarDesligar();
            


            for (int i = 0; i < 20; i++)
            {                
                poxer.Acelerar(100);
                poxer.Frear(10);
            }

            poxer.Exibir();
            
        }
    }
}