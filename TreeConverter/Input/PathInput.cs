using System;
using System.IO;
namespace TreeConverter
{
	public class PathInput : InputInterface
	{
		readonly string message;

        string errorMessage;

		public PathInput(string message)
		{
			this.message = message;
		}

		public string GetInput()
		{
			Console.WriteLine(message);

			string directoryInput = Console.ReadLine();

			return directoryInput;
		}

		public bool IsValid(string input)
		{
            if (Path.IsPathRooted(input))
            {
                return true;
            }
            errorMessage = "Der angegebene Pfad ist falsch";
            return false;
                
            //try
            //{
            //    Path.IsPathRooted(input);
            //    return true;
            //}
            //catch
            //{
            //    errorMessage = "Der angegebene Pfad ist falsch.";
            //    return false;
            //}
		}

        public string GetErrorMessage()
        {
            return errorMessage;
        }
    }
}
