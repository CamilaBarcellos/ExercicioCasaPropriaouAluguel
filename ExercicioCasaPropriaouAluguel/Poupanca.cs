using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCasaPropriaouAluguel
{
    class Poupanca
    {

        public double SaldoDaPoupanca { get; set; }
        public double Juros { get; set; }
        public double ValorRendimento { get; set; }
        public double ValorTotalMes { get; set; }
        public double TotalContaAluguel { get; set; }
        public int TempoMeses { get; set; }
        public double ValorDoAluguel { get; set; }
        public double ValorDeCompraDoImovel { get; set; }


        

        public void CalcularRendimentoDaPoupancaComSaqueDeAluguel()
        {
            ValorTotalMes = SaldoDaPoupanca;
            for (var i = 1; i <= TempoMeses; i++) 
            {
                ValorRendimento = (((Juros / 100) * ValorTotalMes));
                ValorTotalMes += ValorRendimento;
                TotalContaAluguel = ValorTotalMes - ValorDoAluguel;
                ValorTotalMes = TotalContaAluguel;


            }
            
        }

    }
}
