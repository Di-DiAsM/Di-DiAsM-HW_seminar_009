// 068. Показать натуральные числа от M до N, N и M заданы

Console.Clear();

Console.WriteLine("Введите число больше 1: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());

//***********************************************************************************
string NumbersRecMinus(int a, int b)
{
    if (a == n) return $"{a} ";
    else return  $"{a} " + NumbersRecMinus(a + 1, b) ;
}

Console.WriteLine(NumbersRecMinus(m, n));


//***********************************************************************************
// string NumbersRecMinus(int a, int b)
// {
//     if (a <= b) return $"{a} "+ NumbersRecMinus(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRecMinus(m, n));


//***********************************************************************************

// void NumbersRecPlus(int a = 1, int b)
// {
//     if (a < b) return;
//     Console.Write($"{a} ");
//     NumbersRecMinus(a - 1, b);
// }

// NumbersRecPlus(10, 1);