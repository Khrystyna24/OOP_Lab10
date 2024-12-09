using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ArrayList arrayList = new ArrayList();

        arrayList.Add("Програмування");
        arrayList.Add(10);
        arrayList.Add(20.5);

        Console.WriteLine("Елементи ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine($"{item} ({item.GetType()})");
        }

        arrayList.Remove(10);
        Console.WriteLine("\nПісля видалення елемента:");
        foreach (var item in arrayList)
        {
            Console.WriteLine($"{item} ({item.GetType()})");
        }

        Console.WriteLine($"Кількість елементів: {arrayList.Count}");

        arrayList.Clear();
        Console.WriteLine($"ArrayList очищено. Кількість елементів: {arrayList.Count}");
    }
}

