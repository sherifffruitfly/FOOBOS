namespace FOOBOS
{
    partial class frmOrders
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvOrders = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabOrderlines = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tvContextOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tvContextOrderline = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteOrderlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvContextRoot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tvContextOrder.SuspendLayout();
            this.tvContextOrderline.SuspendLayout();
            this.tvContextRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 388);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvOrders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(985, 388);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvOrders
            // 
            this.tvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOrders.Location = new System.Drawing.Point(0, 0);
            this.tvOrders.Name = "tvOrders";
            this.tvOrders.Size = new System.Drawing.Size(328, 388);
            this.tvOrders.TabIndex = 0;
            this.tvOrders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOrders_AfterSelect);
            this.tvOrders.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvOrders_NodeMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Controls.Add(this.tabOrderlines);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(645, 362);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Order";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // tabOrderlines
            // 
            this.tabOrderlines.Location = new System.Drawing.Point(4, 22);
            this.tabOrderlines.Name = "tabOrderlines";
            this.tabOrderlines.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderlines.Size = new System.Drawing.Size(645, 362);
            this.tabOrderlines.TabIndex = 1;
            this.tabOrderlines.Text = "Order lines";
            this.tabOrderlines.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(898, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(788, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tvContextOrder
            // 
            this.tvContextOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddOrder,
            this.toolStripSeparator1,
            this.tsmiDeleteOrder});
            this.tvContextOrder.Name = "tvContextOrder";
            this.tvContextOrder.Size = new System.Drawing.Size(149, 54);
            this.tvContextOrder.Text = "Order 123";
            // 
            // tsmiAddOrder
            // 
            this.tsmiAddOrder.Name = "tsmiAddOrder";
            this.tsmiAddOrder.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddOrder.Text = "Add Orderline";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiDeleteOrder
            // 
            this.tsmiDeleteOrder.Name = "tsmiDeleteOrder";
            this.tsmiDeleteOrder.Size = new System.Drawing.Size(148, 22);
            this.tsmiDeleteOrder.Text = "Delete Order";
            // 
            // tvContextOrderline
            // 
            this.tvContextOrderline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteOrderlineToolStripMenuItem});
            this.tvContextOrderline.Name = "tvContextOrderline";
            this.tvContextOrderline.Size = new System.Drawing.Size(160, 26);
            this.tvContextOrderline.Text = "Orderline 987";
            // 
            // deleteOrderlineToolStripMenuItem
            // 
            this.deleteOrderlineToolStripMenuItem.Name = "deleteOrderlineToolStripMenuItem";
            this.deleteOrderlineToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteOrderlineToolStripMenuItem.Text = "Delete Orderline";
            // 
            // tvContextRoot
            // 
            this.tvContextRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem});
            this.tvContextRoot.Name = "tvContextRoot";
            this.tvContextRoot.Size = new System.Drawing.Size(130, 26);
            this.tvContextRoot.Text = "Root";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 464);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FOOBOS Orders";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tvContextOrder.ResumeLayout(false);
            this.tvContextOrderline.ResumeLayout(false);
            this.tvContextRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvOrders;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabOrderlines;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip tvContextOrder;
        private System.Windows.Forms.ContextMenuStrip tvContextOrderline;
        private System.Windows.Forms.ContextMenuStrip tvContextRoot;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteOrder;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
    }
}