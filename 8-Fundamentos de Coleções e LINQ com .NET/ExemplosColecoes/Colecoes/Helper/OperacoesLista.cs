using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Indice {i}, Valor: {lista[i]}");
            }
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}