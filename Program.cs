//Получить случайное число от 1 до 100
// int num =new Random().Next(1,100);
// Console.WriteLine(num);

// int num =new Random().Next(10,100);
// Console.WriteLine(num);

// int a=num/10;
// int b=num%10;

// if (a>b)
// {
//     Console.WriteLine("Наибольшая цифра: " +a);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра: " +b);
// }


// // Напишите программу, которая выводит случайное число из отрезка 
// // [10, 99] и показывает наибольшую цифру числа.

// int num =new Random().Next(10,100);
// Console.WriteLine(num);

// int a= num/10;
// int b = num%10;

// if(a>b)
// {
//     Console.WriteLine("Наибольшая цифра: "+ a);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра: "+ b);
// }

// int num =new Random().Next(100,1000);

// Console.WriteLine(num);

// int a = num/100;
// int d = num%10;
// int result = a*10+d;

// Console.WriteLine(result);


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


Console.WriteLine("Введите число 1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2=Convert.ToInt32(Console.ReadLine());

if (number1==number2*number2)
{
    Console.WriteLine(number1+ " является квадратом " + number2);
}    
else if (number2==number1*number1)
{
     Console.WriteLine(number2+ "является квадратом " +number1);
}
Console.WriteLine("не являются квадратом");