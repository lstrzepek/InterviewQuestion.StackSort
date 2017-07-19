using System.Collections.Generic;

namespace StackSort
{
    public class Algorythm
    {
        public int[] Sort(int[] input)
        {
            var unsorted = new Stack<int>(input);
            var sorted = new Stack<int>(input.Length);
            int current;

            while (unsorted.Count > 0)
            {
                current = unsorted.Pop();
                while (sorted.Count > 0 && sorted.Peek() < current)
                {
                    unsorted.Push(sorted.Pop());
                }

                sorted.Push(current);
            }

            return sorted.ToArray();
        }
    }
}
