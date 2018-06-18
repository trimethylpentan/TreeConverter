using System;

namespace TreeConverter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            ConvertController convertController = new ConvertController();
            convertController.Convert();

            Console.WriteLine("Drücken Sie eine beliebige Taste zum Beenden...");
            Console.ReadKey();
        }
	}
}
