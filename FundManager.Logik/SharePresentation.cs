using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public class SharePresentation
    {
        public string ShareId { get; set; }
        public int Quantity { get; set; }
        public double SharePrice { get; set; }
        public double HoldingValue { get { return SharePrice * Quantity; }  }
        public double ShareWeight { get; set; }
        public double BenchmarkWeight { get; set; }
        public double BenchmarkLessShareWeight { get { return BenchmarkWeight - ShareWeight; } }
        public int RecommendedShareMove { get; private set; }

        public void CalculateRecommendedShareMove(double totalPortfolioValue)
        {
            double desiredHoldingValue = totalPortfolioValue * BenchmarkWeight / 100;
            double numberOfSharesToMove = (desiredHoldingValue - HoldingValue) / SharePrice;

            RecommendedShareMove = (int)numberOfSharesToMove;
        }
    }
}
