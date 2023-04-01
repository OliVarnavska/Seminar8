// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// // Создаем двумерный массив размером 3x4 и инициализируем его значениями
//         int[,] array = { {1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12} };

//         // Выводим исходный массив
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Меняем строки на столбцы, если это возможно
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);
//         if (rows == cols) {
//             for (int i = 0; i < rows; i++) {
//                 for (int j = i+1; j < cols; j++) {
//                     int temp = array[i, j];
//                     array[i, j] = array[j, i];
//                     array[j, i] = temp;
//                 }
//             }

//             // Выводим измененный массив
//             Console.WriteLine("Измененный массив:");
//             PrintArray(array);
//         } else {
//             Console.WriteLine("Невозможно заменить строки на столбцы!");
//         }
    

//     static void PrintArray(int[,] array) {
//         int rows = array.GetLength(0);
//         int cols = array.GetLength(1);
//         for (int i = 0; i < rows; i++) {
//             for (int j = 0; j < cols; j++) {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }


Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки: ");
int indexrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int indexcolumns = Convert.ToInt32(Console.ReadLine());

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

int[,] matrix = new int[rows, columns];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);