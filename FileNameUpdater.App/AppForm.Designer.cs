namespace FileNameUpdater.App
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.sts = new System.Windows.Forms.StatusStrip();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc = new System.Windows.Forms.ToolStripContainer();
            this.spc = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnSelectPath = new System.Windows.Forms.ToolStripButton();
            this.mnu.SuspendLayout();
            this.tsc.ContentPanel.SuspendLayout();
            this.tsc.TopToolStripPanel.SuspendLayout();
            this.tsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc)).BeginInit();
            this.spc.Panel1.SuspendLayout();
            this.spc.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sts
            // 
            this.sts.Location = new System.Drawing.Point(0, 431);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(632, 22);
            this.sts.TabIndex = 0;
            this.sts.Text = "statusStrip1";
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(632, 24);
            this.mnu.TabIndex = 1;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // tsc
            // 
            // 
            // tsc.ContentPanel
            // 
            this.tsc.ContentPanel.Controls.Add(this.spc);
            this.tsc.ContentPanel.Size = new System.Drawing.Size(632, 382);
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc.Location = new System.Drawing.Point(0, 24);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(632, 407);
            this.tsc.TabIndex = 2;
            this.tsc.Text = "toolStripContainer1";
            // 
            // tsc.TopToolStripPanel
            // 
            this.tsc.TopToolStripPanel.Controls.Add(this.tsMain);
            // 
            // spc
            // 
            this.spc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc.Location = new System.Drawing.Point(0, 0);
            this.spc.Name = "spc";
            // 
            // spc.Panel1
            // 
            this.spc.Panel1.Controls.Add(this.tree);
            this.spc.Size = new System.Drawing.Size(632, 382);
            this.spc.SplitterDistance = 317;
            this.spc.TabIndex = 3;
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(317, 382);
            this.tree.TabIndex = 0;
            // 
            // tsMain
            // 
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectPath});
            this.tsMain.Location = new System.Drawing.Point(3, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(33, 25);
            this.tsMain.TabIndex = 0;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelectPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPath.Image")));
            this.btnSelectPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(23, 22);
            this.btnSelectPath.Text = "Select Path";
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tsc);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AppForm";
            this.Text = "File Name Updater";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.tsc.ContentPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.PerformLayout();
            this.tsc.ResumeLayout(false);
            this.tsc.PerformLayout();
            this.spc.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc)).EndInit();
            this.spc.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripContainer tsc;
        private System.Windows.Forms.SplitContainer spc;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btnSelectPath;
    }
}

