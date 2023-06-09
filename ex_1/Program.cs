Console.Clear();

void PositiveNum(int[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count++;
    }
    System.Console.WriteLine($"Колличество введенных чисел пользователей равна: {count}");
}


int[] arrayNum = new int[5];
System.Console.WriteLine("input number: ");
for (int i = 0; i < arrayNum.Length; i++)
{
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var item in arrayNum)
{
    System.Console.Write($"{item} ");
}

System.Console.WriteLine();
PositiveNum(arrayNum);