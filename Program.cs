using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_ja_liikmed;


public class Program
{
    public static void Main()
    {
        Group group = new Group(5);

        // Создаем объекты Type и добавляем их в группу с использованием цикла
        for (int i = 1; i <= 5; i++)
        {
            string name = $"Member{i}";
            int age = 17 + i;
            string color = $"Color{i}";

            group.AddMember(name);

            Type member = new Type(name, age, color);
            group.Types.Add(member);
        }

        Console.WriteLine("Rühma liikmed:");
        foreach (string member in group.Members)
        {
            Console.WriteLine(member);
        }

        Type oldest = group.Oldest();
        Type youngest = group.Youngest();

        Console.WriteLine("\nRühma vanim liige:");
        Console.WriteLine($"Nimi: {oldest.Name}, Vanus: {oldest.Age}, Värv: {oldest.Color}");

        Console.WriteLine("\nRühma noorim liige:");
        Console.WriteLine($"Nimi: {youngest.Name}, Vanus: {youngest.Age}, Värv: {youngest.Color}");

        Console.ReadLine();

    }
}