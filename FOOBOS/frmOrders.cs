using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                    //create order node & add orderline nodes
                    string ordertext = ord.OrderNum + " - " + ord.Supplier.Supplier1 + " - " + (ord.OrderDate != null ? ord.OrderDate.Value.ToString("MM/dd/yyyy") : string.Empty);
                    TreeNode ordnode = new TreeNode(ordertext, ordlnnodearray);
                    ordnode.Tag = ord.pkid;
                    orderNode.Nodes.Add(ordnode);
                    orderNode.Expand();
                }
            }

                this.DB = new FOOBOSDBEntities();
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
            if (e.Button == MouseButtons.Right)
            {
                this.currNode = e.Node;
                tvOrders.SelectedNode = this.currNode;
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

    }
}
