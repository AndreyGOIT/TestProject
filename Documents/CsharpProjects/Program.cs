﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i  + " - FizzBuzz");
    }
    else if (i % 3 == 0) {
        Console.WriteLine(i + " - Fizz");
    }
    else if (i % 5 == 0) {
        Console.WriteLine(i + " - Buzz");
    }
    else {
        Console.WriteLine(i);
    }
}
