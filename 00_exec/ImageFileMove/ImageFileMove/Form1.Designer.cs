
namespace ImageFileMove
{
    partial class formMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.chkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.txtBoxBackupDir = new System.Windows.Forms.TextBox();
            this.lblListCount = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeViewDir = new System.Windows.Forms.TreeView();
            this.listViewFile = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.panelOption = new System.Windows.Forms.Panel();
            this.lblOrgFilePath = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelTitleBar.Controls.Add(this.lblFile);
            this.panelTitleBar.Controls.Add(this.lblNotice);
            this.panelTitleBar.Controls.Add(this.chkBoxOverwrite);
            this.panelTitleBar.Controls.Add(this.txtBoxBackupDir);
            this.panelTitleBar.Controls.Add(this.lblListCount);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(2046, 46);
            this.panelTitleBar.TabIndex = 0;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.Color.Yellow;
            this.lblFile.Location = new System.Drawing.Point(1087, 12);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(142, 23);
            this.lblFile.TabIndex = 4;
            this.lblFile.Text = "File Count :";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Red;
            this.lblNotice.Location = new System.Drawing.Point(1322, 12);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 23);
            this.lblNotice.TabIndex = 3;
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkBoxOverwrite
            // 
            this.chkBoxOverwrite.AutoSize = true;
            this.chkBoxOverwrite.Enabled = false;
            this.chkBoxOverwrite.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxOverwrite.ForeColor = System.Drawing.Color.White;
            this.chkBoxOverwrite.Location = new System.Drawing.Point(946, 10);
            this.chkBoxOverwrite.Name = "chkBoxOverwrite";
            this.chkBoxOverwrite.Size = new System.Drawing.Size(135, 27);
            this.chkBoxOverwrite.TabIndex = 2;
            this.chkBoxOverwrite.Text = "overwrite";
            this.chkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtBoxBackupDir
            // 
            this.txtBoxBackupDir.Enabled = false;
            this.txtBoxBackupDir.Location = new System.Drawing.Point(687, 9);
            this.txtBoxBackupDir.Name = "txtBoxBackupDir";
            this.txtBoxBackupDir.Size = new System.Drawing.Size(253, 28);
            this.txtBoxBackupDir.TabIndex = 1;
            this.txtBoxBackupDir.Text = "backup";
            // 
            // lblListCount
            // 
            this.lblListCount.AutoSize = true;
            this.lblListCount.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblListCount.Location = new System.Drawing.Point(1235, 12);
            this.lblListCount.Name = "lblListCount";
            this.lblListCount.Size = new System.Drawing.Size(0, 23);
            this.lblListCount.TabIndex = 0;
            this.lblListCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(2046, 1093);
            this.splitContainer1.SplitterDistance = 682;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeViewDir);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listViewFile);
            this.splitContainer2.Size = new System.Drawing.Size(682, 1093);
            this.splitContainer2.SplitterDistance = 227;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeViewDir
            // 
            this.treeViewDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDir.Location = new System.Drawing.Point(0, 0);
            this.treeViewDir.Name = "treeViewDir";
            this.treeViewDir.Size = new System.Drawing.Size(227, 1093);
            this.treeViewDir.TabIndex = 1;
            this.treeViewDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDir_BeforeExpand);
            this.treeViewDir.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDir_BeforeSelect);
            // 
            // listViewFile
            // 
            this.listViewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFile.HideSelection = false;
            this.listViewFile.Location = new System.Drawing.Point(0, 0);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(451, 1093);
            this.listViewFile.TabIndex = 1;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewFile_ItemSelectionChanged);
            this.listViewFile.Click += new System.EventHandler(this.listViewFile_Click);
            this.listViewFile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewFile_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.panelOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 1093);
            this.panel1.TabIndex = 7;
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 46);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1358, 1045);
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelOption.Controls.Add(this.lblOrgFilePath);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(1358, 46);
            this.panelOption.TabIndex = 7;
            // 
            // lblOrgFilePath
            // 
            this.lblOrgFilePath.AutoSize = true;
            this.lblOrgFilePath.ForeColor = System.Drawing.Color.White;
            this.lblOrgFilePath.Location = new System.Drawing.Point(13, 19);
            this.lblOrgFilePath.Name = "lblOrgFilePath";
            this.lblOrgFilePath.Size = new System.Drawing.Size(0, 18);
            this.lblOrgFilePath.TabIndex = 0;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2046, 1139);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Move";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeViewDir;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblOrgFilePath;
        private System.Windows.Forms.TextBox txtBoxBackupDir;
        private System.Windows.Forms.CheckBox chkBoxOverwrite;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblFile;
    }
}

