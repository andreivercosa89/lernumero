using System;

namespace lernumero
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um numero: ");
            Calcular numero = new Calcular();

            numero.definiNumero(Int32.Parse(Console.ReadLine()));


            Console.WriteLine("Valor: " + (numero.antecessor()+1) + "\nAntecessor: " + numero.antecessor() + "\nSucessor: " + numero.sucessor());
        }
    }
}
