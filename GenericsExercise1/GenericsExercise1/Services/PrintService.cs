
namespace GenericsExercise1.Services
{
    internal class PrintService
    {
        public int[] Values = new int[10];
        public int Count = 0;

        public void AddValue(int value)
        {
            if (Count == 10)
            {
                throw new InvalidOperationException("Print service is full");
            }
            Values[Count] = value;
            Count++;
        }

        public int First()
        {
            if (Values[0] == null)
            {
                throw new InvalidOperationException("Insert some values first");
            }
            return Values[0];
        }

        public void Print()
        {
            Console.Write('[');

            foreach (int value in Values)
            {
                if (value != 0)
                {
                    Console.Write($"{value}, ");
                }
                
            }

            Console.Write(']');

        }
    }
}
