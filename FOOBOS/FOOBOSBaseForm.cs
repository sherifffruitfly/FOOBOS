using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOBOS
{
    public class FOOBOSBaseForm : System.Windows.Forms.Form
    {
        #region Members

        private bool loggedIn = false;
        private string currentUser = string.Empty;
        private string formFriendlyName = string.Empty;

        public string FormFriendlyName
        {
            get { return formFriendlyName; }
            set { formFriendlyName = value; }
        }

        public bool LoggedIn
        {
            get { return loggedIn; }
            set { loggedIn = value; }
        }

        public string CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        #endregion

        #region Constructors

        public FOOBOSBaseForm() : base()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            
        }

        public FOOBOSBaseForm(bool li, string un) : base()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            loggedIn = li;
            currentUser = un;
        }

        #endregion

        #region Methods

        public bool LogOut()
        {
            bool ret = false;


            ret = true;
            MessageBox.Show("Successfully logged out.");
            return ret;
        }

        public bool LogOut(string un)
        {
            bool ret = false;

            // mark db user log that currentuser logged out

            ret = true;
            MessageBox.Show("Successfully logged out " + CurrentUser);
            return ret;
        }

        #endregion

        #region Event Handlers

        private void OnProcessExit(object sender, EventArgs e)
        {
            if (this.CurrentUser == string.Empty)
            {
                this.LogOut();
            }
            else
            {
                this.LogOut(CurrentUser);
            }
        }

        #endregion
    }
}
