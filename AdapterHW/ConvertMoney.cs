using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHW
{
    public class ConvertMoney : Dollar
    {
        private Euro CTeuro = new Euro();

        public double DollarPayment(double Money)
        {
            return CTeuro.EuroPayment((int)Money);
        }
    }
}
