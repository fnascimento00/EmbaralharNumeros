using System;
using System.Linq;
using System.Collections.Generic;

namespace EmbaralharNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string _valores = GerarSequencia(5);

            Console.WriteLine(_valores);
            Console.ReadKey();
        }

        private static string GerarSequencia(int quantidadeItens)
        {
            Random _random = new Random();
            Dictionary<int, int> _lista = new Dictionary<int, int>();

            for (int _i = 0; _i < quantidadeItens; _i++)
            {
                _lista.Add(_i + 1, _random.Next());
            }

            int[] _sequencia = _lista.OrderBy(x => x.Value).Select(x => x.Key).ToArray();
            return string.Join(",", _sequencia);
        }
    }
}
