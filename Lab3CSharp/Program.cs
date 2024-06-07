using System;

public class Trapeze
{
    // Поля
    private int a, b, h, c;

    // Конструктор
    public Trapeze(int a, int b, int h, int c)
    {
        this.a = a;
        this.b = b;
        this.h = h;
        this.c = c;
    }

    // Властивості
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int H
    {
        get { return h; }
        set { h = value; }
    }

    public int Color
    {
        get { return c; }
    }

    // Метод для виведення довжин
    public void PrintDimensions()
    {
        Console.WriteLine($"Трапеція з основами {a} і {b} та висотою {h}");
    }

    // Метод для розрахунку периметра
    public double CalculatePerimeter()
    {
        // Розрахунок довжин бокових сторін
        double side1 = Math.Sqrt(Math.Pow((a - b) / 2.0, 2) + Math.Pow(h, 2));
        double side2 = side1;
        return a + b + 2 * side1;
    }

    // Метод для розрахунку площі
    public double CalculateArea()
    {
        return ((a + b) / 2.0) * h;
    }

    // Метод для визначення чи є трапеція квадратом
    public bool IsSquare()
    {
        return a == b && a == h;
    }
}

class Program
{
    static void Main()
    {
        // Генеруємо масив трапецій
        Trapeze[] trapezes = new Trapeze[5];
        Random rand = new Random();
        for (int i = 0; i < trapezes.Length; i++)
        {
            int a = rand.Next(1, 21); // Довжина основи a
            int b = rand.Next(1, 21); // Довжина основи b
            int h = rand.Next(1, 21); // Висота h
            int c = rand.Next(1, 10); // Колір c
            trapezes[i] = new Trapeze(a, b, h, c);
        }

        // Виводимо інформацію про трапеції та їх площу і периметр
        int squareCount = 0;
        foreach (Trapeze trapeze in trapezes)
        {
            trapeze.PrintDimensions();
            Console.WriteLine($"Площа: {trapeze.CalculateArea()}");
            Console.WriteLine($"Периметр: {trapeze.CalculatePerimeter()}");
            Console.WriteLine($"Колір: {trapeze.Color}");
            if (trapeze.IsSquare())
            {
                Console.WriteLine("Ця трапеція є квадратом.");
                squareCount++;
            }
            else
            {
                Console.WriteLine("Ця трапеція не є квадратом.");
            }
            Console.WriteLine();
        }

        // Вивід кількості квадратів
        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
