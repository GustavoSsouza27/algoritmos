using System;

namespace _07_TempoDownload
{
    class Program
    {
        static void Main()
        {
            double tamanhoMB = 0, velocidadeMbps = 0;
            bool entradaValida = false;

            // Entrada e validação do tamanho do arquivo
            while (!entradaValida)
            {
                Console.Write("Digite o tamanho do arquivo Mb: ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out tamanhoMB))
                {
                    if (tamanhoMB > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("O número deve ser maior que zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número.");
                }
            }

            entradaValida = false; // reset para validar a próxima entrada

            // Entrada e validação da velocidade da internet
            while (!entradaValida)
            {
                Console.Write("Informe a velocidade da internet (Mbps): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out velocidadeMbps))
                {
                    if (velocidadeMbps > 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("O valor deve ser maior que zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número.");
                }
            }

            // Cálculo do tempo em minutos
            double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
            double tempoMinutos = tempoSegundos / 60;

            // Saída formatada com 2 casas decimais
            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
        }
    }
}
