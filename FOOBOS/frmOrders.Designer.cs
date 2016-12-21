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
            this.txtUnused = new System.Windows.Forms.TextBox();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.txtExpectedDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
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
            this.dgvOrderlines = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabOrderlines.SuspendLayout();
            this.tvContextOrder.SuspendLayout();
            this.tvContextOrderline.SuspendLayout();
            this.tvContextRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlines)).BeginInit();
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
            this.tabOrders.Controls.Add(this.txtUnused);
            this.tabOrders.Controls.Add(this.txtOrderedBy);
            this.tabOrders.Controls.Add(this.txtExpectedDate);
            this.tabOrders.Controls.Add(this.label6);
            this.tabOrders.Controls.Add(this.txtOrderDate);
            this.tabOrders.Controls.Add(this.label5);
            this.tabOrders.Controls.Add(this.label4);
            this.tabOrders.Controls.Add(this.label3);
            this.tabOrders.Controls.Add(this.label2);
            this.tabOrders.Controls.Add(this.label1);
            this.tabOrders.Controls.Add(this.comboSupplier);
            this.tabOrders.Controls.Add(this.txtOrderNo);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(645, 362);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Order";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // txtUnused
            // 
            this.txtUnused.Location = new System.Drawing.Point(426, 132);
            this.txtUnused.Name = "txtUnused";
            this.txtUnused.Size = new System.Drawing.Size(100, 20);
            this.txtUnused.TabIndex = 11;
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.Location = new System.Drawing.Point(426, 48);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Size = new System.Drawing.Size(100, 20);
            this.txtOrderedBy.TabIndex = 10;
            // 
            // txtExpectedDate
            // 
            this.txtExpectedDate.Location = new System.Drawing.Point(224, 133);
            this.txtExpectedDate.Name = "txtExpectedDate";
            this.txtExpectedDate.Size = new System.Drawing.Size(100, 20);
            this.txtExpectedDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(224, 50);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ordered By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expected Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order #";
            // 
            // comboSupplier
            // 
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.Location = new System.Drawing.Point(53, 133);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(121, 21);
            this.comboSupplier.TabIndex = 1;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(53, 50);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNo.TabIndex = 0;
            // 
            // tabOrderlines
            // 
            this.tabOrderlines.Controls.Add(this.dgvOrderlines);
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
            // dgvOrderlines
            // 
            this.dgvOrderlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderlines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderlines.Location = new System.Drawing.Point(3, 3);
            this.dgvOrderlines.Name = "dgvOrderlines";
            this.dgvOrderlines.Size = new System.Drawing.Size(639, 356);
            this.dgvOrderlines.TabIndex = 0;
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
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            this.tabOrderlines.ResumeLayout(false);
            this.tvContextOrder.ResumeLayout(false);
            this.tvContextOrderline.ResumeLayout(false);
            this.tvContextRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderlines)).EndInit();
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
        private System.Windows.Forms.TextBox txtUnused;
        private System.Windows.Forms.TextBox txtOrderedBy;
        private System.Windows.Forms.TextBox txtExpectedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSupplier;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.DataGridView dgvOrderlines;
    }
}