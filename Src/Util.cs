using System;
using System.IO;

using static Omlcs.Mathex;

public class Util
{
    public static string RootPath()
    {
        return Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
    }

    public static void Line(int lenght)
    {
        string line = "";

        for (int i = 0; i < lenght; i++)
        {
            if (i % 2 == 0)
            {
                line += "-";
            }
            else
            {
                line += "=";
            }
        }

        Console.WriteLine(line);
    }

    public static void Line()
    {
        Line(25);
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
