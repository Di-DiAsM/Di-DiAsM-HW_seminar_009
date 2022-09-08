// // Показать натуральные числа от M до N, N и M заданы

// Console.Write("Введите первое число: ");
// bool firstCheck = int.TryParse(Console.ReadLine(), out int firstNumber);

// Console.Write("Введите второе число: ");
// bool secondCheck = int.TryParse(Console.ReadLine(), out int secondNumber);

// if(firstNumber < secondNumber && firstCheck && secondCheck) PrintNumber(firstNumber, secondNumber);
// else if(firstNumber > secondNumber && firstCheck && secondCheck) PrintNumber(secondNumber, firstNumber);
// else if (!firstCheck || !secondCheck) Console.WriteLine("Введено не число");
// else Console.WriteLine("Числа равны");

// void PrintNumber(int m, int n)
// {
//     Console.WriteLine(m);
//     if (m < n) PrintNumber(++m, n);
// }

// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Print(N, M);
void Print(int n, int m)
{
if (n == m) Console.Write(n);
else
{
Print(n + 1, m);
Console.Write(($" {n} "));
}
}