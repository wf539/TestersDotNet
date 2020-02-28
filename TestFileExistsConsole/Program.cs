using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestFileExistsConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("Enter the file to find or entre 'Q' to Quit");
			string strInput = "";

			while (strInput != "Q")
			{
				strInput = Console.ReadLine().ToUpper(); 
				if (File.Exists(strInput))
					Console.WriteLine("File exists: Test Passed");
				else
					Console.WriteLine("File does not exist: Test Failed");
				Console.WriteLine("Enter the file to find or entre 'Q' to Quit");
			}
		}
	}
}
