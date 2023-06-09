// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
Console.Clear();

void ArrayFibo(int num)
{
    int length = (num * 2)-1;
    int[] array = new int[length];
    array[length / 2] = 0;
    array[length / 2 + 1] = 1;
    array[length / 2 + 2] = 1;
    for (int i = length / 2+3; i < length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    array[length / 2 -1] = -1;
    array[length / 2 -2] = -1;
    for(int j = length/2-3; j>=0; j--)
    {
        array[j] = array[j + 1] + array[j + 2];
    }
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
}

int num = Convert.ToInt32(Console.ReadLine());
ArrayFibo(num);