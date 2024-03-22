// criacao do vetor com numeros aleatorios (random)

int[] vetor = new int[100];
Random aleatorio = new Random();


//imprimir valores do vetor de forma aleatoria
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = aleatorio.Next(101);
    Console.Write(vetor[i] + " ");
   
}

Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

//Ordenar os valores com um metodo

Array.Sort(vetor);



//imprimir valores do vetor de forma ordenada

Console.WriteLine("\n");

for (int i = 0; i < vetor.Length; i++)
{

    Console.Write(vetor[i] + " ");
    
}
