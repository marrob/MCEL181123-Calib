﻿namespace Konvolucio.MCEL181123.Calib.View
{
    partial class MainView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sugó");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Konfigurációk");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Feszültségmérés");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Árammérés");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Funkciók");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Beállítások");
            this.treeViewNavigator = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewNavigator
            // 
            this.treeViewNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNavigator.Location = new System.Drawing.Point(0, 0);
            this.treeViewNavigator.Name = "treeViewNavigator";
            treeNode1.Name = "HelpNode";
            treeNode1.Text = "Sugó";
            treeNode2.Name = "ConfigsNode";
            treeNode2.Text = "Konfigurációk";
            treeNode3.Name = "VoltageMeasNode";
            treeNode3.Text = "Feszültségmérés";
            treeNode4.Name = "CurrentMeasNode";
            treeNode4.Text = "Árammérés";
            treeNode5.Name = "FunctionsNode";
            treeNode5.Text = "Funkciók";
            treeNode6.Name = "SettingsNode";
            treeNode6.Text = "Beállítások";
            this.treeViewNavigator.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewNavigator.Size = new System.Drawing.Size(136, 327);
            this.treeViewNavigator.TabIndex = 2;
            this.treeViewNavigator.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewNavigator_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewNavigator);
            this.splitContainer1.Size = new System.Drawing.Size(694, 327);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(694, 327);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewNavigator;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
