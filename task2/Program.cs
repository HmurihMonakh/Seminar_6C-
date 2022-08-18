//Решение в группах задач:
//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: 
//каждая сторона треугольника меньше суммы двух других сторон

//Для любых трех точек A, B и С, не лежащих на одной прямой, 
//справедливы неравенства: AB < AC + CB, AC < AB + BC, BC < BA + AC.
/*
bool Tri(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    else
    {
        return false;
    } 
}

Console.WriteLine(Tri(5, 1, 3));*/

Console.Write("Введите длинну первой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну второй стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну третьей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < (b + c) && b < (a + c) && c < (a + b)) Console.WriteLine("Да, это треугольник!");
else Console.WriteLine("Нет, это не треугольник!");





















