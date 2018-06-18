using System;
using System.IO;
namespace TreeConverter
{
    abstract public class AbstractFileConverter
    {
        protected FileInfo[] GetFilesInDirectory(string directory, string filter)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            return directoryInfo.GetFiles(filter, SearchOption.AllDirectories);
        }
    }
}
