// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً یک کاراکتر وارد کنید:");

        // دریافت کاراکتر
        char character = (char)Console.Read();

        // نمایش کاراکتر دریافتی
        Console.WriteLine($"کاراکتر دریافتی: {character}");
    }
}