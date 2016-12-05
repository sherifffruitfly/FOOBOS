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
            this.FormFriendlyName = "Main Menu";
            this.Text = this.Text + " - " + this.FormFriendlyName + (this.CurrentUser == string.Empty ? " - (not logged in)" : this.CurrentUser);
        }

        #endregion

        #region Methods

        private void Setup()
        {
            
        }

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

        #endregion
    }
}
