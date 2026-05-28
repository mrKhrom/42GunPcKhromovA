using System;

class Program
{
	static void Main(string[] args)
	{
		// Task 1
		Console.WriteLine("Task 1");
		int n1 = 0, n2 = 1, n3;
		Console.WriteLine(n1);
		Console.WriteLine(n2);
		for (int i = 2; i < 10; i++)
		{
			n3 = n1 + n2;
			Console.WriteLine(n3);
			n1 = n2;
			n2 = n3;
		}


		// Task 2
		Console.WriteLine("Task 2");
		for (int i = 1; i <= 20; i++)
		{
			if(i%2 == 0)
				Console.WriteLine(i);
		}

		// Task 3
		Console.WriteLine("Task 3");
		for (int i = 1; i <= 5; i++)
		{
			for (int j = 1; j <= 5; j++)
			{
				Console.Write((i * j).ToString().PadLeft(3));
			}
			Console.WriteLine();
		}
		// Task 4
		Console.WriteLine("Task 4");
		string password = "qwerty";
		do
		{
			Console.Write("Enter password: ");
			string input = Console.ReadLine();
			if (input == password)
			{
				Console.WriteLine("Access granted.");
				break;
			}
			else
			{
				Console.WriteLine("Access denied. Try again.");
			}
		} while (true);
	}
}