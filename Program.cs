// See https://aka.ms/new-console-template for more information


void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}


int Quadrato(int numero)
{
    int result = numero * numero;

    return result;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQuadro = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayQuadro[i] = array[i] * array[i];
    }

    return arrayQuadro;
}


int sommaElementiArray(int[] array)
{

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}


int[] testArray = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Stampare l’array di numeri fornito a video");
StampaArray(testArray);

Console.WriteLine();

Console.WriteLine("Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato");
int[] quadroArray = ElevaArrayAlQuadrato(testArray);
Console.WriteLine("array quadro: ");
StampaArray(quadroArray);
Console.WriteLine("array originale: ");
StampaArray(testArray);

Console.WriteLine();

Console.WriteLine("Stampare la somma di tutti i numeri");
int arraySum = sommaElementiArray(testArray);
Console.WriteLine("La somma dei numeri nell'array è: " + arraySum);

Console.WriteLine();

Console.WriteLine("Stampare la somma di tutti i numeri elevati al quadrati");
int quadroArraySum = sommaElementiArray(quadroArray);
Console.WriteLine("la somma degli elementi al quadrato è: " + quadroArraySum);