//Задача № 2
Console.WriteLine("Введите число № 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число № 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
Console.WriteLine("max =  ");
Console.Write(max);