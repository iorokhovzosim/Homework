﻿
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/* Console.WriteLine("Введите число 1");

int a = int.Parse (Console.ReadLine());

Console.WriteLine("Введите число 2");

int b = int.Parse (Console.ReadLine());

if (a > b ){
    Console.WriteLine(a);
}
else {
    Console.WriteLine(b);
}
*/


/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*Console.WriteLine("Введите число 1");

int a = int.Parse (Console.ReadLine());

Console.WriteLine("Введите число 2");

int b = int.Parse (Console.ReadLine());

Console.WriteLine("Введите число 3");

int c = int.Parse (Console.ReadLine());

if (a > b & a > c ){
    Console.WriteLine(a);
}
if (b > a & b > c){
    Console.WriteLine(b);
}
if (c > a & c > b){
    Console.WriteLine(c);
}
*/

/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*Console.WriteLine("Введите любое число");

int N = int.Parse (Console.ReadLine());

if (N % 2 == 0){
    Console.WriteLine("Это число - четное");
}
else{
    Console.WriteLine("Это число - нечетное");
}  
 */

 /*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
 
Console.WriteLine("Введите число N");

int N = int.Parse (Console.ReadLine());

int a = 2;

if(N > 1){
    while (a <= N){
        Console.WriteLine(a + " ");
        a = a + 2;
    }
}   
