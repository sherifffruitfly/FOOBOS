using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOOBOSObjects;
using FOOBOSEntities;

namespace FOOBOS
{
    public class FOOBOSBaseForm : System.Windows.Forms.Form
    {
        #region Members

        private FOOBOSDBEntities db = null;
        private Contact currentUser = null;
        private string formFriendlyName = string.Empty;
        private Screen currentScreen = null;

        public FOOBOSDBEntities DB
        {
            get { return db; }
            set { db = value; }
        }
        public Screen CurrentScreen
        {
            get { return currentScreen; }
            set { currentScreen = value; }
        }

        public string FormFriendlyName
        {
            get { return formFriendlyName; }
            set { formFriendlyName = value; }
        }

        public Contact CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        #endregion

        #region Constructors

        public FOOBOSBaseForm() : base()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            this.SetScreen();
            
        }

        public FOOBOSBaseForm(Contact cu) : base()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            currentUser = cu;
            this.SetScreen();
        }

        #endregion

        #region Methods

        public void SetScreen()
        {
            Screen[] screens = Screen.AllScreens;
            //this.CurrentScreen = Screen.FromControl(this);
        }

        public void UpdateTitle()
        {
            this.Text = this.FormFriendlyName + (this.CurrentUser == null ? " - (not logged in)" : " - " + this.CurrentUser.UN);
        }

        public bool LogOut()
        {
            bool ret = false;

            // enter logout time in userlog table
            // set currentuser to null

            ret = true;
            MessageBox.Show("Successfully logged out.");
            return ret;
        }

        public bool LogOut(Contact un)
        {
            bool ret = false;

            // mark db user log that currentuser logged out

            ret = true;
            MessageBox.Show("Successfully logged out " + CurrentUser.UN);
            return ret;
        }

        #endregion

        #region Event Handlers

        private void OnProcessExit(object sender, EventArgs e)
        {
            if (this.CurrentUser == null)
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
