using System;
using System.Collections.Generic;

namespace Asm1
{
    public class DataAnalyser
    {
        // This is a private list of integers.
        private List<int> _numbers;

        // This is a private strategy object.
        private SummaryStrategy _strategy;

        // This is a public property that gets or sets the strategy object.
        public SummaryStrategy Strategy
        {
            get => _strategy;
            set => _strategy = value;
        }

        // This constructor creates a new data analyser with the specified strategy and numbers.
        public DataAnalyser(SummaryStrategy strategy, List<int> numbers)
        {
            this._strategy = strategy;
            this._numbers = numbers;
        }

        // This constructor creates a new data analyser with the default strategy and numbers.
        public DataAnalyser():
            this(new AverageSummary(), new List<int>())
        {
        }

        // This method summarises the numbers.
        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);
        }

        // This method adds a number to the numbers list.
        public void AddNumbers(int number)
        {
            _numbers.Add(number);
        }
    }



}
