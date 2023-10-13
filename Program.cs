using System;
using System.Collections;
public delegate T delOne<T>(T x,T y);
public class delDemo
{
    public static void display(int x,int y)
    {
        Console.WriteLine(x+y);
    }
    public static void show(string x,string y)
    {
        Console.WriteLine(x+y);
    }
}
public class Program
{
    static void Main(String[] args)
    {
        delOne<int> =delDemo.display;
        delOne<string>=delDemo.show;
        d1(20,10);
    }
}


