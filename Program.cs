/*Задача 64: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"*/

Console.Write("Введите значение M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N : ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печатаем все натуральные числа в промежутке от M до N
/// </summary>
/// <param name="start">числа от M = start</param>
/// <param name="end">переменная N = and</param>
/// <returns></returns>
string PrintNumber(int start, int end) // по условию задачи начальное число и последнее, заданое
{
    // Базовый случай - случай выхода из рекурсии
    if (start==end) return start.ToString(); // Когда доходим до конца возврацаем значение 
                     // start, которое переводим в числовое значение

    // Рекурсивный случай - задание рекурсии (вызов функции внутри функции)
    return (start + ","+ PrintNumber(start+1,end));

}

Console.WriteLine(PrintNumber(M,N));