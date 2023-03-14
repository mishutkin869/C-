// ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 2
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1


// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int a = num%100;
// int result = a/10;

// Console.WriteLine("Вторая цифра: " +result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число, тобы проверить какой это день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num>7&&num<1)
{
    Console.WriteLine("Это не день недели");
}
else if (num<=5)
{
    Console.WriteLine("Будний день, надо поработать");
}
if (num=6)
{
    Console.WriteLine("Наконец-то выходной!");
}





// Задача 1
//Получить случайное число от 1 до 100
// int num =new Random().Next(1,100);
// Console.WriteLine(num);

// int num =new Random().Next(10,100);
// Console.WriteLine(num);

// Задача 2
// Напишите программу, которая выводит случайное число из отрезка (10,99) и показывает наибольшую цифру числа

// int num = new Random().Next(10,100);
// Console.WriteLine(num);

// int a=num/10;
// int b=num%10;

// if (a>b)
// {
//     Console.WriteLine("Наибольшая цифра случайного числа: " +a);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра случайного числа: " +b);
// }



// Задача 3
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int a = num/100;
// int b = num%10;
// int result = a*10+b;

// Console.WriteLine(result);



// Задача 4
// Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int number2=Convert.ToInt32(Console.ReadLine());

// if (number1%number2==0)
// {
//     Console.WriteLine("Кратны");
// }
// else 
// {
//     Console.WriteLine($"Не кратны, остаток от деления равен {number1%number2}");
// }



// Работа в группу
// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=Convert.ToInt32(Console.ReadLine());

// if ((number1%7==0)&&(number1%23==0))
// {
//     Console.WriteLine("Кратны");
// }
// else 
// {
//     Console.WriteLine("Не кратны");
// }


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Работа в группу
// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=Convert.ToInt32(Console.ReadLine());

// if (number1==number2*number2)
// {
//     Console.WriteLine(number1+ " является квадратом " + number2);
// }    
// else if (number2==number1*number1)
// {
//      Console.WriteLine(number2+ " является квадратом " +number1);
// }
// else
// {
//     Console.WriteLine("Не являются квадратом относительно друг друга");
// }
