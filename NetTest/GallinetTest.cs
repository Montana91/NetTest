using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTest
{
    public partial class GallinetTest : Form
    {
        public GallinetTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butSearch.Visible = true;
            // TODO: This line of code loads data into the 'employee.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.employee.tblEmployee);

        }

        private void DoSearch(object sender, EventArgs e)
        {
        }
    }
}
