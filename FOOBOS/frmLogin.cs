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
    public partial class frmLogin : FOOBOSBaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.CurrentUser = null;
        }

        public frmLogin(Contact cu)
        {
            this.CurrentUser = cu;
        }

        public bool ValidateLogin(string user, string pass)
        {
            bool ret = false;

            this.DB = new FOOBOSDBEntities();
            var logincheck = from con in DB.Contacts
                             where con.UN == user & con.PW == pass
                             select con;
            List<Contact> loginlist = logincheck.ToList();
            if (loginlist.Count >= 1)
            {
                ret = true;
                this.CurrentUser = loginlist[0];
            }

            return ret;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // if user = null then close app, otherwise just close form
            if (this.CurrentUser == null)
            {
                DialogResult dr = MessageBox.Show("Do you want to exit FOOBOS?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (ValidateLogin(txtUN.Text, txtPW.Text))
            {
                //open up main menu form, close this form, set user object, pass along to main menu form
                this.Close();
            }
            else
            {
                MessageBox.Show("Login information incorrect", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
