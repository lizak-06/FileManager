namespace File_Manager
{
    partial class FileManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.Explorer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderTree = new System.Windows.Forms.TreeView();
            this.FolderContents = new System.Windows.Forms.ListView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open_Mouse = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_Mouse = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureList = new System.Windows.Forms.ImageList(this.components);
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.kol_elements = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pathDrive = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Explorer,
            this.btnAboutProgram});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(664, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // Explorer
            // 
            this.Explorer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnClose});
            this.Explorer.Name = "Explorer";
            this.Explorer.Size = new System.Drawing.Size(81, 20);
            this.Explorer.Text = "Проводник";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(180, 22);
            this.btnOpen.Text = "Открыть";
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 22);
            this.btnClose.Text = "Выход";
            // 
            // btnAboutProgram
            // 
            this.btnAboutProgram.Name = "btnAboutProgram";
            this.btnAboutProgram.Size = new System.Drawing.Size(94, 20);
            this.btnAboutProgram.Text = "О программе";
            this.btnAboutProgram.Click += new System.EventHandler(this.btnAboutProgram_Click);
            // 
            // FolderTree
            // 
            this.FolderTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FolderTree.Location = new System.Drawing.Point(0, 27);
            this.FolderTree.Name = "FolderTree";
            this.FolderTree.Size = new System.Drawing.Size(179, 291);
            this.FolderTree.TabIndex = 1;
            this.FolderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FolderTree_AfterSelect);
            // 
            // FolderContents
            // 
            this.FolderContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderContents.ContextMenuStrip = this.contextMenuStrip;
            this.FolderContents.FullRowSelect = true;
            this.FolderContents.HideSelection = false;
            this.FolderContents.LargeImageList = this.pictureList;
            this.FolderContents.Location = new System.Drawing.Point(185, 27);
            this.FolderContents.Name = "FolderContents";
            this.FolderContents.Size = new System.Drawing.Size(479, 291);
            this.FolderContents.TabIndex = 2;
            this.FolderContents.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_Mouse,
            this.копироватьToolStripMenuItem,
            this.Close_Mouse});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(194, 92);
            // 
            // Open_Mouse
            // 
            this.Open_Mouse.Name = "Open_Mouse";
            this.Open_Mouse.Size = new System.Drawing.Size(193, 22);
            this.Open_Mouse.Text = "Открыть";
            this.Open_Mouse.Click += new System.EventHandler(this.Open_Mouse_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.копироватьToolStripMenuItem.Text = "Удалить";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Close_Mouse
            // 
            this.Close_Mouse.Name = "Close_Mouse";
            this.Close_Mouse.Size = new System.Drawing.Size(193, 22);
            this.Close_Mouse.Text = "Выйти из программы";
            this.Close_Mouse.Click += new System.EventHandler(this.Close_Mouse_Click);
            // 
            // pictureList
            // 
            this.pictureList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pictureList.ImageStream")));
            this.pictureList.TransparentColor = System.Drawing.Color.Transparent;
            this.pictureList.Images.SetKeyName(0, "Comic Icons_01 013.ico");
            this.pictureList.Images.SetKeyName(1, "Comic Icons_01 030.ico");
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kol_elements,
            this.toolStripStatusLabel1,
            this.pathDrive});
            this.StatusBar.Location = new System.Drawing.Point(0, 321);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(664, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // kol_elements
            // 
            this.kol_elements.Name = "kol_elements";
            this.kol_elements.Size = new System.Drawing.Size(137, 17);
            this.kol_elements.Text = "Количество элементов:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "                                        ";
            // 
            // pathDrive
            // 
            this.pathDrive.Name = "pathDrive";
            this.pathDrive.Size = new System.Drawing.Size(36, 17);
            this.pathDrive.Text = "Путь:";
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 343);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.FolderContents);
            this.Controls.Add(this.FolderTree);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FileManager";
            this.Text = "Проводник";
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem Explorer;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnAboutProgram;
        private System.Windows.Forms.TreeView FolderTree;
        private System.Windows.Forms.ListView FolderContents;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel kol_elements;
        private System.Windows.Forms.ToolStripStatusLabel pathDrive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Open_Mouse;
        private System.Windows.Forms.ToolStripMenuItem Close_Mouse;
        private System.Windows.Forms.ImageList pictureList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    }
}

