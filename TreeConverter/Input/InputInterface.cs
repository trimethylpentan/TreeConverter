using System;
namespace TreeConverter
{
	public interface InputInterface
	{
		string GetInput();

		bool IsValid(string input);

        string GetErrorMessage();
	}
}
