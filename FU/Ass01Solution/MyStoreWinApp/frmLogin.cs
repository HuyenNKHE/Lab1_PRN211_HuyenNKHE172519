using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;


namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Perform authentication
            MemberDAO memberDAO = new MemberDAO();
            bool isAuthenticated = memberDAO.AuthenticateMember(email, password);

            if (isAuthenticated)
            {
                frmMemberManagements memberManagementForm = new frmMemberManagements();
                memberManagementForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }
    }
    
}
