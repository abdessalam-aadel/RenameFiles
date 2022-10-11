using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class FrmMain : Form
    {
        // Array of JPG Files found in Folder
        string[] IMGfiles;
        // Creat variable to Counting the number of files in a folder 
        int fileCount = 0;
 
        bool ischecked_JPG = true;
        string typeImg;

        public FrmMain() => InitializeComponent();

        // Handle Methode Search Directory and Get all JPG files found,
        // and bring out to Array of string
        public static int SearchDirectoryTree(string path, string type, out string[] IMGfiles)
        {
            IMGfiles = Directory.GetFiles(path, type, SearchOption.AllDirectories);
            return IMGfiles.Length;
        }

        // Handle Event Click of Buttton Load Folder
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                txtBoxLoad.Text = FD.SelectedPath;
                typeImg = ischecked_JPG ? ".jpg" : ".tif";
                fileCount = SearchDirectoryTree(FD.SelectedPath, "*" + typeImg, out IMGfiles);
                txtTotales.Text = fileCount + " files.";
            }
        }

        // Handle Event Click of Buttton Rename
        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                if (IMGfiles == null || typeImg == null || IMGfiles.Length == 0)
                    return;
                
                Cursor = Cursors.WaitCursor;

                // Creat list of all names in jpg files array
                List<int> listNbr = new List<int>();
                
                foreach (string filePath in IMGfiles)
                {
                    FileInfo finfo = new FileInfo(filePath);
                    string nameFile = Path.GetFileNameWithoutExtension(finfo.Name);
                    // Convert string to integer
                    int nbr = Convert.ToInt32(nameFile);
                    // Add name to the list
                    listNbr.Add(nbr);
                }

                for (int i = 1; i <= listNbr.Max() - 3; i++)
                {
                    foreach (string filePath in IMGfiles)
                    {
                        FileInfo finfo = new FileInfo(filePath);
                        string nameFile = Path.GetFileNameWithoutExtension(finfo.Name);
                        int nbr = Convert.ToInt32(nameFile);
                        if (nbr > 2)
                        {
                            nbr -= 1;
                            // Creat the same path and new name for the image file
                            string newName = finfo.DirectoryName + @"\" + nbr + typeImg;

                            try
                            {
                                // Move the file
                                File.Move(filePath, newName);
                            }

                            // use IOException to check if the new path is already exists.
                            catch (IOException)
                            {
                                // using continue statement in for each loop 
                                // to skip the further execution of the statements
                                // and transfer the controls back to the 
                                // next iteration of the for each loop 
                                continue;
                            }

                            // Replace old path with new path in JPGfiles Array
                            IMGfiles[Array.IndexOf(IMGfiles, filePath)] = newName;
                        }
                    }
                }

                Cursor = Cursors.Default;
                picCheck.Visible = true;
                txtDone.Text = "Done!";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor = Cursors.Default;
                txtDone.Text = "";
                picCheck.Visible = false;
                txtBoxLoad.Text = "Choose your folder ....";
                txtTotales.Text = "...";
            }
        }

        private void labelGit_Click(object sender, EventArgs e)
        {
            // Go to Github repository
            Process.Start("https://github.com/abdessalam-aadel/RenameFiles");
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (Directory.Exists(path))
            {
                txtBoxLoad.Text = path;
                typeImg = ischecked_JPG ? ".jpg" : ".tif";
                fileCount = SearchDirectoryTree(path, "*" + typeImg, out IMGfiles);
                txtTotales.Text = fileCount + " files.";
                picArrowDown.Visible = false;
            }
            else
                picArrowDown.Visible = false;
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            txtBoxLoad.Text = "Choose your folder ....";
            txtTotales.Text = "...";
            picArrowDown.Visible = true;
            txtDone.Text = "";
            picCheck.Visible = false;
        }

        private void FrmMain_DragLeave(object sender, EventArgs e)
        {
            picArrowDown.Visible = false;
        }

        private void checkJPG_CheckedChanged(object sender, EventArgs e)
        {
            ischecked_JPG = checkJPG.Checked ? true : false;
        }
    }
}
