﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}


// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}

/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));


// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число от 1 до 7 и выводит сообщение - выходной день или нет.
// *** Костыль, но я тренировал функции. проблема с return была. ***
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}


 


void Task_28()
        {
            /*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.*/

            Random rand = new Random();
            int number = rand.Next(1, 16);
            Console.WriteLine("Введено число: " + number);
            int counter = 1;
            int sum = 1;

            while (counter <= number)
            {
                Console.Write($"{sum} * {counter} = ");
                sum = sum * counter;
                Console.WriteLine(sum);
                counter++;
            }
            Console.WriteLine("Ответ: " + sum);

            sum = 1;

            while (number > 0)
            {
                sum *= number;
                number--;
            }
            Console.WriteLine("Ответ: " + sum);

        }
        Task_28();

  