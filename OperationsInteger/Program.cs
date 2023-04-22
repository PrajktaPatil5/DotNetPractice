
using System;
public class operation{
  
  public static void Main(string[] args)
  {
// int a = 55;
// int b = 6;
// int c = a + b;
// Console.WriteLine("addition is : "  + c);
// int d = a - b;
// Console.WriteLine("substraction is : " + d);
// int e = a * b;
// Console.WriteLine("multification is : " + e);
// int f = a / b;
// Console.WriteLine("division is : " + f);

    program2 p = new program2();
    Console.WriteLine(p.add(2,3));

    MathOper m = new MathOper();
    Console.WriteLine(m.oper(4, 5, 7));

    IntegerPre i = new IntegerPre();
    Console.WriteLine(i.pp(7,4,3));

    IntegerPre ip = new IntegerPre();
    Console.WriteLine(ip.pp(7,4,3));

    program3 p3 = new program3();
    Console.WriteLine(p3.dou(5,4,2));

    area a = new area();
    Console.WriteLine(a.aa(2.50));
  }
    
}