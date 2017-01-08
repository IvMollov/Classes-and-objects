using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interface_Payable
{
    public interface Payable
    {
        double Retrieve(double amount);
        double Add(double sum);
        string PaymentAddress(string paymentAddress);

    }
}
