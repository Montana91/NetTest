using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetTest.DataSets;
using NetTest.DataSets.sitedsTableAdapters;

namespace NetTest.UserControls
{
    public partial class ucLogin : UserControl
    {
        ucLoggedIn ucLoggedInRef = null;

        public ucLogin()
        {
            InitializeComponent();
        }
        public void setRefs(ucLoggedIn liRef)
        {
            ucLoggedInRef = liRef;
        }
        private void liSubmit_Click(object sender, EventArgs e)
        {
            spAccountLoginOutTableAdapter ta = new spAccountLoginOutTableAdapter();
            siteds.spAccountLoginOutDataTable dt = ta.GetData(LIusername.Text, LIpwd.Text, DateTime.Now, "Li");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Licontinue.Visible = true;
                    LIstatus.Text = "Logged in";
                    LIusername.Enabled = false;
                    LIpwd.Enabled = false;
                    LIsubmit.Enabled = false;
                }
            }
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            Licontinue.Visible = false;
            LIstatus.Text = "";
        }

        private void Licontinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (ucLoggedInRef != null)
            {
                ucLoggedInRef.Show();
            }
        }
    }
}
