int GetNumber(string message)
{
    System.Console.Write("Введите " + message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array)
{
    Random rnd = new Random();
    array[0] = rnd.Next(10, 100);

    for (int i = 1; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 100);
        
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array[j])
            {
                array[i] = rnd.Next(10, 100);
                j = 0;
            }
        }
    }

}

void FillArray(int[,,] array)
{
    int[] NumbersToFillArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    FillArrayRandomNumbers(NumbersToFillArray);
    System.Console.WriteLine("Числа для заполнения массива: " + string.Join(",", NumbersToFillArray) + "\n");
    int count = 0;
    int number = NumbersToFillArray[count];

    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = number;
                count++;

                if (count == NumbersToFillArray.Length) 
                return;
                number = NumbersToFillArray[count];
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(string.Format("{0,13}", array[i, j, k] + $"{(i, j, k)}" + " "));
            }
            System.Console.WriteLine();
        }
    }
}

int rows = GetNumber("количество строк массива: ");
int colums = GetNumber("количество столбцов массива: ");
int floors = GetNumber("количество этажей массива: ");
int[,,] Array = new int[rows, colums, floors];
FillArray(Array);
PrintArray(Array);