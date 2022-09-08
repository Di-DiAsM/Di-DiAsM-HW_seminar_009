// 073. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем.

Console.Clear();

Console.WriteLine("Введите первое число больше 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число больше 1: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество выводов сложения чисел: ");
int N = Convert.ToInt32(Console.ReadLine());

int Fibonachi(int x, int y, int Z)
{
    
    if (Z == 1) return x;
    if (Z == 2) return y;
    return Fibonachi(x, y, Z - 1) + Fibonachi(x, y, Z - 2);
}

for (int i = 1; i <= N; i++)
{
    Console.Write(Fibonachi(a, b, i) + " ");
}
