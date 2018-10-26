using System;

namespace lernumero
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um numero: ");
            Calcular calculo = new Calcular();

            calculo.definiNumero(Int32.Parse(Console.ReadLine()));


            Console.WriteLine("Valor: " + calculo.getValor() + "\nAntecessor: " + calculo.antecessor() + "\nSucessor: " + calculo.sucessor());
        }
    }
}
