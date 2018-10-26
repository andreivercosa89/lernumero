using System;
namespace lernumero
{
    public class Calcular
    {

        private int numero;

        public void definiNumero(int valor)
        {
            numero = valor;
        }
        public int getValor()
        {
            return numero;
        }

        public int antecessor()
        {
            return (numero-1);
        }

        public int sucessor()
        {
            return (numero+1);
        }
    }
}

