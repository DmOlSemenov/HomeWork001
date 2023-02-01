//Задача № 4
Console.WriteLine("Введите число № 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 3 ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write("max =  ");
Console.Write(max);