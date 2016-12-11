using System.ComponentModel;
using System.Windows.Forms;

namespace list
{
    partial class commander
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsPanel2 = new System.Windows.Forms.ToolStrip();
            this.currentDirLabel2 = new System.Windows.Forms.Label();
            this.listViewPanel2 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.newFolder = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tsPanel1 = new System.Windows.Forms.ToolStrip();
            this.currentDirLabel1 = new System.Windows.Forms.Label();
            this.listViewPanel1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(372, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tsPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.currentDirLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.listViewPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(366, 582);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 6;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Location = new System.Drawing.Point(0, 0);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Size = new System.Drawing.Size(366, 25);
            this.tsPanel2.TabIndex = 0;
            this.tsPanel2.Text = "toolStrip1";
            // 
            // currentDirLabel2
            // 
            this.currentDirLabel2.AutoSize = true;
            this.currentDirLabel2.Location = new System.Drawing.Point(10, 5);
            this.currentDirLabel2.Name = "currentDirLabel2";
            this.currentDirLabel2.Size = new System.Drawing.Size(0, 13);
            this.currentDirLabel2.TabIndex = 1;
            // 
            // listViewPanel2
            // 
            this.listViewPanel2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size,
            this.date});
            this.listViewPanel2.FullRowSelect = true;
            this.listViewPanel2.GridLines = true;
            this.listViewPanel2.Location = new System.Drawing.Point(0, 21);
            this.listViewPanel2.Name = "listViewPanel2";
            this.listViewPanel2.Size = new System.Drawing.Size(366, 532);
            this.listViewPanel2.TabIndex = 0;
            this.listViewPanel2.UseCompatibleStateImageBehavior = false;
            this.listViewPanel2.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 228;
            // 
            // size
            // 
            this.size.Text = "size";
            this.size.Width = 47;
            // 
            // date
            // 
            this.date.Text = "date";
            this.date.Width = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandToolStripMenuItem,
            this.networkingToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.newToolStripMenuItem.Text = "new";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.printToolStripMenuItem.Text = "print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.commandToolStripMenuItem.Text = "command";
            // 
            // networkingToolStripMenuItem
            // 
            this.networkingToolStripMenuItem.Name = "networkingToolStripMenuItem";
            this.networkingToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.networkingToolStripMenuItem.Text = "networking";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 22);
            this.toolStripMenuItem2.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "F3 view";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(136, 638);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(117, 23);
            this.Copy.TabIndex = 9;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            // 
            // newFolder
            // 
            this.newFolder.Location = new System.Drawing.Point(259, 638);
            this.newFolder.Name = "newFolder";
            this.newFolder.Size = new System.Drawing.Size(117, 23);
            this.newFolder.TabIndex = 10;
            this.newFolder.Text = "NewFolder";
            this.newFolder.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 638);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.Location = new System.Drawing.Point(621, 638);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(117, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(13, 27);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tsPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.currentDirLabel1);
            this.splitContainer2.Panel2.Controls.Add(this.listViewPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(353, 582);
            this.splitContainer2.SplitterDistance = 26;
            this.splitContainer2.TabIndex = 13;
            // 
            // tsPanel1
            // 
            this.tsPanel1.Location = new System.Drawing.Point(0, 0);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Size = new System.Drawing.Size(353, 25);
            this.tsPanel1.TabIndex = 1;
            this.tsPanel1.Text = "toolStrip1";
            // 
            // currentDirLabel1
            // 
            this.currentDirLabel1.AutoSize = true;
            this.currentDirLabel1.Location = new System.Drawing.Point(4, 4);
            this.currentDirLabel1.MinimumSize = new System.Drawing.Size(10, 2);
            this.currentDirLabel1.Name = "currentDirLabel1";
            this.currentDirLabel1.Size = new System.Drawing.Size(10, 13);
            this.currentDirLabel1.TabIndex = 2;
            // 
            // listViewPanel1
            // 
            this.listViewPanel1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPanel1.FullRowSelect = true;
            this.listViewPanel1.GridLines = true;
            this.listViewPanel1.Location = new System.Drawing.Point(0, 20);
            this.listViewPanel1.Name = "listViewPanel1";
            this.listViewPanel1.Size = new System.Drawing.Size(350, 532);
            this.listViewPanel1.TabIndex = 1;
            this.listViewPanel1.UseCompatibleStateImageBehavior = false;
            this.listViewPanel1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name";
            this.columnHeader1.Width = 201;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "size";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "date";
            this.columnHeader3.Width = 58;
            // 
            // commander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 663);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.newFolder);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "commander";
            this.Text = "commander";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem commandToolStripMenuItem;
        private ToolStripMenuItem networkingToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip tsPanel2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Button button1;
        private Button Copy;
        private Button newFolder;
        private Button button4;
        private Button exit;
        private ListView listViewPanel2;
        private ColumnHeader name;
        private ColumnHeader size;
        private ColumnHeader date;
        private SplitContainer splitContainer2;
        private ToolStrip tsPanel1;
        private ListView listViewPanel1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label currentDirLabel2;
        private Label currentDirLabel1;
    }
}

