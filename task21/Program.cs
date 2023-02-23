/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[] arrA = new int[3];
int[] arrB = new int[3];

arrA[0] = ReadInt("Введите координаты х точки А");
arrA[1] = ReadInt("Введите координаты y точки А");
arrA[2] = ReadInt("Введите координаты z точки А");
arrB[0] = ReadInt("Введите координаты х точки B");
arrB[1] = ReadInt("Введите координаты y точки B");
arrB[2] = ReadInt("Введите координаты z точки B");

double dist = Math.Round(Math.Sqrt(Math.Pow(arrB[0] - arrA[0], 2) + Math.Pow(arrB[1] - arrA[1], 2) + Math.Pow(arrB[2] - arrA[2], 2)), 2);
Console.WriteLine("Расстояние между точками равно = " + dist);