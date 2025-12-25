using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment():F2}";
        }
    }
}
