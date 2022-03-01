// See https://aka.ms/new-console-template for more information

using ExemploColecoes.Helper;
using System.Linq;

// LINQ
int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19,19,4,100 };

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

Console.WriteLine($"Mínimo: {minimo}");
Console.WriteLine($"Máximo: {maximo}");
Console.WriteLine($"Médio: {medio}");
Console.WriteLine($"Total: {soma}");
Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");

var numerosParesQuery =
    from num in arrayNumeros
    where num % 2 == 0
    orderby num
    select num;

var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));

// DICTIONARY
Dictionary<string, string> estados = new();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string valorProcurado = "SC";


if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
{
    Console.WriteLine(estadoEncontrado);
}
else
{
    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
}

Console.WriteLine($"Removendo o valor: {valorProcurado}");

estados.Remove(valorProcurado);

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Valor original");
Console.WriteLine(estados[valorProcurado]);

estados[valorProcurado] = "BA - teste atualização";

Console.WriteLine("Valor atualizado");
Console.WriteLine(estados[valorProcurado]);

// PILHA
Stack<string> pilhaLivros = new();
pilhaLivros.Push(".NET");
pilhaLivros.Push("DDD");
pilhaLivros.Push("Código Limpo");


Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

while (pilhaLivros.Count > 0)
{
    Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
    Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
}

Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

// FILA
Queue<string> fila = new();
fila.Enqueue("Marcelo");
fila.Enqueue("David");
fila.Enqueue("Maria");

Console.WriteLine($"Pessoas na fila: {fila.Count}");
while (fila.Count > 0)
{
    Console.WriteLine($"Vez de: {fila.Peek()}");
    Console.WriteLine($"{fila.Dequeue()} atendido");
}

Console.WriteLine($"Pessoas na fila: {fila.Count}");

// LISTA
OperacoesLista opLista = new();
List<string> estados2 = new() { "SP", "MG", "BA" };
string[] estadosArray = new string[2] { "SC", "MT" };

Console.WriteLine($"Quantidades de elementos na lista : {estados2.Count}");
opLista.ImprimirListaString(estados2);

Console.WriteLine("Removendo o elemento");
estados2.Remove("MG");

estados2.AddRange(estadosArray);
estados2.Insert(1, "RJ");
Console.WriteLine($"\nQuantidades de elementos na lista : {estados2.Count}");
opLista.ImprimirListaString(estados2);

// ARRAY
OperacoesArray op = new();
int[] array = new int[5] { 6, 3, 8, 1, 9 };
int[] arrayCopia = new int[10];
string[] arrayString = op.ConverterParaArrayString(array);

int valorProcuradoNum = 1;

Console.WriteLine($"Capacidade atual do array: {array.Length}");

op.RedimencionarArray(ref array, array.Length * 2);
Console.WriteLine($"Capacidade atual do array após redimencionar: {array.Length}");


int indice = op.ObterIndice(array, valorProcuradoNum);
if (indice > -1)
{
    Console.WriteLine("O indice do elemento {0} é : {1}", valorProcurado, indice);
}
else
{
    Console.WriteLine("Valor não existente no array.");
}



int valorAchado = op.ObterValor(array, valorProcuradoNum);
if (valorAchado > 0)
{ 
    Console.WriteLine("Encontrei o valor");
}
else
{
    Console.WriteLine("Não encontrei o valor");
}



bool todosMaioQue = op.TodosMaiorQue(array, valorProcuradoNum);
if (todosMaioQue)
{
    Console.WriteLine("Todos os valores são maiores que {0}", valorProcuradoNum);
}
else
{
    Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcuradoNum);
}


bool existe = op.Existe(array, valorProcuradoNum);

if (existe)
{
    Console.WriteLine("Encontrei o valor: {0}", valorProcuradoNum);
}
else
{
    Console.WriteLine("Não encontrei o valor: {0}", valorProcuradoNum);
}

Console.WriteLine("Array original");
op.ImprimirArray(array);

op.OrdenarBubbleSort(ref array);
op.Ordenar(ref array);


Console.WriteLine("Array Ordenado:");
op.ImprimirArray(array);

Console.WriteLine("Array antes da cópia:");
op.ImprimirArray(arrayCopia);

op.Copiar(ref array, ref arrayCopia);
Console.WriteLine("Array após a cópia:");
op.ImprimirArray(arrayCopia);

int[,] matriz = new int[4, 2]
{
    {8, 8}, {10, 20}, {50, 100}, {90, 200}
};

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j]);
    }
}

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

Console.WriteLine("Percorrendo o array pelo For");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);
}

Console.WriteLine("\nPercorrendo o array pelo ForEach");
foreach (int item in arrayInteiros)
{
    Console.WriteLine(item);
}