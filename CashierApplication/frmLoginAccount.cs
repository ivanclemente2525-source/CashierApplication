using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CashierApplication
{
    
        public partial class frmLoginAccount : Form
        {
            private Cashier activeCashier = new Cashier("Earl Ivan L. Clemente", "Finance", "CashierIvan", "password123");

            public frmLoginAccount()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                if (activeCashier.validateLogin(Usernametxtbox.Text, Passwordtxtbox.Text))
                {
                    MessageBox.Show("Welcome " + activeCashier.getFullname() + " of " + activeCashier.getDepartment(), "User Login", MessageBoxButtons.OK);

                    frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem(this);
                    purchaseForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }