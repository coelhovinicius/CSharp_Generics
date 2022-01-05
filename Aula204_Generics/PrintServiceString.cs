using System;

namespace Aula204_Generics
{
    class PrintServiceString
    {
        private string[] _values = new string[10]; // Vetor privado para armazenar ate 10 numeros inteiros
        private int _count = 0; // Variavel privada para fazer a contagem dos numeros inseridos

        // Operacoes
        public void AddValue(string value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value; // Adiciona o valor informado como argumento dentro do vetor na posicao "_count"
            _count++;
        }

        public string First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
