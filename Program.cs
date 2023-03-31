using System;
using System.Globalization;

namespace CsE4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 4
            Console.WriteLine("Cálculo de salário funcionário\n\nNúmero de funcionário: ");

            //COLETA DE DADOS
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas: ");
            double horasT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Recebimento p/ Hora: ");
            double recebeHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //CÁLCULO
            double salario = horasT * recebeHora;

            //RETORNO DE DADOS
            Console.Write("\nNUMERO: " + numero);
            Console.Write("\nSALARIO: R$ " + (salario.ToString("F2", CultureInfo.InvariantCulture)));
            Console.Write("\n\nFim do Programa!\n");
        }
    }
}
