using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOOBOSEntities;

namespace FOOBOSObjects
{
    public class OrderlineInfo
    {
        #region Members

        private OrderLine ordln = null;
        private string product = string.Empty;
        private string qty = string.Empty;
        private string receiveddate = string.Empty;
        private string productlocation = string.Empty;
        private string linenum = string.Empty;
        private string description = string.Empty;
        private string unitprice = string.Empty;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        public string Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public string ReceivedDate
        {
            get { return receiveddate; }
            set { receiveddate = value; }
        }

        public string ProductLocation
        {
            get { return productlocation; }
            set { productlocation = value; }
        }

        public string LineNum
        {
            get { return linenum; }
            set { linenum = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string UnitPrice
        {
            get { return unitprice; }
            set { unitprice = value; }
        }

        #endregion

        #region Constructors

        public OrderlineInfo(OrderLine initialordln)
        {
            ordln = initialordln;
            LoadOrderline(ordln);
        }

        #endregion

        #region Methods

        private void LoadOrderline(OrderLine varordln)
        {
            if (varordln != null)
            {
                this.product = (varordln.Product.Name ?? varordln.ProductCategory.Name) ?? "NA";
                this.qty = varordln.Qty.ToString() ?? "NA";
                this.receiveddate = varordln.ReceivedDate != null ? varordln.ReceivedDate.Value.ToShortDateString() : "NA";
                this.productlocation = varordln.ProductLocation.Location1.Name ?? "NA";
                this.linenum = varordln.LineNum != null ? varordln.LineNum.ToString() : "NA";
                this.description = varordln.Description ?? "NA";
                this.unitprice = varordln.UnitPrice != null ? varordln.UnitPrice.ToString() : "NA";
            }
        }

        public void SaveOrderline(OrderLine finalordln)
        {

        }

        #endregion
    }
}
