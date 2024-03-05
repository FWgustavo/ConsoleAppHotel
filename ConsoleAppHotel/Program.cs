using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe Quanto será a diária do hotel: ");
            double diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe Quantidade de adultos: ");
            int adulto = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe Quantidade de crianças: ");
            int crianca = int.Parse(Console.ReadLine());

            double tdiaria = (diaria * adulto) + (diaria * crianca) / 2;

            Console.WriteLine("Sua diária será de: " + tdiaria.ToString("C"));

            Console.WriteLine("Informe o número de dias de hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            double tdias = tdiaria * dias;

            Console.WriteLine("O valor total da hospedagem é de: " + tdias.ToString("C"));

            Console.WriteLine("Informe o número de parcelas: ");
            int parcela = int.Parse(Console.ReadLine());

            double parvalor = tdias / parcela;
            
            Console.WriteLine("Você ira pagar: " +parvalor.ToString("C"));
            Console.ReadKey();


        }
    }
}
