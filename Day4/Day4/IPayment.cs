using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public interface IPayment
    {
        void MakePayment(decimal amount);
    }
}