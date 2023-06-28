using System;
using System.Collections.Generic;
using System.Text;

namespace Asm1
{
    internal class Program
    {

		static void Main(string[] args)
		{
			AverageSummary averagesummary = new AverageSummary();
			MinMaxSummary minmaxsummary = new MinMaxSummary();

			List<int> numbers = new List<int> { 1, 0, 3, 4, 8, 8, 4, 5, 0 };
			Console.Write("The number in the list are: ");
			Console.WriteLine(string.Join(",", numbers));
			DataAnalyser dataanalyser = new DataAnalyser(minmaxsummary, numbers);

			dataanalyser.Summarise();

			dataanalyser.AddNumbers(6);
			dataanalyser.AddNumbers(9);
			dataanalyser.AddNumbers(2003);

			dataanalyser.Strategy = averagesummary;
 
			dataanalyser.Summarise();
		}
	}
}
