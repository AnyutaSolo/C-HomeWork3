//Задача1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void PalidromChek(int number)
{
    int digit1 = number / 10000;
    int digit2 = number % 10000 / 1000;
    int digit4 = number % 10000 % 1000 % 100 / 10;
    int digit5 = number % 10000 % 1000 % 100 % 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine($"Then number {number} is a palindrom");
    }
else 
{
    Console.WriteLine($"The number {number} is not a palindrom");
};

}
Console.Write("Input positiv five-digit number: ");
int currentNumber = Convert.ToInt32(Console.ReadLine());
PalidromChek(currentNumber);
*/

//Задача 2  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Length(double x1, double y1, double c1, double x2, double y2, double c2)
{
    double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(c2-c1)*(c2-c1));
    return l;
}

Console.Write("Write the coordinate of the first point along the axis x: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Write the coordinate of the first point along the axis y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Write the coordinate of the first point along the axis c: ");
double cA = Convert.ToDouble(Console.ReadLine());
Console.Write("write the coordinate of the second point along the axis x: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("write the coordinate of the second point along the axis y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("write the coordinate of the second point along the axis c: ");
double cB = Convert.ToDouble(Console.ReadLine());

double len = Length (xA, yA, cA, xB, yB, cB);
Console.WriteLine($"The distance between the given points is {len}");
*/

//Задача3  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Qube (int number)
{
    int i = 1;
    while(i<=number)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
}

Console.Write("Enter a natural number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Table of cubes of numbers from 1 to " + num + " : ");
Qube(num);
*/
