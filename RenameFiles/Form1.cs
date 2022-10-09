using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class FrmMain : Form
    {
        string[] JPGfiles;
        int fileCount = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        public static int SearchDirectoryTree(string path, out string[] JPGfiles)
        {
            JPGfiles = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            return JPGfiles.Length;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                txtBoxLoad.Text = FD.SelectedPath;
                fileCount = SearchDirectoryTree(FD.SelectedPath, out JPGfiles);
                txtTotales.Text = fileCount + " files.";
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            foreach (string filePath in JPGfiles)
            {
                Cursor = Cursors.WaitCursor;
                FileInfo finfo = new FileInfo(filePath);
                string nameFile = Path.GetFileNameWithoutExtension(finfo.Name);
                int nbr = Convert.ToInt32(nameFile);
                if (nbr != 1)
                {
                    nbr -= 1;
                    string newName = finfo.DirectoryName + @"\" + nbr + ".jpg";
                    File.Move(filePath, newName);
                }

            }

            Cursor = Cursors.Default;
            txtDone.Text = "Done!";
        }

        private void labelGit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/abdessalam-aadel");
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            txtBoxLoad.Text = path;
            fileCount = SearchDirectoryTree(path, out JPGfiles);
            txtTotales.Text = fileCount + " files.";
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
