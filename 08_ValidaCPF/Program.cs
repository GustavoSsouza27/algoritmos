using System;
using System.Text.RegularExpressions;


namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solicite o seu CPF:");
            string cpf = Console.ReadLine();

            cpf = Regex.Replace(cpf, "[^0-9]", "");

            Console.WriteLine($"Somente numero {cpf}");
            if (cpf.Length != 11)
                Console.WriteLine("CPF deve conter 11 digitos: ");
            return;
            {
                Console.WriteLine("CPF deve conter 11 digitos: ");
                return;
            }
            if (cpf == "11111111111" || cpf == "'22222222222") ;
            {
                Console.WriteLine("CPF inválido!! numeros repetidos não são permitidos: ");
                return;
            }
            int soma = 0;
            char[] cpfvetor = cpf.ToCharArray();

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpfvetor[i].ToString()) * (10 - i);
            }
            int resto = soma % 11;

            int digX = 0;
            if (resto >= 2)
            {
                digX = 11 - resto;
            }



            if (
                int.Parse(cpf[9].ToString() == digX &&
                int.Parse(cpf[10].ToString()0 == digY
                )
            {
                Console.WriteLine("Cpf valido");
            }
            else 
            {
                Console.WriteLine("Cpf invalido");    

            }


            






            }
        }
    }
