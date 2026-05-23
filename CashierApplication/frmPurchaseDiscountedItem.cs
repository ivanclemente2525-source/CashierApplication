using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }
        private DiscountedItem product;

        private void computebutton_Click(object sender, EventArgs e)
        {
            string itemName = itemtxtbox.Text;
            double price = Convert.ToDouble(pricetxtbox.Text);
            double discount = Convert.ToDouble(Discounttxtbox.Text);
            int quantity = Convert.ToInt32(quantitytxtbox.Text);
            DiscountedItem item = new DiscountedItem(itemName, price, quantity, discount);
            double total = item.getTotalPrice();
            totalamounttxtbox.Text = total.ToString("0.00");

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(totalamounttxtbox.Text);
            double payment = Convert.ToDouble(paymentreceivedtxtbox.Text);
            double change = payment - total;
            changetxtbox.Text = change.ToString("0.00");
        }

       
       
    }
}

