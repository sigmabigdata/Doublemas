/*string[,] table = new string[5,8];
table[1, 2] = "Слово";*/

/*for (int rows = 0; rows < 2; rows++)
{
    for(int colums = 0; colums < table.Getlength(0); colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}*/



void PrintArray(int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);