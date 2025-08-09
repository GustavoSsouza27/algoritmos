using System;


namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criação de um vetor para armazenamento de elementos
            //string [] nomes = {"Fulano", ""}
            string[] nomes = new string [100] ;
            string continuar = "S";
            int contador = 0;

            //Loop while
            //Sintaxe: while(expressão booleana....verdadeiro ou falso)
            //método toUpper() converte o texto para maiúsculo
            while (continuar.ToUpper() == "S") 
        { 

                Console.WriteLine("Digite o {0}ª nome:", contador + 1);
            //Append: adiciona um item no vetor
            nomes[contador] = (Console.ReadLine());

            //Incrementar o contator
            contador++;
            Console.WriteLine("Deseja continua (S/N)");
            continuar = (Console.ReadLine());
            }
            Console.WriteLine("Nomes informados:");
            foreach (string str in nomes)
            {
                //!= significa diferente
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        
        }
    }
}
