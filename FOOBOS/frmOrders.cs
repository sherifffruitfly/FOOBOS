using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOOBOSObjects;
using FOOBOSEntities;

namespace FOOBOS
{
    public partial class frmOrders : FOOBOSBaseForm
    {
        private TreeNode currNode = null;
        private TreeNode parNode = null;
        private OrderLine ordln = null;
        private Order ord = null;

        public frmOrders()
        {
            InitializeComponent();
        }

        public frmOrders(Contact user)
        {
            InitializeComponent();
            this.CurrentUser = user;
            this.FormFriendlyName = "FOOBOS Orders";
            base.UpdateTitle();
            this.LoadTree();
        }

        private void LoadTree()
        {
            tvOrders.BeginUpdate();

            // make sure we're starting fresh
            tvOrders.Nodes.Clear();

            // add main parent node to tv
            TreeNode orderNode = new TreeNode("Orders");
            tvOrders.Nodes.Add(orderNode);

            //add orders to tv
            using (FOOBOSDBEntities con = new FOOBOSDBEntities())
            {
                var orderinfo = (from ord in con.Orders
                                select ord).OrderByDescending(x => x.OrderDate);

                List<Order> ords = orderinfo.ToList();

                foreach (Order ord in ords)
                {
                    //1) add tvnode
                    //2) get orderlines
                    //3) add orderline nodes

                    //get orderlines
                    var orderlineinfo = (from ordln in con.OrderLines
                                        where ordln.OrderID == ord.pkid
                                        select ordln).OrderBy(x => x.LineNum);
                    OrderLine[] ordlnarray = orderlineinfo.ToArray();

                    //create tv orderline node array
                    TreeNode[] ordlnnodearray = new TreeNode[ordlnarray.Count()];
                    for (int i = 0; i < ordlnarray.Count(); i++)
                    {
                        string nodetext = ordlnarray[i].LineNum.ToString() + " - " + ordlnarray[i].ProductCategory.Name + " (" + ordlnarray[i].Qty.ToString() + " " + ordlnarray[i].ProductCategory.UOM.Abbrev.ToString() + ")";
                        TreeNode linenode = new TreeNode(nodetext);
                        linenode.Tag = ordlnarray[i].pkid;
                        ordlnnodearray[i] = linenode;
                    }

                    // create order node & add orderline nodes
                    string ordertext = ord.OrderNum + " - " + ord.Supplier.Supplier1 + " - " + (ord.OrderDate != null ? ord.OrderDate.Value.ToString("MM/dd/yyyy") : string.Empty);
                    TreeNode ordnode = new TreeNode(ordertext, ordlnnodearray);
                    ordnode.Tag = ord.pkid;
                    orderNode.Nodes.Add(ordnode);
                    orderNode.Expand();
                }
            }

            tvOrders.EndUpdate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Order GetSelectedOrder(object tagkey)
        {
            Order ret = null;



            return ret;
        }

        private Order GetSelectedOrder(OrderLine ordln)
        {
            Order ret = null;



            return ret;
        }

        private OrderLine GetSelectedOrderline(object tagkey)
        {
            OrderLine ret = null;

            int ordlnpkid;
            bool res = int.TryParse((string)tagkey, out ordlnpkid);

            if (res == true)
            {
                using (FOOBOSDBEntities con = new FOOBOSDBEntities())
                {
                    var myordln = from ordlns in con.OrderLines
                                  where ordlns.pkid == ordlnpkid
                                  select ordlns;
                    ret = myordln.First();
                }
            }

            return ret;
        }

        private bool SaveOrderChanges()
        {
            bool ret = false;


            LoadTree();
            return ret;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = this.SaveOrderChanges();
                MessageBox.Show("Changes successfully saved: " +  result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: \r\n\r\n" + ex.Message);
            }

        }

        private void tvOrders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currNode = e.Node;
            parNode = e.Node.Parent;

            // load tabs with order & line info
            // switch to whichever tab based on order/orderline click

            object currenttag = currNode != null && currNode.Text != "Orders" ? ((string)currNode.Tag.ToString()).Split(' ')[0] : null;
            object currparenttag = parNode != null ? parNode.Tag : null;
            Order currord = null;
            OrderLine currordln = GetSelectedOrderline(currenttag);
            if (currordln == null)
            {
                //try for order alone
                currord = GetSelectedOrder(currenttag);
                if (currord == null)
                {
                    // really just for testing
                    //MessageBox.Show("No order or orderline selected.");
                }
            }
            else
            {
                // i have an order on the ef ordln object, so go ahead populate order textboxes

                // and populate the ordln textboxes

                // and switch tabs to the orderline tab
            }


        }

        private void tvOrders_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.currNode = e.Node;
            tvOrders.SelectedNode = this.currNode;
            this.LoadOrderTab();
            this.LoadOrderlineTab();

            if (e.Button == MouseButtons.Right)
            {
                
                this.parNode = e.Node.Parent;
                // check which node i'm on 
                // display appropriate context menu
                if (this.currNode.Text == "Orders")
                {
                    tvContextRoot.Show(MousePosition);
                }
                else if (this.currNode.Parent.Text == "Orders")
                {
                    tvContextOrder.Show(MousePosition);
                }
                else
                {
                    tvContextOrderline.Show(MousePosition);
                }
            }
        }

