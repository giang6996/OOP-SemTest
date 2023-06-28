using System;
using System.Collections.Generic;
using System.Text;

namespace Asm1
{
    internal class AverageSummary:SummaryStrategy
    {
		
		public float Average(List<int> numbers)
		{
			float total = 0;
			int count = numbers.Count;
			for (int i = 0; i < count; i++)
			{
				total += numbers[i];
			}
			return (float)(total / count);

		}
		public override void PrintSummary(List<int> numbers)
		{
			Console.WriteLine($"Average of the number list is: {Average(numbers)}");
		}
	}
}