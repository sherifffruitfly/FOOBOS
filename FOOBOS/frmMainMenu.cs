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
    public partial class frmMainMenu : FOOBOSBaseForm
    {
        #region Constructors

        public frmMainMenu()
        {
            InitializeComponent();
            this.FormFriendlyName = "FOOBOS Main Menu";
            this.UpdateTitle();
            if (this.CurrentUser == null)
            {
                using (frmLogin li = new frmLogin())
                {
                    li.ShowDialog();
                    this.CurrentUser = li.CurrentUser;
                    UpdateTitle();
                    //this.Location = Screen.FromControl(li).WorkingArea.Location;
                    //this.Location = Screen.AllScreens[1].WorkingArea.Location;
                }
            }
        }

        #endregion

        #region Methods

        private bool UserLogout(string un)
        {
            bool ret = false;



            return ret;
        }

        #endregion

        #region Event Handlers

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            using (frmOrders ord = new FOOBOS.frmOrders(this.CurrentUser))
            {
                ord.ShowDialog();
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
