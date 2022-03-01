namespace ExemploColecoes.Helper
{
    internal class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Índice {i}, Valor: {lista[i]}");
            }
        }
    }
}
