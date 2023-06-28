using System;
using System.Collections.Generic;
using System.Text;

namespace Asm1
{
    public class MinMaxSummary:SummaryStrategy
    {
        private int MinimiumStrategy(List<int> numbers)
        {
            int minNumber = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            return minNumber;

        }

        private int MaximiumStrategy(List<int> numbers)
        {
            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
        }
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine($"Minium number is:{MinimiumStrategy(numbers)}");
            Console.WriteLine($"And maximium number is:{MaximiumStrategy(numbers)}");
        }
    }
}
