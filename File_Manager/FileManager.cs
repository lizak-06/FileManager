using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace File_Manager
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            ReadingInfo.ReadDrive(FolderTree);
            FolderContents.MouseDoubleClick += Open_Mouse_Click;
            btnOpen.Click += Open_Mouse_Click;
            btnClose.Click += Close_Mouse_Click;
        }

        private void FolderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string newPath = Path.GetFullPath(e.Node.FullPath);
            pathDrive.Text = $"Путь: {newPath}";
            if (e.Node.GetNodeCount(true)==0)
            {
                ReadingInfo.GetSubfolders(e.Node);
            }
            ReadingInfo.GetFolders(e.Node.FullPath, FolderContents);
            kol_elements.Text= $"Количество элемнетов: {FolderContents.Items.Count.ToString()}";
        }

        private void btnAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проводник  v 2.0 \n Разработчик: Криушина Елизавета Александровна.", "Проводник", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Open_Mouse_Click(object sender, EventArgs e)
        {
            string path = FolderTree.SelectedNode.FullPath + '\\' + FolderContents.FocusedItem.Text;
            if (File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                ReadingInfo.SearchNode(FolderTree, path);
                ReadingInfo.GetFolders(path, FolderContents);
            }
        }

        private void Close_Mouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            File.Delete(FolderTree.SelectedNode.FullPath + '\\' + FolderContents.FocusedItem.Text);
            ReadingInfo.GetFolders(FolderTree.Nodes.Count.ToString(), FolderContents);
        }

    }
}
