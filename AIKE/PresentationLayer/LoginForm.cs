using AIKE.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIKE
{
    public partial class LoginForm : Form
    {
        UserController userController;
        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User logginInUser = userController.isUserValid(tbxUsername.Text,tbxPassword.Text);
            if (logginInUser != null) {
                MessageBox.Show("User login successful");
            }
        }
    }
}
