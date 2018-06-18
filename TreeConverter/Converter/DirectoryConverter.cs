using System.IO;

namespace TreeConverter
{
    public class DirectoryConverter : AbstractFileConverter
    {
        public void CreateNewDirectoyWithObjects(string oldDirectoryName, string newDirectoryName, string objectName)
        {
            Directory.CreateDirectory(newDirectoryName);
            foreach (FileInfo fileToCopy in GetFilesInDirectory(oldDirectoryName, "*.l3dobj"))
            {
                DirectoryInfo newDirectory = new DirectoryInfo(newDirectoryName);
                string newFileName = newDirectoryName + "\\" + fileToCopy.Name.Replace(objectName, newDirectory.Name);

                fileToCopy.CopyTo(newFileName, false);
            }
        }
    }
}