        private void LoadOrderTab()
        {
            if (this.currNode != null) // we're somewhere on the tree
            {
                if (this.currNode.Parent != null) // we're not on root node
                {
                    if (this.currNode.Parent.Text == "Orders") // this means we have an order node
                    {
                        //MessageBox.Show("Order! " + this.currNode.Text);
                        //set active tab to order
                        //populate text boxes
                        // means i need to parse the node.text
                        // prolly need a GETORDERFROMNODETEXT function to get to EF level
                        // ok if i'm here i have the orderid in node.tag which is all i need for EF data access
                        //tabControl1.SelectedTab = tabControl1.TabPages[0];
                        int orderpkid = 0;
                        if (this.currNode.Tag != null)
                        {
                            orderpkid = (int)this.currNode.Tag;
                            LoadOrderTab(orderpkid);
                            LoadOrderlines(orderpkid);
                        }
                    }
                }
            }
        }

        private void ClearOrderTab()
        {
            txtExpectedDate.Text = String.Empty;
            txtOrderDate.Text = String.Empty;
            txtOrderedBy.Text = String.Empty;
            txtOrderNo.Text = String.Empty;
            //comboSupplier.Items.Clear();
        }

        private void LoadOrderSuppliers(Order ord)
        {
            comboSupplier.Items.Clear();
            Supplier currentSupplier = null;
            this.DB = new FOOBOSDBEntities();
            var allsuppliers = (from sup in DB.Suppliers
                                select sup).OrderBy(c => c.Supplier1).ToList();

            var currsup = (from sup in DB.Suppliers
                           where sup.pkid == ord.SupplierID
                           select sup).ToList();

            if (currsup != null)
            {
                if (currsup.Count > 0)
                {
                    currentSupplier = currsup[0];

                    // fill supplier box
                    foreach (Supplier sup in allsuppliers)
                    {
                        comboSupplier.Items.Add(sup.Supplier1);
                    }

                    //select correct supplier
                    comboSupplier.SelectedIndex = comboSupplier.FindString(currentSupplier.Supplier1);
                }
            }

        }
        private void LoadOrderTab(int pkid)
        {
            ClearOrderTab();
            this.DB = new FOOBOSDBEntities();
            var myorder = (from ord in this.DB.Orders
                           where ord.pkid == pkid
                           select ord).ToList();

            if (myorder != null)
            {
                if (myorder.Count() > 0)
                {
                    Order ord = myorder[0];
                    // populate textboxes with first order (should only be one)
                    txtExpectedDate.Text = ord.ExpectedDate.ToString() ?? "NA";
                    txtOrderDate.Text = ord.OrderDate.ToString() ?? "NA";
                    txtOrderedBy.Text = "don't have this field in the db!";
                    txtOrderNo.Text = ord.OrderNum.ToString() ?? "NA";

                    LoadOrderSuppliers(ord);
                }
            }
        }

        private void LoadOrderlines(int ordid)
        {
            this.DB = new FOOBOSDBEntities();

            var myorderlines = (from ordln in DB.OrderLines
                                where ordln.OrderID == ordid
                                select ordln).ToList();

            dgvOrderlines.DataSource = GetOrderlines(ordid);
        }

        private void LoadOrderlineTab()
        {
            this.dgvOrderlines.DataSource = null;
            this.dgvOrderlines.Rows.Clear();

            if (this.currNode != null) // we're somewhere on the tree
            {
                if (this.currNode.Parent != null) // we're not on root node
                {
                    if (this.currNode.Parent.Parent != null) // this means we have an orderline node (there's only 3 levels)
                    {
                        //MessageBox.Show("Orderline! " + this.currNode.Text);
                        // set active tab to orderlines
                        // select correct orderline row or whatever 
                        // also load the order (might need a loadorder overload to pass a particular node rather than this.currnode)
                        // need to parse node text as in order
                        // did i populate the node.tag?
                        // ok if i'm here i have the orderlineid in the node.tag which means i also have the order
                        //tabControl1.SelectedTab = tabControl1.TabPages[1];

                        this.DB = new FOOBOSDBEntities();
                        int orderid = 0;
                        int orderlineid = (int)this.currNode.Tag;

                        var myorderlines = (from ordln in DB.OrderLines
                                           where ordln.pkid == orderlineid
                                           select ordln).ToList();

                        if (myorderlines.Count > 0)
                        {
                            orderid = myorderlines[0].OrderID ?? 0;
                        }

                        if (orderid > 0)
                        {
                            LoadOrderTab(orderid);

                            dgvOrderlines.DataSource = GetOrderlines(orderid);
                        }
                        
                    }
                }
            }
        }

        List<OrderLine> GetOrderlines(int orderid)
        {
            List<OrderLine> ret = null;

            var myorderlines2 = (from ordln in DB.OrderLines
                                 where ordln.OrderID == orderid
                                 select ordln).ToList();

            ret = myorderlines2;

            return ret;
        }

    }
}
