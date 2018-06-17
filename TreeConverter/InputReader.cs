using System;
using System.Collections.Generic;
namespace TreeConverter.Input
{
	public class InputReader
	{
        readonly Dictionary<string, string> inputs = new Dictionary<string, string>();

        public InputReader AddInput(string inputName, InputInterface input)
		{
            string userInput = input.GetInput();

            if (input.IsValid(userInput))
            {
                inputs.Add(inputName, userInput);
                return this;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(input.GetErrorMessage());
            Console.ForegroundColor = ConsoleColor.White;

            return AddInput(inputName, input);
		}

		public Dictionary<string, string> GetInputResults()
		{
			return inputs;
		}
	}
}
