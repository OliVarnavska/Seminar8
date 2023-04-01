// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент 
// входных данных.




void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray2(int[] matr, int[] matr1)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (matr1[i] != 0)
        {
            Console.Write($"Значение {matr[i]} встречается {matr1[i]} раз"); 
            Console.WriteLine();
        }
    }

}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

bool MassiveCheck(int num, int[] matr)
{
bool flag = true;
for (int i = 0; i < matr.Length; i++)
{
    if (matr[i] == num)
    {
        flag = false;
        break;
    }
}
return flag;
}

void CountUniqueDigits(int[,] matr, int[] res1)
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (MassiveCheck(matr[i,j], res1))
            {
                res1[k] = matr[i,j];
                k++;
            }
        }
    }
}

void CountCounts(int[,] matr, int[] res1, int[] res2)
{
    for (int k = 0; k < res1.Length; k++)
    {
        int count = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i,j] == res1[k])
                {
                    count++;
                }
            }
        }
        res2[k] = count;
    }
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
int[] res1 = new int [matrix.GetLength(0) * matrix.GetLength(1)];
int[] res2 = new int [matrix.GetLength(0) * matrix.GetLength(1)];

CountUniqueDigits(matrix, res1);
// PrintArray2(res1);
Console.WriteLine();
CountCounts(matrix, res1, res2);
PrintArray2(res1, res2);