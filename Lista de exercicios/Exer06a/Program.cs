// criacao do vetor com numeros aleatorios (random)

int[] vetor = new int[100];
Random aleatorio = new Random();


//imprimir valores do vetor
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = aleatorio.Next(101);
    Console.Write(vetor[i] + " ");
   
}

Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("\n");

//organizar valores

 bool troca = false;

do
{
       troca = false;

        for (int i = 0; i < vetor.Length - 1; i++)
    {
        

            if (vetor[i] > vetor[i + 1])
    {
                int aux = vetor[i];
                vetor[i] = vetor[i + 1];
                vetor[i + 1] = aux;
                troca = true;

    }
}
} while (troca == true);

Console.WriteLine("\n");

for (int i = 0; i < vetor.Length; i++)
{

    Console.WriteLine(vetor[i] + " ");
    
}