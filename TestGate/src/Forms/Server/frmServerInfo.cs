
using System.Windows.Forms;

namespace TestGate
{
    public partial class frmServerInfo : Form
    {
        public frmServerInfo()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '\u25CF';
        }

        private void txtPassword_MouseEnter(object sender, System.EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void txtPassword_MouseLeave(object sender, System.EventArgs e)
        {
            txtPassword.PasswordChar = '\u25CF';
        }

        private void chbPort_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbPort.Checked)
            {
                numPort.Enabled = true;

                numPort.Value = 5000;
            }
            else
            {
                numPort.Enabled = false;

                numPort.Value = 0;
            }


        }

       
    }
}
