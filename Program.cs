using System;
using System.IO;
using System.Text.Json;
using ClassLibrary08;

class Program
{
    public static void Main()
    {
        string serializedLion =
            "{\"Country\":\"Kenya\",\"HideFromOtherAnimals\":true,\"Name\":\"Lion\",\"WhatAnimal\":\"Lion\",\"Classification\":1}\n";
        Lion? lion = JsonSerializer.Deserialize<Lion>(serializedLion);
        Console.WriteLine($"Lion name: {lion?.Name}");
        Console.WriteLine($"Lion country: {lion?.Country}");
    }
}