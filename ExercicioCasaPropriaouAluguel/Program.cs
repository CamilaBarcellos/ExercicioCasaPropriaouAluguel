using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCasaPropriaouAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Poupanca poupanca = new Poupanca();

            Console.WriteLine("Digite o valor investido na poupança:\n");
            poupanca.SaldoDaPoupanca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor de compra do imóvel:\n");
            poupanca.ValorDeCompraDoImovel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor do aluguel:\n");
            poupanca.ValorDoAluguel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o percentual de rendimento mensal da poupança:\n");
            poupanca.Juros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite quantos meses terá o contrato de aluguel:\n");
            poupanca.TempoMeses = Convert.ToInt32(Console.ReadLine());
            

            poupanca.CalcularRendimentoDaPoupancaComSaqueDeAluguel();

            Console.WriteLine("\n-----------------------------------------------------------");

                 if(poupanca.TotalContaAluguel > poupanca.SaldoDaPoupanca)
                 {
                     Console.WriteLine("\nÉ mais lucrativo alugar o imóvel.\nO saldo final da conta será: R${0 :0.##}",poupanca.TotalContaAluguel);
                 }
                 else if(poupanca.TotalContaAluguel < poupanca.SaldoDaPoupanca)
                 {
                     Console.WriteLine("\nÉ mais lucrativo comprar o imóvel.\nO rendimento da poupança não será suficiente.");
                 }
                 else
                 {
                     Console.WriteLine("\nO saldo final será o mesmo tanto para comprar quanto para alugar o imóvel nessas condições.");
                 }
                 
            Console.ReadLine();
        }
    }
}
