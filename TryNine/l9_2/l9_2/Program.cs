/*
 * Created by SharpDevelop.
 * User: Никита
 * Date: 10.10.2017
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ArrayList_studet
{
	public class Student : IComparable, IComparer
	{
		string name;
		double mark;
		public Student()
		{
			name = "NoName";
			mark = 0;
		}
		public Student(string fio, double m)
		{
			name = fio;
			mark = m;
		}
		public void output()
		{
			Console.WriteLine("name is {0} mark = (1)", name, mark);
		}
		public int Compare(Object x0, Object y0)
		{
			Student x = (Student)x0;
			Student y = (Student)y0;
			if (String.Compare(x.name, y.name) < 0)
			{
				return -1;
			}
			else if (String.Compare(x.name, y.name) == 0) 
			{
				if(x.mark < y.mark)
				{
					return -1; 
				}
				else if(x.mark == y.mark)
				{
					return 0; 
				}
				else 
				{ 
					return 1;
				}
			}
			else 
			{
				return 1;
			}
		}
			public int CompareTo(Object x)
			{
				return Compare(this,x);
			}
		}
		class Program
		{
			public static void Main(string[] args)
			{
				Console.Write("Test student");
				Console.Write("\nList student before sort");
				ArrayList x = new ArrayList();
				x.Add(new Student("Nick", 3.5));
				x.Add(new Student("Artem", 2));
				x.Add(new Student("Asya", 4));
				x.Add(new Student("Inna", 2.6));
				x.Add(new Student("Pavel", 1));
				Student st = new Student();
				for (int i=0; i < x.Count; i++)
				{
					st= (Student)x[i];
					st.output();
				}
				IComparer Comp = new Student();
				x.Sort(Comp);
				Console.Write("List after sort");
				for (int i=0; i < x.Count; i++)
				{
					st= (Student)x[i];
					st.output();
				}
			}
		}
	}