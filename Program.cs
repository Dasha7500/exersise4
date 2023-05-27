// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите первое целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число:");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье целое число");
int num3 = Convert.ToInt32(Console.ReadLine());
int maxNumber = num1;
if (num2 > maxNumber)
{
    maxNumber = num2;
}
if (num3 > maxNumber)
 {
    maxNumber = num3;
 }
System.Console.WriteLine("Наибольшее число " + maxNumber);

