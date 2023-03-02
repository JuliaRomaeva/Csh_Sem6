//// **Задача 40:**Напишите программу, которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.
// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

// метод без функции
// Console.Clear();
// Console.Write("Введите сторону 1: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите сторону 2: ");
// int B = int.Parse(Console.ReadLine());
// Console.Write("Введите сторону 3: ");
// int C = int.Parse(Console.ReadLine());
// if( A < B + C && B < A + C && C < B + A){
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");

// с использованием функции
Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");
string[] st = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(st[0]), b = int.Parse(st[1]), c = int.Parse(st[2]);
if (IsTriangle(a, b, c)) {
    Console.WriteLine("Да ");
} 
else
{
    Console.WriteLine("Нет ");
}

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((c + b) > a));
}