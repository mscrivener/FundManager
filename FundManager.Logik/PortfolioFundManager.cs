using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManager.Logik
{
    public class PortfolioFundManager
    {
        private IPortfolioManager PortfolioManager { get; set; }
        private IShareManager ShareManager { get; set; }
        private IBenchmarkIndexManager BenchmarkIndexManager { get; set; }

        public List<Model.Share> ShareList { get; private set; }
        public Model.Portfolio Portfolio { get; private set; }
        public List<Model.BenchmarkIndex> BenchmarkList { get; private set; }
        public List<SharePresentation> PresentationList { get; private set; }

        public PortfolioFundManager(IPortfolioManager portfolioManager, IShareManager shareManager, IBenchmarkIndexManager benchmarkIndexManager)
        {
            PortfolioManager = portfolioManager;
            ShareManager = shareManager;
            BenchmarkIndexManager = benchmarkIndexManager;
        }

        public void Load(string portfolioId)
        {
            Portfolio = PortfolioManager.Load("");

            ShareList = ShareManager.LoadShares(portfolioId);
            BenchmarkList = BenchmarkIndexManager.LoadBenchmarks(portfolioId);

            PopulatePresentationList();
        }

        public double GetTotalPortfolioValue()
        {
            return ShareList.Sum(s => s.Quantity * s.SharePrice) + (Portfolio.CashPennies / 100);
        }

        public int GetPortfolioCashPennies()
        {
            return Portfolio.CashPennies;
        }

        public void PopulatePresentationList()
        {
            PresentationList = new List<SharePresentation>();
            
            ShareList.ForEach(s => PresentationList.Add(new SharePresentation() { ShareId = s.Id, Quantity = s.Quantity, SharePrice = s.SharePrice }));
            PresentationList.ForEach(p => p.BenchmarkWeight = BenchmarkList.Find(b => b.ShareId.Equals(p.ShareId)).Weight);
            PresentationList.ForEach(p => p.ShareWeight = (p.HoldingValue/GetTotalPortfolioValue()*100));
            PresentationList.ForEach(p => p.CalculateRecommendedShareMove(GetTotalPortfolioValue()));
            
        }

        
    }
}
