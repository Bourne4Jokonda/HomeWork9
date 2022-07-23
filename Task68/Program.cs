// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int A(int a, int b)
{
      if (a == 0) return b + 1;
      if (a != 0 && b == 0) return A(a - 1, 1);
      if (a > 0 && b > 0) return A(a - 1, A(a, b - 1));
      return A(a, b);
}
Console.WriteLine(A(N, M));