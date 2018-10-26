using System;

namespace lernumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorDigitado;
            Console.WriteLine("Informe um numero: ");
            Calcular calcular = new Calcular();

            calcular.definiNumero(Int32.Parse(Console.ReadLine()));


            Console.WriteLine("Antecessor: " + calcular.antecessor() + "\nSucessor: " + calcular.sucessor());
        }
    }
}
