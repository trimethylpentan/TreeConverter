using System.Collections.Generic;
using System.Text.RegularExpressions;
using TreeConverter.Input;

namespace TreeConverter
{
    public class ConvertController
    {
        public void Convert()
        {
            InputReader inputs = new InputReader();
            const string sourcePath = "sourcePath";
            const string destinationPath = "destinationPath";
            const string textureName = "textureName";
            const string oldObjectName = "oldObjectName";

            Regex validTextureNames =
                new Regex("^[a-zA-Z]+((.png)|(.jpg)|(.bmp)|(.PNG)|(.JPG)|(.BMP))+$");

            inputs
                .AddInput(
                                sourcePath,
                                new PathInput("Bitte geben Sie den Pfad zu den zu kopierenden Dateien an:")
                            )
                            .AddInput(oldObjectName,

                                      new RegexInput("Bitte geben Sie den zu ersetzenden Namen der Objekte an", new Regex(""))
                             )
                            .AddInput(
                                textureName,

                                new RegexInput("Bitte geben Sie den neuen Texturnamen an:", validTextureNames)
                             )
                            .AddInput(
                                destinationPath,

                                new PathInput("Bitte geben Sie den neuen Pfad an:")
                            );

            Dictionary<string, string> validatedInputs = inputs.GetInputResults();

            DirectoryConverter directoryConverter = new DirectoryConverter();
            directoryConverter.CreateNewDirectoyWithObjects(
                validatedInputs[sourcePath],
                validatedInputs[destinationPath],
                validatedInputs[oldObjectName]
            );

            TextureNameConverter textureNameConverter = new TextureNameConverter();
            textureNameConverter.ConvertTextureNames(
                validatedInputs[textureName],
                validatedInputs[destinationPath]
            );
        }
    }
}
