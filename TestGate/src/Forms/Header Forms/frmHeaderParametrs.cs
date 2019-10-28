using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGate
{
    public partial class frmHeaderParametrs : Form
    {
        public frmHeaderParametrs()
        {
            InitializeComponent();
        }

        private void tspHeaderInfo_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void tspHeaderTemplate_txtNameTemplate_TextChanged(object sender, EventArgs e)
        {
            tspHeaderTemplate_Save.Enabled = !string.IsNullOrEmpty(tspHeaderTemplate_txtNameTemplate.Text);
        }

      

       

       

       


        

       
    }
}
