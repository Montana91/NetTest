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
using NetTest.DataSets;
using NetTest.DataSets.sitedsTableAdapters;

namespace NetTest.UserControls
{
    public partial class ucCashSpend : UserControl
    {
        mAccount acc = null;
        cAccount cAcc = null;

        ucLogin ucLoginRef = null;
        ucLoggedIn ucLoggedInRef = null;
        decimal amount = 0;
        string amountStr = "";
        public ucCashSpend()
        {
            InitializeComponent();
        }

        public void setRefs(ucLoggedIn liRef, ucLogin loRef)
        {
            ucLoggedInRef = liRef;
            ucLoginRef = loRef;
        }

        private void ucCashSpend_Load(object sender, EventArgs e)
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
            }
            PCScombo.DataSource = spCashSpendCategoryTableAdapter.GetData();
        }


        private void PCSamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCSamount_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void PCSamount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PCSspend_Click(object sender, EventArgs e)
        {
            spCashUpdateTableAdapter ta = new spCashUpdateTableAdapter();

            Guid catid = Guid.Parse("1AE2822A-1EC5-4E29-9670-56101BED344C");
            Decimal cash = Convert.ToDecimal(PCSamount.Text);
            siteds.spCashUpdateDataTable dt = ta.GetData(DateTime.Now, cAcc.accId, catid, cash, "Cs");
        }
    }
}
