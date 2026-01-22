using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInherianceProblem.Devices
{
    internal abstract  class Device
    {
        public string SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);
    }
}
