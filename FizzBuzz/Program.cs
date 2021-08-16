using System;

namespace FizzBuzz
{
    public class Program
    {

        public static void FizzBuzz(int num)
        {
            if(num == 0 || num > 50)
            {                
                Console.WriteLine("O número informado deve ser entre 1 e 50.");
                return;   
            }
            
            var textoFormatado = string.Empty;
            for (var numeroFizzBuzz = 1; numeroFizzBuzz <= num; numeroFizzBuzz++)
            {
                var fizzBuzz = string.Empty;               

                fizzBuzz += CalcularFizzBuzz(numeroFizzBuzz);

                textoFormatado += AdicionarTextoFormatado(fizzBuzz, numeroFizzBuzz);
            }

            Console.WriteLine(textoFormatado);
        }

        static void Main(string[] args)
        {
            FizzBuzz(16);
        }

        private static string CalcularFizzBuzz(int numero)
        {
            var fizzBuzz = string.Empty;
            if (numero % 3 == 0)
                fizzBuzz += eFizzBuzz.Fizz.ToString();

            if (numero % 5 == 0)
                fizzBuzz += eFizzBuzz.Buzz.ToString();

            return fizzBuzz;
        }

        private static string AdicionarTextoFormatado(string fizzBuzz, int numeroFizzBuzz)
        {
            var textoFizzBuzz = string.Empty;

            if (string.IsNullOrEmpty(fizzBuzz))
                textoFizzBuzz += $"{numeroFizzBuzz.ToString()} ";
            else
                textoFizzBuzz += $"{fizzBuzz} ";

            return textoFizzBuzz;
        }

        private enum eFizzBuzz
        {
            Fizz,
            Buzz
        }
    }
}
