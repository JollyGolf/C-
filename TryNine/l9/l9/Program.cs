/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 10.10.2017
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace interf1
{
     interface Scope
        {
            double scope(); 
        }
     interface Area
        {
            double area(); 
        }
//1
class A: Scope
    {
	double a, b, h;
        public A()
        {
        }
        public A(double aa, double bb, double hh)
        {
            a=aa;
            b=bb;
            h=hh;
        }
        public double scope()
        {                        
            return (a*b*h);
        }        
    }
//2
class B: Area
    {
	double c, d;
        public B()
        {
        }
        public B(double cc, double dd)
        {
            c=cc;
            d=dd;
        }
        public double area()
        {                        
            return (c*d);
        }        
    }
class Program
    {        
        public static void Main(string[] args)
        {
            double a, b, h;
            Console.WriteLine("Enter a=");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b=");
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter h=");
            h=Convert.ToDouble(Console.ReadLine());
            A ob=new A(a,b,h);
            double sScope;
            sScope=ob.scope();
            Console.WriteLine("Scope = "+sScope);
            double c, d;
            Console.WriteLine("Enter c=");
            c=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter d=");
            d=Convert.ToDouble(Console.ReadLine());
            B ob2=new B(c,d);
            double sArea;
            sArea=ob2.area();
            Console.WriteLine("Area = "+sArea);         
            Console.Write("Press key to continue");
            Console.ReadKey(true);
        }
    }
}
