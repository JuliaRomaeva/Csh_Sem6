/*Задача 45: Напишите программу,
которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

Console.Clear();
Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine());
int[] array = FillArray(num, min, max);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(min,max + 1);
    }
    return result;
}

int[] CopyArray(int[] array1){
    int[] result = new int[array1.Length];
    for (int i =0; i < array1.Length; i++){
        result[i] = array1[i];
    }
return result;
}

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", CopyArray(array))}]");