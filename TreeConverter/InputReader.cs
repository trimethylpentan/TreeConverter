using System;
using System.Collections.Generic;
namespace TreeConverter.Input
{
	public class InputReader
	{
		Dictionary<string, string> inputs = new Dictionary<string,string>();

		public void AddInput(string inputName, InputInterface input)
		{
			inputs.Add(inputName, input.GetInput());
		}

		public Dictionary<string, string> GetInputResults()
		{
			return inputs;
		}
	}
}
