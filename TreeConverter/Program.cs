using System;
using TreeConverter.Input;
using System.Text.RegularExpressions;

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

            Regex validTextureNames = 
                new Regex("^[a-zA-Z]+((.png)|(.jpg)|(.bmp)|(.PNG)|(.JPG)|(.BMP))+$");

            inputs
                .AddInput(sourcePath, new PathInput(
                    "Bitte geben Sie den Pfad zu den zu kopierenden Dateien an:"
                ))
                .AddInput(textureName, new RegexInput(
                    "Bitte geben Sie den Texturnamen an:",
                    validTextureNames
                ));

            Console.WriteLine("Drücken Sie eine beliebige Taste zum Beenden...");
			Console.ReadLine();
        }
	}
}
