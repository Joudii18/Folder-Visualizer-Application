using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace xAcademics
{
    public partial class Form1 : Form
    {
        private Folder root;
        private Folder currentFolder;
        private Visualizer currentStrategy = new TreeVisualizer();

        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            panel1.AutoScroll = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    root = BuildTree(dialog.SelectedPath);
                    root.calculateSize();
                    currentFolder = root;
                    PopulateTreeView(root);
                    panel1.Invalidate();
                }
            }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            currentStrategy = new TreeVisualizer();
            panel1.Invalidate();
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            currentStrategy = new BarChartVisualizer();
            panel1.Invalidate();
        }

        private Folder BuildTree(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Folder folder = new Folder(dir.Name);

            foreach (var file in dir.GetFiles())
                folder.add(new File1(file.Name, (int)file.Length, file.Extension));

            foreach (var sub in dir.GetDirectories())
                folder.add(BuildTree(sub.FullName));

            return folder;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (root == null) return;

            ApplyStrategy(root, currentStrategy);   // set Strategy on all nodes
            currentFolder.visualize(e.Graphics, 20, 20);
            // root.visualize(e.Graphics, 0, 0);       // x,y not used by TreeVisualizer
        }

        // Fill the TreeView with the folder/file hierarchy
        private void PopulateTreeView(Folder rootFolder)
        {
            treeViewFolders.Nodes.Clear();

            TreeNode rootNode = treeViewFolders.Nodes.Add(rootFolder.getName());
            rootNode.Tag = rootFolder;  // store the component object

            AddChildrenToNode(rootFolder, rootNode);

            treeViewFolders.ExpandAll();
        }

        private void AddChildrenToNode(Folder folder, TreeNode parentNode)
        {
            foreach (FileSystemComponent child in folder.children)   // your `children` list
            {
                TreeNode childNode = parentNode.Nodes.Add(child.getName());
                childNode.Tag = child;

                if (child is Folder subFolder)
                {
                    AddChildrenToNode(subFolder, childNode);
                }
            }
        }



        /*  private void panel1_Paint(object sender, PaintEventArgs e)
          {
              if (root == null) return;

              ApplyStrategy(root, currentStrategy);
              root.visualize(e.Graphics, 20, 20);
          } */

        private void ApplyStrategy(FileSystemComponent comp, Visualizer strategy)
        {
            comp.Strategy = strategy;

            if (comp is Folder folder)
            {
                foreach (var child in folder.children)
                    ApplyStrategy(child, strategy);
            }
        }

        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedComponent = e.Node.Tag as FileSystemComponent;
            if (selectedComponent == null) return;

            // If they clicked a folder → show that folder
            if (selectedComponent is Folder folder)
            {
                currentFolder = folder;
            }
            // If they clicked a file → show its parent folder instead
            else if (e.Node.Parent != null && e.Node.Parent.Tag is Folder parentFolder)
            {
                currentFolder = parentFolder;
            }

            panel1.Invalidate();
        }
    }
}
