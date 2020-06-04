namespace Konvolucio.MCEL181123.View
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Kapcsolódás");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Funkciók");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Kalibráció");
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewNavigator = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(211, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 324);
            this.panel1.TabIndex = 1;
            // 
            // treeViewNavigator
            // 
            this.treeViewNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewNavigator.Location = new System.Drawing.Point(0, 0);
            this.treeViewNavigator.Name = "treeViewNavigator";
            treeNode1.Name = "ConnectionNode";
            treeNode1.Text = "Kapcsolódás";
            treeNode2.Name = "FunctionsNode";
            treeNode2.Text = "Funkciók";
            treeNode3.Name = "CalibrationNode";
            treeNode3.Text = "Kalibráció";
            this.treeViewNavigator.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeViewNavigator.Size = new System.Drawing.Size(202, 327);
            this.treeViewNavigator.TabIndex = 2;
            this.treeViewNavigator.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewNavigator_AfterSelect);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeViewNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(694, 327);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewNavigator;
    }
}
