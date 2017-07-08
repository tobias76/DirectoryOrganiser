using System.IO;

namespace DirectoryOrganiser
{
    class DirectoryOrganiser
    {
        public string directoryToEdit;
        public int numberOfFiles = 0;


        public void countFilesInDir()
        {
            // Prevents the program crashing if the user doesn't choose a directory.
            if (directoryToEdit != "")
            {
                numberOfFiles = Directory.GetFiles(directoryToEdit, "*", SearchOption.AllDirectories).Length;
            }
        }

        public void organiseDir()
        {

        }

        public void createFolder(string filetype)
        {
            if (!Directory.Exists(directoryToEdit + "/" + filetype))
            {
                Directory.CreateDirectory(directoryToEdit + "/" + filetype);
            }
        }
    }
}
