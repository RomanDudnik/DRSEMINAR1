// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
/*
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"число {number1} является большим");
    Console.WriteLine($"число {number2} является меньшим");
}

else
{
    Console.WriteLine($"число {number2} является большим");
    Console.WriteLine($"число {number1} является меньшим");
}
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//Вариант1:
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"число {num1} является максимальным");
    }
    else
    {
        Console.WriteLine($"число {num3} является максимальным");
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine($"число {num2} является максимальным");
    }
    else
    {
        Console.WriteLine($"число {num3} является максимальным");
    }
}
*/
//Вариант2:
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"число {num1} является максимальным");
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine($"число {num2} является максимальным ");
    }
    else
    {
        Console.WriteLine($"число {num3} является максимальным ");
    }
}
*/
//Вариант3
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 && num2 == num3)
{
    Console.WriteLine($"Все введенные числа равны {num1} ");
}
else
{

    if (num1 == num2 && num1 > num3)
    {
        Console.WriteLine($"Два из введенных чисел равны и являются максимальным числом {num1} ");
    }    
    else
    {

        if (num1 > num2 && num1 == num3)
        {
            Console.WriteLine($"Два из введенных чисел равны и являются максимальным числом {num1} ");
        }
        else
        {

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Число {num1} является максимальным ");
            }
            else
            {

                if (num2 == num3)
                {
                    Console.WriteLine($"Два из введенных чисел равны и являются максимальными {num2} ");
                }
                else
                {

                    if (num2 > num3)
                    {
                        Console.WriteLine($"Число {num2} является максимальным ");
                    }
                    else
                    {
                        Console.WriteLine($"Число {num3} является максимальным ");
                    }
                }    
            }
        }
    }      
}
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет*/

//Вариант1:
/*
Console.WriteLine("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());
int current = (int)number;

if (number < 0)
{
    if (number / 2 < current / 2)
    {
        Console.WriteLine($"Число {number} НЕ является четным ");
    }
    else
    {
        Console.WriteLine($"Число {number} является четным ");
    }
}
else
{
    if (number / 2 > current / 2)
    {
        Console.WriteLine($"Число {number} НЕ является четным ");
    }
    else
    {
        Console.WriteLine($"Число {number} является четным ");
    } 
}
*/
//Вариант2:
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    if (number / 2 == (number - 1) / 2)
    {
    Console.WriteLine($"Число {number} нечётное ");
    }
    else
    {
    Console.WriteLine($"Число {number} четное ");
    }
}
else
{
    if (number / 2 == (number + 1) / 2)
    {
    Console.WriteLine($"Число {number} нечётное ");
    }
    else
    {
    Console.WriteLine($"Число {number} четное ");
    }
}
*/
//Вариант3
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine($"Число {number} чётное ");
}
else
{
    Console.WriteLine($"Число {number} нечетное ");
}
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
/*
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= number)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/