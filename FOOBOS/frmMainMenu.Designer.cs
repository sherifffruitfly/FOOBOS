namespace FOOBOS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.Enabled = false;
            this.btnReceive.Location = new System.Drawing.Point(43, 31);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 0;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // btnDistribute
            // 
            this.btnDistribute.Enabled = false;
            this.btnDistribute.Location = new System.Drawing.Point(138, 31);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(75, 23);
            this.btnDistribute.TabIndex = 1;
            this.btnDistribute.Text = "Distribute";
            this.btnDistribute.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Enabled = false;
            this.btnSuppliers.Location = new System.Drawing.Point(232, 31);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(75, 23);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Enabled = false;
            this.btnProducts.Location = new System.Drawing.Point(326, 31);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Enabled = false;
            this.btnCustomers.Location = new System.Drawing.Point(417, 31);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Enabled = false;
            this.btnUsers.Location = new System.Drawing.Point(43, 76);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 23);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Enabled = false;
            this.btnReports.Location = new System.Drawing.Point(138, 76);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnLocations
            // 
            this.btnLocations.Enabled = false;
            this.btnLocations.Location = new System.Drawing.Point(232, 76);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(75, 23);
            this.btnLocations.TabIndex = 7;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Enabled = false;
            this.btnInventory.Location = new System.Drawing.Point(326, 76);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(417, 76);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 177);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnDistribute);
            this.Controls.Add(this.btnReceive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOOBOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnExit;
    }
}