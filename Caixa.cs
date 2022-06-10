using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaPetShop
{
    public class Caixa
    {
        public DateTime DataCaixa { get; private set; }

        public decimal Saldo { get; private set; }

        public void AbrirCaixa(decimal saldoInicial = 0)
        {
            DataCaixa = DateTime.Now;
            Saldo = saldoInicial;
        }
        public void Deposita(decimal valor)
        {
            if (valor < 0)
                return;

            Saldo += valor;
        }

        public void Saca(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficente");
                Console.WriteLine($"O saldo atual é de R$ {Saldo}");
            }
        }

        public decimal CalcularTroco(decimal venda, decimal valor)
        {
            if (venda > valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return -1;
            }
            return valor - venda;
        }

        public decimal DevolverValor(decimal venda, decimal valor)
        {


            if (CalcularTroco(venda, valor) == -1)
            {
                decimal resto = venda - valor;

                Console.WriteLine($"Faltam R${resto} para o valor total da compra");
                Console.WriteLine("Digite o valor restante que deseja pagar");

                valor = Convert.ToDecimal(Console.ReadLine());

                DevolverValor(resto, valor);
            }

            Deposita(valor);
            Saca(CalcularTroco(venda, valor));

            return CalcularTroco(venda, valor);


        }
    }
}
