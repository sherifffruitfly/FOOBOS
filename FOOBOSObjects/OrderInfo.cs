using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOOBOSEntities;
using System.ComponentModel;

namespace FOOBOSObjects
{
    public class OrderInfo
    {
        #region Members

        private Order currord = null;
        private BindingList<OrderlineInfo> currordlns = null;
        private string ordernum = string.Empty;
        private string supplier = string.Empty;
        private string orderdate = string.Empty;
        private string description = string.Empty;
        private string orderedby = string.Empty;
        private string expecteddate = string.Empty;

        public Order CurrOrd
        {
            get { return currord; }
            set { currord = value; LoadOrderlines(value); } // if the client changes the order, autoupdate the orderlines
        }

        public BindingList<OrderlineInfo> CurrOrdlns
        {
            get { return currordlns; }
            set { currordlns = value; }
        }

        #endregion

        #region Constructors

        public OrderInfo(Order ord)
        {
            currord = ord;
            LoadOrder(ord);
            LoadOrderlines(ord); // load orderlines on NEW
        }

        #endregion

        #region Methods

        private void LoadOrder(Order ord)
        {

        }

        private void LoadOrderlines(Order ord)
        {
            currordlns = new BindingList<OrderlineInfo>();
            if (ord != null)
            {
                if (ord.OrderLines != null)
                {
                    foreach (OrderLine ordln in ord.OrderLines)
                    {
                        currordlns.Add(new OrderlineInfo(ordln));
                    }
                }
            }
        }

        #endregion
    }
}
