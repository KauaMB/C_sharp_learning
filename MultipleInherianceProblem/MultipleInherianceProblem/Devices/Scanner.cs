using MultipleInherianceProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInherianceProblem.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }

        public string Scan()
        {
            return "Scanner scan result ";
        }
    }
}
