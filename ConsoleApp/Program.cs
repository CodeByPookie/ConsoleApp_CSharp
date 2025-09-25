using System;

namespace ConsoldeApp 
{
	class Program
	{
		static void Main()
		{
			//GetUserData()
			//Operators();
			//Triangle();
			customNamespace.CustomClass customObj = new customNamespace.CustomClass();
			customObj.DisplayMessage();
		}
		static void GetUserData()
		{
			string name = "Karthika Pazhanivel";
			int Age = 23;
			float height = 5.56f;
			bool isEmployed = true;
			double weight = 45.76;
			byte experienceYears = 3;

			Console.WriteLine($"Name: {name}\nAge: {Age}\nHeight: {height}\nIs Employed: {isEmployed}\nWeight: {weight}\nExperience Years: {experienceYears}");

			//Console.WriteLine("Name: " + name, "\n Age: " + Age); //This won’t work

			Console.WriteLine("Name: {0}\nAge: {1}", name, Age); //String.Format
			Console.WriteLine("Name: " + name + "\nAge: " + Age); //String Concatenation
			Console.WriteLine($"Name: {name}\nAge: {Age}"); //String Interpolation
		}
		static void Operators()
		{
			int a = 10;
			int b = 20;
			//Arithmetic Operators
			Console.WriteLine("a + b = " + (a + b));
			Console.WriteLine("a - b = " + (a - b));
			Console.WriteLine("a * b = " + (a * b));
			Console.WriteLine("a / b = " + (a / b));
			Console.WriteLine("a % b = " + (a % b));
			//Relational Operators
			Console.WriteLine("a == b: " + (a == b));
			Console.WriteLine("a != b: " + (a != b));
			Console.WriteLine("a > b: " + (a > b));
			Console.WriteLine("a < b: " + (a < b));
			Console.WriteLine("a >= b: " + (a >= b));
			Console.WriteLine("a <= b: " + (a <= b));
			//Logical Operators
			bool x = true;
			bool y = false;
			Console.WriteLine("x && y: " + (x && y));
			Console.WriteLine("x || y: " + (x || y));
			Console.WriteLine("!x: " + (!x));
			//Assignment Operators
			int c = a; // c = 10
			c += 5;    // c = c + 5
			c -= 3;    // c = c - 3
			c *= 2;    // c = c * 2
			c /= 4;    // c = c / 4
			c %= 3;    // c = c % 3
			Console.WriteLine("Final value of c: " + c);
			Console.WriteLine("-----------------------");
			Console.WriteLine($" a= {a} \n b={b} \n c={c}");
			Console.WriteLine("-----------------------");
			Console.WriteLine("value 1: " + a + b * c); // a concatenates with b*c => value 1: 100
			Console.WriteLine("value 2: " + ( a + b) * c); // value 2: 0 => 30 * 0
			Console.WriteLine("value 3: " + a + ( b * c)); // value 3: 100 => same as value 1
			Console.WriteLine($"value 4: { a + ( b * c)}"); // value 4: 10 + 0 => 10
		}
		static void Triangle()
		{
			int rows = 5;
			for (int i = 1; i <= rows; i++)
			{
				Console.WriteLine(new string('*', i));
			}			
			Console.WriteLine("--------------------------------");

			for (int i = rows; i >= 1; i--)
			{
				Console.WriteLine(new string('*', i));
			}
				
			Console.WriteLine("--------------------------------");
			for (int i = 1; i <= rows; i++)
			{
				Console.WriteLine(new string(' ', rows - i) + new string('*', i));
			}
			Console.WriteLine("--------------------------------");

			for (int i = rows; i >= 1; i--)
			{
				Console.WriteLine(new string(' ', rows - i) + new string('*', i));
			}
			Console.WriteLine("--------------------------------");
			int n = 5;
			// Upper pyramid
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
			}
			// Lower inverted pyramid
			for (int i = n - 1; i >= 1; i--)
			{
				Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
			}
		}
	}
}
namespace customNamespace
{	class CustomClass
	{
		public void DisplayMessage()
		{
			Console.WriteLine("Hello from CustomClass in customNamespace!");
		}
	}
}
