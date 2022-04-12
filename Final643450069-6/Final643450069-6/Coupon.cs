using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450069_6
{
    public class Coupon : Discount
    {
        public string conponCode;
        public double minimunPrice;
        public Coupon()
        {

        }

        public void createCoupon(double min, int discountRate)
        {
            Random random = new Random();
        }

        public double getdiscount()
        {
            return 0;
        }
    }
}
