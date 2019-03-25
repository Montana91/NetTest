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
        public PettyCash()
        {
            InitializeComponent();
        }

        private void PettyCash_Load(object sender, EventArgs e)
        {
            ucLoginF.Hide();
            ucLoggedInF.Hide();
            ucCashSpendF.Hide();

            ucLoggedInF.setRefs(ucLoginF, ucCashSpendF);

            ucLoginF.setRefs(ucLoggedInF);

            ucCashSpendF.setRefs(ucLoggedInF, ucLoginF);

            mAccount acc = new mAccount();

            Guid? acnt = acc.accountLoggedIn();
            if (acnt == null)
            {
                ucLoginF.Show();
            }
            else
            {
                ucLoggedInF.Show();
            }

        }
    }
}
