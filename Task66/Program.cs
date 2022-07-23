// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum =0;
Console.WriteLine("введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}");
void Sort(int N )
{    
if ( N < M )
    {
    return;
    }
  sum+=N;
  
Sort ( N - 1 );
}
Sort(N);
Console.WriteLine(sum);