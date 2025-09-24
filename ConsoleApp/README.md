Run comment
-----------
	dotnet run

C# Basics
-----
	namespace	   
		--> A namespace is a container/collection of classes, structs, interfaces, enums, etc.
		--> Helps organize your code and avoid naming conflicts.

	static void Main() --> This is the entry point of a C# console application.
					--> Belongs to the class itself, not to an object. No need to create an instance of the class to run it. 
					--> void Means the method does not return anything.If you wanted, you could also write static int Main() and return an integer (exit code).
					--> Main() This is the primary function that runs first when your program starts. Can have parameters like string[] args -> to receive command-line arguments.
     Rule: Inside a static method, you can only directly call other static methods