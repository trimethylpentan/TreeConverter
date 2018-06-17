using System;
using TreeConverter.Input;

namespace TreeConverter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			InputReader inputs = new InputReader();
			const string sourcePath = "sourcePath";
			const string destinationPath = "destinationPath";
			const string textureName = "textureName";

            inputs
                .AddInput(sourcePath, new PathInput("Bitte geben Sie den Pfad zu den zu kopierenden Dateien an:"));

			Console.ReadLine();
        }
	}
}
