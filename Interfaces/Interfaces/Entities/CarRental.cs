using Interfaces.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    internal class CarRental
    {
        public Vehicle CarModel { get; set; }
        public DateTime Pickup { get; set; }
        public DateTime Return { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(Vehicle carModel, DateTime pickup, DateTime @return)
        {
            if (!(@return > pickup))
            {
                throw new DomainException("Return date must be greater than pickup!");
            }

            CarModel = carModel;
            Pickup = pickup;
            Return = @return;
        }

       

       
       
}
}
