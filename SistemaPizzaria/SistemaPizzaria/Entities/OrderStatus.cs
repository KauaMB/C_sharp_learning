using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPizzaria.Entities
{
    internal enum OrderStatus
    {
        WaitingPayment = 0,
        Preparing = 1,
        Delivering = 2,
        Delivered = 3
    }
}
