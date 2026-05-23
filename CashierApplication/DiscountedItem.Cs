using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{ 
        public class DiscountedItem : Item
        {
            private double item_discount;
            private double discounted_price;
            private double payment_amount;
            private double change;

            public DiscountedItem(string name, double price, int quantity, double discount)
                : base(name, price, quantity)
            {
                this.item_discount = discount;
            }

            public override double getTotalPrice()
            {
                double discountRate = this.item_discount * 0.01;
                this.discounted_price = this.item_price - (this.item_price * discountRate);
                this.total_price = this.discounted_price * this.item_quantity;
                return this.total_price;
            }

            public void setPayment(double amount)
            {
                this.payment_amount = amount;
            }

            public double getChange()
            {
                this.change = this.payment_amount - this.total_price;
                return this.change;
            }
        }
    }
