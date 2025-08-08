using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel
            //Sintaxe: tipo nomeVariavel = valor
            string nome = "Fulano de tal";
            nome = "Beltrano";
            Console.WriteLine(nome);

            //declarção de vetores 
            //Siintaxe: tipo[] nomeVariavel = {valor1, valor2, valor3};
            string[] nomes = { "Fulano de tal", "Beltrano", "Sicrano", "João", "José", "Maria" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //Loop FOR
            //for(indice; controle; incremento)
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("{0}° Nome: {1}", i + 1, nomes[i]);
            }
            //Impressão dos 100 primeiros Números Pares 
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine("Número: {0}", i);
            }
            //loop foreach
            // Sintaxe: foreach(variavel in vetor)
            foreach (string varNome in nomes )
                Console.WriteLine("Nome: {0}", varNome);
        
        }
    }
}
