using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450069_6
{
    public class SaleManegement
    {
        Bill bill = new Bill();
        Coupon coupon = new Coupon();
        public void newBill()
        {

        }
        public bool addCoupontoBill(string couponCode)
        {
            return false;
        }
        public bool addProducttobill()
        {
            return true;
        }
        public double getBillTootalprice()
        {
            return 0;
        }
        public double payBill(int customePayment)
        {
            return customePayment;
        }
    }
}
