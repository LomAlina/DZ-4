// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// double result = 1;
// result = Math.Pow(numberA, numberB);

int result = 1;
for(int i=1; i <= numberB; i++)
{
    result*=numberA;
}

Console.Write("Ответ равен " + result);