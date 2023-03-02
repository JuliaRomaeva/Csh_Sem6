// /Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", ReversArray(array))}]");

int[] ReversArray(int[] array1){
    int[] result = new int[array1.Length];
    for (int i =0; i < array1.Length; i++){
        result[i] = array1[array1.Length - 1 - i];
    }
return result;
}
