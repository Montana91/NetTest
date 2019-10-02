using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetTest.Models;


namespace NetTest.UserControls
{
    public partial class ucLoggedIn : UserControl
    {
        mAccount acc = null;
        cAccount cAcc = null;

        ucLogin ucLoginRef = null;
        ucCashSpend ucCashSpendRef = null;
        ucTransactions ucViewTransactionsRef = null;

        public ucLoggedIn()
        {
            InitializeComponent();
        }

        public void setRefs(ucLogin ucRef, ucCashSpend csRef, ucTransactions vtRef)
        {
            ucLoginRef = ucRef;
            ucCashSpendRef = csRef;
            ucViewTransactionsRef = vtRef;
        }


        private void ucLoggedIn_Load(object sender, EventArgs e)
        {
            acc = new mAccount();

            Guid? mAccount = acc.accountLoggedIn();
            if (mAccount == null)
            {
                this.Hide();
                if (ucLoginRef != null)
                {
                    ucLoginRef.Show();
                }
            }
            else
            {
                cAcc = new cAccount().readById((Guid)mAccount);
                mCash mCash = new mCash();
                LINuser.Text = cAcc.accUserName;
                LINbalance.Text = mCash.getBalance();
            }
        }

        private void LINspendcash_Click(object sender, EventArgs e)
        {
            this.Hide();
            ucCashSpendRef.Show();
        }

        private void LINtransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            ucViewTransactionsRef.Show();
        }
    }
}
