// Задача 5: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите текст:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1>number2)
// {
//     Console.WriteLine("Наибольшее число {number1}"); 
// }
// else
// {
//     Console.WriteLine("Наибольшее число {number2}");
// }





// Задача 6: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет



// Задача 8: Напишите программу, которая на вход принимает число (N), а на 
// выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



//Задача 1
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// Вводим переменную int, куда кладем значение от пользоватеся, конвертируем данные.
// С помощью другой переменной int sqt получаем значение квадрата и выводим на печать.

// Console.WriteLine("Введите текст:");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqt = number*number;
// Console.WriteLine(sqt);


// Задача 2
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// Console.WriteLine("Введите число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1==number2*number2)
// {
//     Console.WriteLine("Является");
// }
// else
// {
//     Console.WriteLine("Не является");
// }




// Задача 3
// Напишите программу, которая будет выдавать
//  название дня недели по заданному номеру

// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if(number1==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(number1==2)
// {
//     Console.WriteLine("Вторник");

// }
// else if(number1==3)
// {
//     Console.WriteLine("Среда");

// }
// else if(number1==4)
// {
//     Console.WriteLine("Четверг");

// }
// else if(number1==5)
// {
//     Console.WriteLine("Пятница");

// }
// else if(number1==6)
// {
//     Console.WriteLine("Суббота");

// }
// else if(number1==7)
// {
//     Console.WriteLine("Воскресенье");

// }
// else
// {
//     Console.WriteLine("Такого дня недели у нас нет");
// }

// Задача 4
// Напишите программу, которая на вход принимает одно число 
//(N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int numberNeg=-number1;
while(numberNeg<=number1)
{
    Console.WriteLine(numberNeg);
    numberNeg=numberNeg+1;
}