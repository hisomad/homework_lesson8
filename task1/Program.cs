int GetNumber(string message)
{
    System.Console.Write("Введите" + message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(string.Format("{0,5}", array[i, j] + ""));    
        }
        System.Console.WriteLine();
    }
}

void SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int rows = GetNumber(" количество строк массива: ");
int colums = GetNumber(" количество столбцов массива: ");
int[,] Array = new int[rows, colums];
FillArray(Array);
PrintArray(Array);
SortArray(Array);
System.Console.WriteLine("Измененный массив: " );
PrintArray(Array);