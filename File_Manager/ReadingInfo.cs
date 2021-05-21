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

namespace File_Manager
{
    public class ReadingInfo
    {
        public static void ReadDrive(TreeView tree)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode treeNode = new TreeNode(drive.Name);
                tree.Nodes.Add(treeNode);
                GetSubfolders(treeNode);
            }
        }

        public static void GetSubfolders(TreeNode treeNode)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(treeNode.FullPath);
                foreach (string dir in dirs)
                {
                    string[] tmp = dir.Split('\\');
                    TreeNode newTreeNode = new TreeNode(tmp[tmp.Length - 1]);
                    treeNode.Nodes.Add(newTreeNode);
                }
            }
            catch (Exception)
            {

            }
        }

        //public static void ReadDrive(TreeView tree)
        //{
        //    DirectoryInfo info = new DirectoryInfo(@"../..");
        //    if (info.Exists)
        //    {
        //        TreeNode rootNode = new TreeNode(info.Name);
        //        rootNode.Tag = info;
        //        GetDirectories(info.GetDirectories(), rootNode);
        //        tree.Nodes.Add(rootNode);
        //    }
        //}

        //private static void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        //{
        //    TreeNode aNode;
        //    DirectoryInfo[] subSubDirs;
        //    foreach (DirectoryInfo subDir in subDirs)
        //    {
        //        aNode = new TreeNode(subDir.Name, 0, 0);
        //        aNode.Tag = subDir;
        //        aNode.ImageKey = "folder";
        //        subSubDirs = subDir.GetDirectories();
        //        if (subSubDirs.Length != 0)
        //        {
        //            GetDirectories(subSubDirs, aNode);
        //        }
        //        nodeToAddTo.Nodes.Add(aNode);
        //    }
        //}

        public static void GetFolders(string path, ListView fldCont)
        {
            try
            {
                fldCont.Clear();
                string[] folders = Directory.GetDirectories(path);
                AddElements(folders, fldCont, 1);
                string[] fiels = Directory.GetFiles(path);
                AddElements(fiels, fldCont, 0);
            }
            catch (Exception)
            {
                fldCont.Clear();
            }
        }

        private static void AddElements(string [] elements, ListView fldCont, int image)
        {
            foreach(string element in elements)
            {
                string[] tmp = element.Split(('\\'));
                fldCont.Items.Add(tmp[tmp.Length - 1], image);
            }
        }

        public static void SearchNode(TreeView tv, string path)
        {
            TreeNode res = null;
            foreach(TreeNode tn in tv.Nodes)
            {
                Searching(tn.Nodes, path, ref res);
                if (res!=null)
                {
                    tv.Focus();
                    tv.SelectedNode = res;
                    return;
                }
            }
        }

        private static void Searching(TreeNodeCollection tnc, string path,  ref TreeNode res)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.FullPath == path)
                {
                    res = tn;
                }
                Searching(tn.Nodes, path,ref res);
            }
        }
    }
}
