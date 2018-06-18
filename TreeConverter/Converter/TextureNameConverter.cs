using System.Xml;
using System.IO;
using System;

namespace TreeConverter
{
    public class TextureNameConverter : AbstractFileConverter
    {
        public void ConvertTextureNames(string newTextureName, string directoryName)
        {
            foreach (FileInfo loksimObject in GetFilesInDirectory(directoryName, "*.l3dobj"))
            {
                XmlDocument xmlObject = new XmlDocument();
                xmlObject.Load(loksimObject.FullName);
                XmlElement props = (XmlElement)xmlObject.SelectSingleNode("//OBJECT//Props");

                props.SetAttribute("Texture", newTextureName);
                Console.WriteLine(loksimObject.FullName);
                xmlObject.Save(loksimObject.FullName);
            }
        }
    }
}
