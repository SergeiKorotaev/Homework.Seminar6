int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Ввдите колличесто чисел, которые хотите ввести: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
FillArray(array);
Console.Write("Ваши числа: ");
Console.WriteLine(string.Join(", ", array));
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.Write($"Вы ввели {count} чисел больше 0");