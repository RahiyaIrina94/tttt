//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
double c = Math.Pow(a, b);
Console.WriteLine(c);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNum(int num){
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
   return result;
  }

int sumNum = SumNum(num);
Console.WriteLine(sumNum);


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(0,100);
index++;
}
}
void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
Console.WriteLine(col[position]);
position++;
}
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);

 


