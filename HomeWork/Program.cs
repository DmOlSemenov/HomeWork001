//Задача № 8
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write("Четные числа: ");
while (count < N)
{
    if (count % 2 == 0) Console.Write(count); 
    Console.Write(", ");
    count = count + 1;
    if (count % 2 > 0) count = count + 1;
}