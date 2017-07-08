using System;

using System.Windows.Forms;

namespace DirectoryOrganiser
{
    public partial class directoryOrganiser : Form
    {
        DirectoryOrganiser dirOrg = new DirectoryOrganiser();

        public directoryOrganiser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the folder browser
            folderBrowserDialog1.ShowDialog();

            // Save the directory to organise
            dirOrg.directoryToEdit = folderBrowserDialog1.SelectedPath;

            // Show the user which directory you want to edit.
            textBox1.Text = dirOrg.directoryToEdit;

            // Count the files in that directory
            dirOrg.countFilesInDir();

            // Tell the user how many files there are to sort.
            textBox2.Text = dirOrg.numberOfFiles.ToString();
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Create a folder for your files.
            dirOrg.createFolder(itemList.SelectedItem.ToString());
        }
    }
}
