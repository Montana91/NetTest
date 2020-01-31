using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetTest.Models;

namespace NetTest
{
    public partial class PettyCash : Form
    {

        public static mUCs c_mUCs = null;
        
        public PettyCash()
        {
            InitializeComponent();
            c_mUCs = new mUCs(ucLoginF, ucLoggedInF, ucCashSpendF, ucTransactionsF);
        }

        private void PettyCash_Load(object sender, EventArgs e)
        {
            c_mUCs.HideAll();

            mAccount acc = new mAccount();

            Guid? acnt = acc.accountLoggedIn();
            if (acnt == null)
            {
                c_mUCs.m_ucLogin.Show();
            }
            else
            {
                c_mUCs.m_ucLoggedIn.Show();
            }

        }
    }
}
