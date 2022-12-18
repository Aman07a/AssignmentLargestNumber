/*
Write a C//program to find out largest number among three numbers, using "if".
Eg:
num1 = 60
num2 = 45
num3 = 123
Output: 123
*/
namespace AssignmentLargestNumber
{
	internal class Program
	{
		static void Main()
		{
			// Inputs
			int num1 = 60, num2 = 45, num3 = 123;
			int biggest;

			// num1 is greater than num2
			if (num1 > num2)  
				// num1 is greater than num2 and num1 is greater than num3
				if (num1 > num3)  
					biggest = num1;
				// num1 is greater than num2 and num3 is greater than num1
				else  
					biggest = num3;
			// num2 is greater than num1
			else
				// num2 is greater than num1 and num2 is greater than num3
				if (num2 > num3)
					biggest = num2;
			// num2 is greater than num1" and "num3 is greater than num2
			else  
				biggest = num3;

			System.Console.WriteLine(biggest);
			System.Console.ReadKey();
		}
	}
}
