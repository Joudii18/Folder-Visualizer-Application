namespace xAcademics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBar = new Button();
            btnTree = new Button();
            panel1 = new Panel();
            btnBrowse = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            treeViewFolders = new TreeView();
            SuspendLayout();
            // 
            // btnBar
            // 
            btnBar.Location = new Point(451, 53);
            btnBar.Name = "btnBar";
            btnBar.Size = new Size(130, 32);
            btnBar.TabIndex = 9;
            btnBar.Text = "Bar Chart";
            btnBar.UseVisualStyleBackColor = true;
            btnBar.Click += btnBar_Click;
            // 
            // btnTree
            // 
            btnTree.Location = new Point(282, 53);
            btnTree.Name = "btnTree";
            btnTree.Size = new Size(130, 32);
            btnTree.TabIndex = 10;
            btnTree.Text = "Tree";
            btnTree.UseVisualStyleBackColor = true;
            btnTree.Click += btnTree_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(282, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 458);
            panel1.TabIndex = 11;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(108, 523);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 41);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(28, 65);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(230, 440);
            treeViewFolders.TabIndex = 13;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 591);
            Controls.Add(treeViewFolders);
            Controls.Add(btnBrowse);
            Controls.Add(panel1);
            Controls.Add(btnTree);
            Controls.Add(btnBar);
            Name = "Form1";
            Text = "X";
            ResumeLayout(false);

        }

        #endregion
        private Button btnBar;
        private Button btnTree;
        private Panel panel1;
        private Button btnBrowse;
        private FolderBrowserDialog folderBrowserDialog1;
        private TreeView treeViewFolders;
    }
}

