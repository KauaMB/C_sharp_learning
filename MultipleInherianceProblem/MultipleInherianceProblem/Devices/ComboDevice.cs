using MultipleInherianceProblem.Interfaces;

namespace MultipleInherianceProblem.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combo device processing " + doc);
        }

        public string Scan()
        {
            return "Combo Device scan result";
        }

        public void Print(string doc)
        {
            Console.WriteLine("Combo device print result: " + doc);
        }
    }

    /* IT'S IMPOSSIBLE FOR A CLASS TO
     * INHERIT TWO OR MORE SUPERCLASSES, BUT IT CAN "INHERIT" 
     * TWO OR MORE INTERFACE WITH NO PROBLEM!
     */
}
