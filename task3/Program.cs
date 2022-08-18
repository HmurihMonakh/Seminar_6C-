
//Задача 42: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

/*Console.WriteLine("Ведите число:");
int a = Convert.ToInt32(Console.ReadLine);
string res = string.Empty;
while (a > 0) //a / 2 !=a
{
    //if(a / 2 > 0) res += "1";
    //if(a % 2 == 0) res = res+"0";
    //a = a % 2;
    res = (a % 2) + res;
    a = a / 2;
}
Console.WriteLine(res);*/

///////////
Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());

string res = string.Empty;

while(num > 0)
{
    res = (num % 2) + res;
    num = num/2;
}

Console.WriteLine(res);







