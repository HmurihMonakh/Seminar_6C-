
//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
/*
void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,100);
    }

PrintArray(massive);
Console.WriteLine();

    int value=0;
   
    for(int i = 0; i < massive.Length/2; i++)
    {
        value=massive[i];
        massive[i]=massive[massive.Length-1-i];
        massive[massive.Length-1-i] =value;
    }

PrintArray(massive);*/

////////////////////////////////////////////////////////////////////////

/*
void PrintArray(int[] newCol)
{
    int count = newCol.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(newCol[position] + ", ");
        position++;
    }
}

Console.WriteLine("Enter the massive size");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];


for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(-9,10);


    }


PrintArray(massive);
Console.WriteLine();
int count = size/2;
int bath = 0;
for (int i = 0; i < count; i++ )
{
    bath = massive[i];
    massive[i] = massive[size-1 - i];
    massive[size-1-i] = bath;
}
PrintArray(massive);
*/









