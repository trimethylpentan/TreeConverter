using System;
namespace TreeConverter
{
	public class PathInput : InputInterface
	{
		readonly string message;

		public PathInput(string message)
		{
			this.message = message;
		}

		public string GetInput()
		{
			Console.WriteLine(message);

			return Console.ReadLine();
		}
	}
}
