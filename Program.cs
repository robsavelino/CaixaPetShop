using CaixaPetShop;
using System.Threading.Tasks;

Caixa caixaDoDia = new Caixa();
caixaDoDia.AbrirCaixa();

Console.WriteLine($"Caixa Aberto em {caixaDoDia.DataCaixa}");

decimal valorTotal;
decimal valorPago;
string aux;

do
{
    Console.Clear();
    Console.WriteLine("Digite o valor da consulta: ");
    aux = Console.ReadLine();

    if(!Decimal.TryParse(aux, out valorTotal))
    {
        Console.WriteLine("Digite um valor valido");
        Thread.Sleep(1500);
    }  
} while (!Decimal.TryParse(aux, out valorTotal));


do
{
    Console.Clear();
    Console.WriteLine("Digite o valor do dinheiro que deseja pagar a consulta: ");
    aux = Console.ReadLine();

    if (!Decimal.TryParse(aux, out valorTotal))
    {
        Console.WriteLine("Digite um valor valido");
        Thread.Sleep(1500);
    }
} while (!Decimal.TryParse(aux, out valorPago));


Console.WriteLine($"O troco sera: ");