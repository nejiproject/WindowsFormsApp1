using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.XtraReports.Wizard.Native;

namespace WindowsFormsApp1
{
    public partial class AddDivision : Form
    {
        private string result = "";

        public AddDivision()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //DataBank.SubdivisionGl = tbAddDivision.Text;
            

            result = tbAddDivision.Text;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetResult()
        {
            return result;
        }
    }
}
