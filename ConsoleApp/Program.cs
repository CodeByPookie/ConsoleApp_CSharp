using System;

namespace ConsoldeApp 
{
	class Program
	{
		static void Main() 
		{
			//Console.WriteLine("fun called");
			GetUserData();
		}
		static void GetUserData()
		{
			string name = "Karthika Pazhanivel";
			int Age = 23;
			float height = 5.56f;
			bool isEmployed = true;
			double weight = 45.76;
			byte experienceYears = 3;

			//Console.WriteLine($"Name: {name}\nAge: {Age}\nHeight: {height}\nIs Employed: {isEmployed}\nWeight: {weight}\nExperience Years: {experienceYears}");
			
			//Console.WriteLine("Name: " + name, "\n Age: " + Age); //This won’t work

			Console.WriteLine("Name: {0}\nAge: {1}", name, Age); //String.Format
			Console.WriteLine("Name: " + name + "\nAge: " + Age); //String Concatenation
			Console.WriteLine($"Name: {name}\nAge: {Age}"); //String Interpolation
		}
	}
}
