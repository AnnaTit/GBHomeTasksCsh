// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Если мы точно знаем, что числа не равны, то можно через 1 условие с if/while (вариант 1)
//
//Вариант решения 1 (числа точно не равны)
//
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
   Console.WriteLine("1st number " + num1 + " is > than 2nd number " + num2);
   }
else
{
   Console.WriteLine("2nd number " + num2 + " is > than 1st number " + num1);
           }
//Вариант решения 2 (числа могут оказаться равными, тогда через задание нескольких проверок)            

Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
Console.WriteLine("Numbers are equal");
if (num1 > num2)
Console.WriteLine("1st number " + num1 + " is > than 2nd number " + num2);
if (num2 > num1)
Console.WriteLine("2nd number " + num2 + " is > than 1st number " + num1);
            
//
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
Console.WriteLine("Input 3 numbers:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
   max = num2;
           }
   if (num3 > max)
       {
               max = num3;
           }

Console.WriteLine("Max number is " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input a number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
{
   Console.WriteLine("Number " + num + " is: odd");
   }
else
{
   Console.WriteLine("Number " + num + " is: even");
    }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a = 1;
bool not = true;
Console.WriteLine("Input a number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Odd numbers from 1 to " + num);
while (a <= num)
{
  if (a % 2 != 1)
       {
Console.Write(a + ", ");
not = false;
   }
a++;
   }
if (not)
   {
       Console.WriteLine("Odd numbers not found");
           }

